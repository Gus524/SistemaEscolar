using Application.DTOs.DatosPersonales;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.DatosPersonales.Queries.GetDatosPersonales;

public class GetDatosPersonalesQueryHandler(
    IDatosPersonalesRepository datosPersonalesRepository
) : IRequestHandler<GetDatosPersonalesQuery, Response<DatosPersonalesAlumnoDto>>
{
    public async Task<Response<DatosPersonalesAlumnoDto>> Handle(GetDatosPersonalesQuery request, CancellationToken cancellationToken)
    {
        var datosAlumno = await datosPersonalesRepository.GetDatosPersonalesAlumno(request.NoBoleta);
        return Response<DatosPersonalesAlumnoDto>.Success(datosAlumno);
    }
}