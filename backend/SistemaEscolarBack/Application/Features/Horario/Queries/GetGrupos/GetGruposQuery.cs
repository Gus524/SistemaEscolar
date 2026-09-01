using Application.Wrapper;
using MediatR;

namespace Application.Features.Horario.Queries.GetGrupos;

public class GetGruposQuery : IRequest<Response<List<string?>>>
{
    public int IdPlan { get; set; }
    public int Semestre { get; set; }
    public string? Turno { get; set; }
}