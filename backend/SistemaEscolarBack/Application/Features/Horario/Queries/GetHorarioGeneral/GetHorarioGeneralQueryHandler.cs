using Application.DTOs.Horario;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Horario.Queries.GetHorarioGeneral;

public class GetHorarioGeneralQueryHandler(IHorarioRepository repository) : IRequestHandler<GetHorarioGeneralQuery, Response<List<HorarioGeneralDto>>>
{
    public async Task<Response<List<HorarioGeneralDto>>> Handle(GetHorarioGeneralQuery request, CancellationToken cancellationToken)
    {
        var horario = await repository.GetHorarioGeneral(request.IdPlan, request.Semestre, request.Turno);
        return Response<List<HorarioGeneralDto>>.Success(horario);
    }
}
