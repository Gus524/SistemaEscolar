using Application.DTOs.Horario;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Horario.Queries.GetHorarioGeneral;

public class GetHorarioGeneralQuery : IRequest<Response<List<HorarioGeneralDto>>>
{
    public int IdPlan { get; set; }
    public int? Semestre { get; set; }
    public string? Turno { get; set; }
}
