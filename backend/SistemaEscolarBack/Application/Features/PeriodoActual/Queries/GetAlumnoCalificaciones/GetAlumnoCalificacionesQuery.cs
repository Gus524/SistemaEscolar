using Application.DTOs.PeriodoActual;
using Application.Wrapper;
using MediatR;

namespace Application.Features.PeriodoActual.Queries.GetAlumnoCalificaciones;

public class GetAlumnoCalificacionesQuery : IRequest<Response<List<AlumnoCalificacionesDto>>>
{
    public long NoBoleta { get; set; }
    public int Plan { get; set; }
}