using Application.DTOs.MapaCurricular;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.MapaCurricular.Queries.GetPlanesEstudio;

public class GetPlanesEstudioQueryHandler (
    IMapaCurricularRepository mapaRepository,
    IReadRepositoryAsync<Carrera> carreraRepository
) : IRequestHandler<GetPlanesEstudioQuery, Response<List<PlanEstudiosDto>>>
{
    public async Task<Response<List<PlanEstudiosDto>>> Handle(GetPlanesEstudioQuery request, CancellationToken cancellationToken)
    {
        _ = await carreraRepository.GetByIdAsync(request.Carrera, cancellationToken) ??
            throw new KeyNotFoundException("La carrera no existe.");

        var planes = await mapaRepository.GetPlanEstudios(request.Carrera);
        return Response<List<PlanEstudiosDto>>.Success(planes);
    }
}