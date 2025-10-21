using Application.DTOs.DatosPersonales;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.DatosPersonales.Queries.GetDatosPersonalesDocenteCurrent;

public class GetDatosPersonalesDocenteCurrentQueryHandler(
    ICurrentUserService currentUserService,
    IDatosPersonalesRepository datosPersonalesRepository
) : IRequestHandler<GetDatosPersonalesDocenteCurrentQuery, Response<DatosPersonalesDocenteDto>>
{
    public async Task<Response<DatosPersonalesDocenteDto>> Handle(GetDatosPersonalesDocenteCurrentQuery request, CancellationToken cancellationToken)
    {
        var rfc = currentUserService.UserName ??
                  throw new KeyNotFoundException("No se encontro rfc para el docente actual.");

        var datos = await datosPersonalesRepository.GetDatosPersonalesDocente(rfc);
        return Response<DatosPersonalesDocenteDto>.Success(datos);
    }
}