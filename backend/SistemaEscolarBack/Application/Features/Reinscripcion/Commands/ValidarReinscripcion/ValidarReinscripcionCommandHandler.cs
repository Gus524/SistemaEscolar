using Application.Exceptions;
using Application.Interfaces;
using Application.Specifications.Alumno;
using Application.Specifications.Reinscripcion;
using Application.Wrapper;
using AutoMapper;
using Domain.Entities;
using Domain.ValueObjects;
using MediatR;

namespace Application.Features.Reinscripcion.Commands.ValidarReinscripcion;

public class ValidarReinscripcionCommandHandler(
    ICurrentUserService currentUserService,
    IReinscripcionRepository reinscripcionRepository,
    IGrupoIdentificadorGenerator identificadorGenerator,
    IRepositoryAsync<Inscripcion> inscripcionRepository,
    IReadRepositoryAsync<Alumno> alumnoRepository,
    IMapper mapper
) : IRequestHandler<ValidarReinscripcionCommand, Response<bool>>
{
    public async Task<Response<bool>> Handle(ValidarReinscripcionCommand request, CancellationToken cancellationToken)
    {
        var user = currentUserService.UserName ?? throw new KeyNotFoundException("No se encotró usuario.");
        var boleta = long.Parse(user);

        var alumno =
            await alumnoRepository.FirstOrDefaultAsync(new AlumnoAgregateEstadoTrayectoriaSpecification(boleta),
                cancellationToken) ?? throw new KeyNotFoundException("El alumno no existe.");
        
        var inscripcion =
            await inscripcionRepository.FirstOrDefaultAsync(new InscripcionAgregateBoletaSpecification(boleta),
                cancellationToken) ??
            throw new KeyNotFoundException("El alumno no tiene inscripción para el semestre actual.");
        
        var horariosDto =
            await reinscripcionRepository.GetHorariosValidacion(identificadorGenerator.GetGrupos(request.Horario));

        var creditosSolicitados = horariosDto.Sum(g => g.Creditos);
        alumno.CreditosSuficientes(creditosSolicitados, alumno.HistorialAcademico.First().IdPlan);
        
        var grupoHorarioPropuesto = mapper.Map<List<GrupoHorario>>(horariosDto);

        foreach (var grupo in grupoHorarioPropuesto)
        {
            if (grupo.Disponibles < 1)
                throw new ApiException(
                    $"No hay cupo disponible en el grupo: ${grupo.Semestre}${grupo.AbrCarr}{grupo.Turno}{grupo.NoGrupo} con numero de materia: ${grupo.NoMateria}");
            
            alumno.PuedeInscribirMateria(grupo.NoMateria, grupo.IdPlan, grupo.Semestre);
            
            var nuevoDetalle = inscripcion.CrearDetalle(boleta, grupo.Semestre, grupo.Turno, grupo.AbrCarr,
                grupo.NoGrupo,
                grupo.IdPeriodo, grupo.NoMateria, grupo.IdPlan);
            
            inscripcion.AgregarMateria(nuevoDetalle, HorarioTemporal.FromGrupoHorarioEntity(grupo));
        }

        await inscripcionRepository.UpdateAsync(inscripcion, cancellationToken);
        await inscripcionRepository.SaveChangesAsync(cancellationToken);
        
        return Response<bool>.Success(true, "Horario guardado correctamente.");
    }
}