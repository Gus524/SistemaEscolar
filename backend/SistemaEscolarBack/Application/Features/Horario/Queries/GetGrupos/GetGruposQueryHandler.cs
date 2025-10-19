using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Horario.Queries.GetGrupos;

public class GetGruposQueryHandler(IHorarioRepository horarioRepository) : IRequestHandler<GetGruposQuery, Response<List<string?>>>
{
    public async Task<Response<List<string?>>> Handle(GetGruposQuery request, CancellationToken cancellationToken)
    {
        var secuencias = await horarioRepository.GetSecuencias(request.PlanId, request.Semestre, request.Turno);

        return Response<List<string?>>.Success(secuencias);
    }
}