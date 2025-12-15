using Application.DTOs.HistorialAcademico;
using Application.Extensions;
using Application.Interfaces;

namespace Application.Services;

public class GetHisotrialDetalleAlumno(
    IHistorialAcademicoRepository historialRepository
) : IGetHistorialDetalleAlumno
{
    public async Task<HistorialAlumnoResponseDto> GetHistorialDetalleAlumno(long boleta)
    {
        var historial = await historialRepository.GetHistorialAlumno(boleta);
        var materias = await historialRepository.GetHistorialDetalle(boleta);
        return new HistorialAlumnoResponseDto
        {
            HistorialAlumno = historial,
            SemestreHistorial = materias.ToSemestreDto()
        };
    }
}