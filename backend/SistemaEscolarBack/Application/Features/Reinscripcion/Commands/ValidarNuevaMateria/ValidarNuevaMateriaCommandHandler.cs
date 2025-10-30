using Application.DTOs.Reinscripcion;
using Application.Exceptions;
using Application.Interfaces;
using Application.Specifications.Alumno;
using Application.Wrapper;
using AutoMapper;
using Domain.Entities;
using Domain.ValueObjects;
using MediatR;

namespace Application.Features.Reinscripcion.Commands.ValidarNuevaMateria;

public class ValidarNuevaMateriaCommandHandler(
    IMapper mapper,
    ICurrentUserService currentUserService,
    IReadRepositoryAsync<Alumno> alumnoRepository,
    IReinscripcionRepository reinscripcionRepository
) : IRequestHandler<ValidarNuevaMateriaCommand, Response<Unit>>
{
    public async Task<Response<Unit>> Handle(ValidarNuevaMateriaCommand request, CancellationToken cancellationToken)
    {
        var user = currentUserService.UserName ?? throw new KeyNotFoundException("No se encontro el usuario.");
        var boleta = long.Parse(user);

        var materia = request.NuevaMateria;
        
        var grupoSolicitado = await reinscripcionRepository.GetNuevoHorarioValidacion(GetGrupoMateria(materia)) ??
                           throw new KeyNotFoundException("La materia no existe.");
        
        if (grupoSolicitado.Disponibles < 1)
            throw new ApiException("No hay cupos disponibles para inscribir la materia.");

        var alumno = await alumnoRepository.FirstOrDefaultAsync(new AlumnoAgregateEstadoTrayectoriaSpecification(boleta),
            cancellationToken) ?? throw new KeyNotFoundException("No se encontro un estado general para el alumno.");
        
        alumno.PuedeInscribirMateria(materia.NoMateria, materia.IdPlan, materia.Semestre);

        var creditosPropuestos = (request.HorarioActual?.Sum(h => h.Creditos) ?? 0) + materia.Creditos;
        
        alumno.CreditosSuficientes(creditosPropuestos, alumno.HistorialAcademico.First().IdPlan);

        if (request.HorarioActual is null)
            return Response<Unit>.Success(Unit.Value, "Materia valida para inscribir.");
        
        var grupoHorarioActual = await reinscripcionRepository.GetHorariosValidacion(GetGrupos(request.HorarioActual));
        var gruposExistentes = mapper.Map<List<GrupoHorario>>(grupoHorarioActual);

        var horarioPropuesta = gruposExistentes.Select(HorarioTemporal.FromGrupoHorarioEntity).ToList().AsReadOnly();
        var nuevoGrupo = mapper.Map<GrupoHorario>(grupoSolicitado);
        var materiaNueva = HorarioTemporal.FromGrupoHorarioEntity(nuevoGrupo);

        return horarioPropuesta.Any(horario => horario.ComprobarEmpalme(materiaNueva))
            ? throw new ApiException("No se puede inscribir una materia que se empalme con el horario")
            : Response<Unit>.Success(Unit.Value, "Materia válida para inscribir.");
    }

    private static string GetGrupoMateria(IdentificadorGrupoHorario grupo)
    {
        return grupo.Semestre + grupo.Carrera + grupo.Turno + grupo.NoGrupo + grupo.NoMateria;
    }

    private static List<string> GetGrupos(List<IdentificadorGrupoHorario> grupos)
    {
        return grupos.Select(GetGrupoMateria).ToList();
    }
}