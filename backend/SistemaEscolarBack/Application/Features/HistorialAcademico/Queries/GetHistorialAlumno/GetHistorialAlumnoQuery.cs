using Application.DTOs.HistorialAcademico;
using Application.Wrapper;
using MediatR;

namespace Application.Features.HistorialAcademico.Queries.GetHistorialAlumno;

public class GetHistorialAlumnoQuery : IRequest<Response<HistorialAlumnoDto>>
{
    public long NoBoleta { get; set; }
}
