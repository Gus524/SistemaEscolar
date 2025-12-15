using Application.DTOs.HistorialAcademico;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.HistorialAcademico.Queries.GetHistorialDetalle;

public class GetHistorialDetalleQueryHandler(
    IReadRepositoryAsync<Alumno> alumnoRepository,
    IGetHistorialDetalleAlumno getHistorial
) : IRequestHandler<GetHistorialDetalleQuery, Response<HistorialAlumnoResponseDto>>
{
    public async Task<Response<HistorialAlumnoResponseDto>> Handle(GetHistorialDetalleQuery request, CancellationToken cancellationToken)
    {
        _ = await alumnoRepository.GetByIdAsync(request.NoBoleta, cancellationToken) ??
            throw new KeyNotFoundException($"No se encontró el Alumno con boleta '{request.NoBoleta}'.");
        
        var response = await getHistorial.GetHistorialDetalleAlumno(request.NoBoleta);

        return Response<HistorialAlumnoResponseDto>.Success(response);
    }
}
