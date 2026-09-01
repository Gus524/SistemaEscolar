using Application.DTOs.Reinscripcion;
using Application.Interfaces;
using Application.Specifications.Reinscripcion;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Reinscripcion.Queries.GetMateriasReinscripcionCurrent;

public class GetMateriasReinscripcionCurrentQueryHandler(
    ICurrentUserService currentUserService,
    IReinscripcionRepository reinscripcionRepository,
    IReadRepositoryAsync<TrayectoriaAlumno> trayectoriaRepository
) : IRequestHandler<GetMateriasReinscripcionCurrentQuery, Response<InfoReinscripcionAlumnoDto>>
{
    public async Task<Response<InfoReinscripcionAlumnoDto>> Handle(GetMateriasReinscripcionCurrentQuery request, CancellationToken cancellationToken)
    {
        var boleta = currentUserService.UserName ??
                     throw new KeyNotFoundException("No se encontró usuario en la sesión actual.");

        var trayectoria =
            trayectoriaRepository.FirstOrDefaultAsync(new TrayectoriaByBoletaSpecification(long.Parse(boleta)),
                cancellationToken) ?? throw new KeyNotFoundException("No se encontró una trayectoria para el alumno.");
        
        var materias = reinscripcionRepository.GetMateriasDisponibles(long.Parse(boleta));
        
        await Task.WhenAll(materias, trayectoria);
        var response = new InfoReinscripcionAlumnoDto
        {
            TrayectoriaAlumno = trayectoria.Result,
            MateriasDisponibles = materias.Result,
        };
        return Response<InfoReinscripcionAlumnoDto>.Success(response);
    }
}