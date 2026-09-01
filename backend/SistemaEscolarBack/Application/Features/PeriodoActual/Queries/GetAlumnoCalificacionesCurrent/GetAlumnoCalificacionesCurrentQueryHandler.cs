using Application.DTOs.PeriodoActual;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.PeriodoActual.Queries.GetAlumnoCalificacionesCurrent;

public class GetAlumnoCalificacionesCurrentQueryHandler(
    ICurrentUserService  currentUserService,
    IPeriodoActualRepository  periodoActualRepository
) : IRequestHandler<GetAlumnoCalificacionesCurrentQuery, Response<List<AlumnoCalificacionesDto>>>
{
    public async Task<Response<List<AlumnoCalificacionesDto>>> Handle(GetAlumnoCalificacionesCurrentQuery request, CancellationToken cancellationToken)
    {
        var boleta = currentUserService.UserName ?? 
                     throw new KeyNotFoundException("Boleta no encontrada para alumno.");

        var calificaciones = await periodoActualRepository.GetAlumnoCalificaciones(long.Parse(boleta));
        return Response<List<AlumnoCalificacionesDto>>.Success(calificaciones);
    }
}