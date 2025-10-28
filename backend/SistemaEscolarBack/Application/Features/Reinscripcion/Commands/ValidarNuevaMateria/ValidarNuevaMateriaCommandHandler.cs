using Application.DTOs.Reinscripcion;
using Application.Exceptions;
using Application.Interfaces;
using Application.Specifications.Alumno;
using Application.Specifications.Reinscripcion;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Reinscripcion.Commands.ValidarNuevaMateria;

public class ValidarNuevaMateriaCommandHandler(
    ICurrentUserService currentUserService,
    IReadRepositoryAsync<Alumno> alumnoRepository,
    IReinscripcionRepository reinscripcionRepository
) : IRequestHandler<ValidarNuevaMateriaCommand, Response<List<IdentificadorGrupoHorario>>>
{
    public async Task<Response<List<IdentificadorGrupoHorario>>> Handle(ValidarNuevaMateriaCommand request, CancellationToken cancellationToken)
    {
        var user = currentUserService.UserName ?? throw new KeyNotFoundException("No se encontro el usuario.");
        var boleta = long.Parse(user);

        var materia = request.NuevaMateria;
        var grupoActual = await reinscripcionRepository.GetGrupoActivo(materia.Carrera, materia.IdPlan,
                              materia.Semestre, materia.Turno,
                              materia.NoGrupo, materia.NoMateria, cancellationToken) ??
                          throw new KeyNotFoundException("No existe para la materia solicitada.");
        
        if (grupoActual.Disponibles < 1)
            throw new ApiException("No hay cupos disponibles para inscribir la materia.");

        var alumno = await alumnoRepository.FirstOrDefaultAsync(new AlumnoAgregateEstadoGeneralSpecification(boleta),
            cancellationToken) ?? throw new KeyNotFoundException("No se encontro un estado general para el alumno.");
        
        alumno.PuedeInscribirMateria(materia.NoMateria, materia.IdPlan, materia.Semestre);

        alumno = await alumnoRepository.FirstOrDefaultAsync(new AlumnoAgregateTrayectoriaSpecification(boleta),
            cancellationToken) ?? throw new KeyNotFoundException("No existe trayectoria para el alumno.");

        var creditos = request.HorarioActual?.Sum(h => h.Creditos);
        
        alumno.CreditosSuficientes(creditos ?? 0, grupoActual.Creditos);
        
        throw new NotImplementedException();
    }
}