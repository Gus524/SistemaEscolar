using Application.DTOs.Horario;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Horario.Queries.GetAlumnoHorario;

public class GetAlumnoHorarioQuery : IRequest<Response<List<AlumnoHorarioDto>>>
{
    public long NoBoleta { get; set; }
}
