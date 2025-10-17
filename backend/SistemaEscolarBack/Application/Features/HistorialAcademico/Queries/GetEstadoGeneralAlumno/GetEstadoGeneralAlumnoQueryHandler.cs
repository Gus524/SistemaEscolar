using Application.DTOs.HistorialAcademico;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.HistorialAcademico.Queries.GetEstadoGeneralAlumno;

public class GetEstadoGeneralAlumnoQueryHandler(IHistorialAcademicoRepository repository, IReadRepositoryAsync<Alumno> alumnoRepository) : IRequestHandler<GetEstadoGeneralAlumnoQuery, Response<List<EstadoGeneralAlumnoDto>>>
{
    public async Task<Response<List<EstadoGeneralAlumnoDto>>> Handle(GetEstadoGeneralAlumnoQuery request, CancellationToken cancellationToken)
    {
        _ = await alumnoRepository.GetByIdAsync(request.NoBoleta, cancellationToken) ??
            throw new KeyNotFoundException($"No se encontró el Alumno con boleta '{request.NoBoleta}'.");
        
        var estadoGeneral = await repository.GetEstadoGeneralAlumno(request.NoBoleta, request.IdPlan);
        return Response<List<EstadoGeneralAlumnoDto>>.Success(estadoGeneral);
    }
}
