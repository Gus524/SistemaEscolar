using Application.DTOs.Horario;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Horario.Queries.GetHorarioPorGrupo;

public class GetHorarioPorGrupoQuery : IRequest<Response<List<HorarioPorGrupoDto>>>
{
    public string Secuencia { get; set; } = null!;
}
