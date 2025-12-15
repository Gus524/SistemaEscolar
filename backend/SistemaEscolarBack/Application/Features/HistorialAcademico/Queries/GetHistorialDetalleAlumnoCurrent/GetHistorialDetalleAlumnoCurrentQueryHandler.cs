using Application.DTOs.HistorialAcademico;
using Application.Extensions;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.HistorialAcademico.Queries.GetHistorialDetalleAlumnoCurrent;

public class GetHistorialDetalleAlumnoCurrentQueryHandler(
    ICurrentUserService currentUserService,
    IHistorialAcademicoRepository historialRepository
) : IRequestHandler<GetHistorialDetalleAlumnoCurrentQuery, Response<HistorialAlumnoResponseDto>>
{
    public async Task<Response<HistorialAlumnoResponseDto>> Handle(GetHistorialDetalleAlumnoCurrentQuery request, CancellationToken cancellationToken)
    {
        var boleta = currentUserService.UserName ?? throw new KeyNotFoundException("Boleta no encontrada para el alumno.");

        var historial = await historialRepository.GetHistorialAlumno(long.Parse(boleta));
        var materias = await historialRepository.GetHistorialDetalle(long.Parse(boleta));

        var response = new HistorialAlumnoResponseDto
        {
            HistorialAlumno = historial,
            SemestreHistorial = materias.ToSemestreDto()
        };
        
        return Response<HistorialAlumnoResponseDto>.Success(response);
    }
}