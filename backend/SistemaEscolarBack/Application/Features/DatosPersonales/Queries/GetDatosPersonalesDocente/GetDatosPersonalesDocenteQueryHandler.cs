using Application.DTOs.DatosPersonales;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.DatosPersonales.Queries.GetDatosPersonalesDocente;

public class GetDatosPersonalesDocenteQueryHandler(
    IDatosPersonalesRepository datosPersonalesRepository,
    IReadRepositoryAsync<Docente> docenteRepository
) : IRequestHandler<GetDatosPersonalesDocenteQuery, Response<DatosPersonalesDocenteDto>>
{
    public async Task<Response<DatosPersonalesDocenteDto>> Handle(GetDatosPersonalesDocenteQuery request, CancellationToken cancellationToken)
    {
        _ = await docenteRepository.GetByIdAsync(request.Rfc, cancellationToken) ??
            throw new KeyNotFoundException($"No se encontró el Docente con RFC '{request.Rfc}'.");

        var datosDocente = await datosPersonalesRepository.GetDatosPersonalesDocente(request.Rfc);
        return Response<DatosPersonalesDocenteDto>.Success(datosDocente);
    }
}
