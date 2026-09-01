using Application.DTOs.DatosPersonales;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.DatosPersonales.Queries.GetDatosPersonales;

public class GetDatosPersonalesQueryHandler(
    IReadRepositoryAsync<Alumno> alumnoRepository,
    IDatosPersonalesRepository datosPersonalesRepository
) : IRequestHandler<GetDatosPersonalesQuery, Response<DatosPersonalesAlumnoDto>>
{
    public async Task<Response<DatosPersonalesAlumnoDto>> Handle(GetDatosPersonalesQuery request, CancellationToken cancellationToken)
    {
        _ = await alumnoRepository.GetByIdAsync(request.NoBoleta, cancellationToken) ??
                     throw new KeyNotFoundException("El alumno no existe.");
        
        var datosAlumno = await datosPersonalesRepository.GetDatosPersonalesAlumno(request.NoBoleta);
        return Response<DatosPersonalesAlumnoDto>.Success(datosAlumno);
    }
}