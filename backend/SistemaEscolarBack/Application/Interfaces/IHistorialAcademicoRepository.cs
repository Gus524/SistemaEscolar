using Application.DTOs.HistorialAcademico;

namespace Application.Interfaces;

public interface IHistorialAcademicoRepository
{
    Task<HistorialAlumnoDto> GetHistorialAlumno(long noBoleta);
    Task<List<MateriaDetalleDto>> GetHistorialDetalle(long noBoleta);
    Task<List<EstadoGeneralAlumnoDto>> GetEstadoGeneralAlumno(long noBoleta, int idPlan);
}
