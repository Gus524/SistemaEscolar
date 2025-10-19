using Application.DTOs.MapaCurricular;
using Application.Wrapper;
using MediatR;

namespace Application.Features.MapaCurricular.Queries.GetPlanesEstudio;

public class GetPlanesEstudioQuery : IRequest<Response<List<PlanEstudiosDto>>>
{
    public string Carrera { get; set; } = null!;
}