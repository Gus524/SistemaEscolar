using Application.DTOs.HistorialAcademico;
using Application.Extensions;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.HistorialAcademico.Queries.GetHistorialDetalleAlumnoCurrent;

public class GetHistorialDetalleAlumnoCurrentQueryHandler(
    ICurrentUserService currentUserService,
    IGetHistorialDetalleAlumno getHistorial
) : IRequestHandler<GetHistorialDetalleAlumnoCurrentQuery, Response<HistorialAlumnoResponseDto>>
{
    public async Task<Response<HistorialAlumnoResponseDto>> Handle(GetHistorialDetalleAlumnoCurrentQuery request, CancellationToken cancellationToken)
    {
        var boleta = currentUserService.UserName ?? throw new KeyNotFoundException("Boleta no encontrada para el alumno.");

        var response = await getHistorial.GetHistorialDetalleAlumno(long.Parse(boleta));
        
        return Response<HistorialAlumnoResponseDto>.Success(response);
    }
}