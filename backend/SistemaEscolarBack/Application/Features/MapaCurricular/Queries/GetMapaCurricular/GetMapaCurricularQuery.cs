using Application.DTOs.MapaCurricular;
using Application.Wrapper;
using MediatR;

namespace Application.Features.MapaCurricular.Queries.GetMapaCurricular;

public class GetMapaCurricularQuery : IRequest<Response<List<MapaCurricularDto>>>
{
    public int Plan  { get; set; }
    public string Carrera { get; set; } = null!;
}