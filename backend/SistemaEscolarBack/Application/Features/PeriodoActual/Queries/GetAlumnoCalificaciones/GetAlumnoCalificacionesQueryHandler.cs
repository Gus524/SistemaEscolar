using Application.DTOs.PeriodoActual;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.PeriodoActual.Queries.GetAlumnoCalificaciones;

public class GetAlumnoCalificacionesQueryHandler(
    IReadRepositoryAsync<Alumno> alumnoRepository,
    IPeriodoActualRepository periodoRepository
) : IRequestHandler<GetAlumnoCalificacionesQuery, Response<List<AlumnoCalificacionesDto>>>
{
    public async Task<Response<List<AlumnoCalificacionesDto>>> Handle(GetAlumnoCalificacionesQuery request, CancellationToken cancellationToken)
    {
        _ = await alumnoRepository.GetByIdAsync(request.NoBoleta, cancellationToken) ??
            throw new KeyNotFoundException($"El alumno con boleta {request.NoBoleta} no existe.");

        var calificaciones = await periodoRepository.GetAlumnoCalificaciones(request.NoBoleta, request.Plan);
        return Response<List<AlumnoCalificacionesDto>>.Success(calificaciones);
    }
}