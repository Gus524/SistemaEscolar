using Application.DTOs.Horario;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Horario.Queries.GetHorarioPorGrupo;

public class GetHorarioPorGrupoQueryHandler(IHorarioRepository repository) : IRequestHandler<GetHorarioPorGrupoQuery, Response<List<HorarioPorGrupoDto>>>
{
    public async Task<Response<List<HorarioPorGrupoDto>>> Handle(GetHorarioPorGrupoQuery request, CancellationToken cancellationToken)
    {
        var horario = await repository.GetHorarioPorGrupo(request.Secuencia);
        return Response<List<HorarioPorGrupoDto>>.Success(horario);
    }
}
