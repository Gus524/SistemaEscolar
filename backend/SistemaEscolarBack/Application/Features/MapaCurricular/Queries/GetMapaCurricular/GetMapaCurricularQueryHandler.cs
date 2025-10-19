using Application.DTOs.MapaCurricular;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.MapaCurricular.Queries.GetMapaCurricular;

public class GetMapaCurricularQueryHandler (
    IMapaCurricularRepository mapaRepository,
    IReadRepositoryAsync<PlanEstudios> planRepository
) : IRequestHandler<GetMapaCurricularQuery, Response<List<MapaCurricularDto>>>
{
    public async Task<Response<List<MapaCurricularDto>>> Handle(GetMapaCurricularQuery request, CancellationToken cancellationToken)
    {
        _ = await planRepository.GetByIdAsync(request.Plan, cancellationToken) ??
            throw new KeyNotFoundException("El plan no existe.");

        var mapa = await mapaRepository.GetMapaCurricular(request.Plan, request.Carrera);
        return Response<List<MapaCurricularDto>>.Success(mapa);
    }
}