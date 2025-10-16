using Application.DTOs.DatosPersonales;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.DatosPersonales.Queries.GetDatosPersonalesDocente;

public class GetDatosPersonalesDocenteQueryHandler(
    IDatosPersonalesRepository datosPersonalesRepository
    ) : IRequestHandler<GetDatosPersonalesDocenteQuery, Response<DatosPersonalesDocenteDto>>
{
    public async Task<Response<DatosPersonalesDocenteDto>> Handle(GetDatosPersonalesDocenteQuery request, CancellationToken cancellationToken)
    {
        var datosDocente = await datosPersonalesRepository.GetDatosPersonalesDocente(request.Rfc);
        return Response<DatosPersonalesDocenteDto>.Success(datosDocente);
    }
}
