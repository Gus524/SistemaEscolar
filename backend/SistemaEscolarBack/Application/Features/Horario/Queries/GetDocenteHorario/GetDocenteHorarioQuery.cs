using Application.DTOs.Horario;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Horario.Queries.GetDocenteHorario;

public class GetDocenteHorarioQuery : IRequest<Response<List<DocenteHorarioDto>>>
{
    public string Rfc { get; set; } = null!;
}
