using Application.DTOs.HistorialAcademico;

namespace Application.Interfaces;

public interface IGetHistorialDetalleAlumno
{
    Task<HistorialAlumnoResponseDto> GetHistorialDetalleAlumno(long boleta);
}