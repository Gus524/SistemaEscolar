using Application.DTOs.PeriodoActual;

namespace Application.Interfaces;

public interface IPeriodoActualRepository
{
    public Task<AlumnoCalificacionesDto> GetAlumnoCalificaciones(long noBoleta, int idPlan);
    public Task<List<AlumnosGrupoDto>> GetAlumnosGrupo(string grupo, string clave);
}