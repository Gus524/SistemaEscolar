using Application.DTOs.PeriodoActual;

namespace Application.Interfaces;

public interface IPeriodoActualRepository
{
    public Task<List<AlumnoCalificacionesDto>> GetAlumnoCalificaciones(long noBoleta, int idPlan);
    public Task<List<AlumnosGrupoDto>> GetAlumnosGrupo(string grupo, string clave);
    public Task<List<AlumnoCalificacionesDto>> GetAlumnoCalificaciones(long boleta);
}