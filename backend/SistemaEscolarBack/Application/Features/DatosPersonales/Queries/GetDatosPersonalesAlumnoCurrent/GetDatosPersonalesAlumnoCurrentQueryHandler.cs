using Application.DTOs.DatosPersonales;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.DatosPersonales.Queries.GetDatosPersonalesAlumnoCurrent;

public class GetDatosPersonalesAlumnoCurrentQueryHandler(
    ICurrentUserService currentUserService,
    IDatosPersonalesRepository datosPersonalesRepository
) : IRequestHandler<GetDatosPeronalesAlumnoCurrentQuery, Response<DatosPersonalesAlumnoDto>>
{
    public async Task<Response<DatosPersonalesAlumnoDto>> Handle(GetDatosPeronalesAlumnoCurrentQuery request, CancellationToken cancellationToken)
    {
        var boleta = currentUserService.UserName ??
                     throw new KeyNotFoundException("No se encontro boleta para el usuario actual.");

        var datos = await datosPersonalesRepository.GetDatosPersonalesAlumno(long.Parse(boleta));

        return Response<DatosPersonalesAlumnoDto>.Success(datos);
    }
}