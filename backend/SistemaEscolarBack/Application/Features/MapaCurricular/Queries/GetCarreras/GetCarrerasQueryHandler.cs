using Application.DTOs.MapaCurricular;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.MapaCurricular.Queries.GetCarreras;

public class GetCarrerasQueryHandler(
    IMapaCurricularRepository mapaRepository,
    IReadRepositoryAsync<Institucion> institucionRepository
) : IRequestHandler<GetCarrerasQuery, Response<List<CarrerasDto>>>
{
    public async Task<Response<List<CarrerasDto>>> Handle(GetCarrerasQuery request, CancellationToken cancellationToken)
    {
        _ = await institucionRepository.GetByIdAsync(request.Institucion, cancellationToken) ??
            throw new KeyNotFoundException("La institución no existe.");

        var carreras = await mapaRepository.GetCarreras(request.Institucion);
        return Response<List<CarrerasDto>>.Success(carreras);
    }
}