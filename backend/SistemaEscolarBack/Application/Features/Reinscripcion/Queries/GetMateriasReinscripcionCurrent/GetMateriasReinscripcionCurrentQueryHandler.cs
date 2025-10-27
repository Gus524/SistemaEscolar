using Application.DTOs.Reinscripcion;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Reinscripcion.Queries.GetMateriasReinscripcionCurrent;

public class GetMateriasReinscripcionCurrentQueryHandler(
    ICurrentUserService currentUserService,
    IReinscripcionRepository reinscripcionRepository
) : IRequestHandler<GetMateriasReinscripcionCurrentQuery, Response<IReadOnlyList<MateriasDisponiblesDto>>>
{
    public async Task<Response<IReadOnlyList<MateriasDisponiblesDto>>> Handle(GetMateriasReinscripcionCurrentQuery request, CancellationToken cancellationToken)
    {
        var boleta = currentUserService.UserName ??
                     throw new KeyNotFoundException("No se encontró usuario en la sesión actual.");

        var materias = await reinscripcionRepository.GetMateriasDisponibles(long.Parse(boleta));
        return Response<IReadOnlyList<MateriasDisponiblesDto>>.Success(materias);
    }
}