using Application.DTOs.HistorialAcademico;
using Application.Wrapper;
using MediatR;

namespace Application.Features.HistorialAcademico.Queries.GetEstadoGeneralAlumno;

public class GetEstadoGeneralAlumnoQuery : IRequest<Response<List<EstadoGeneralAlumnoDto>>>
{
    public long NoBoleta { get; set; }
    public int IdPlan { get; set; }
}
