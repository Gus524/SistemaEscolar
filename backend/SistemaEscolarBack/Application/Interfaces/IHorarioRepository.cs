using Application.DTOs.Horario;

namespace Application.Interfaces;

public interface IHorarioRepository
{
    Task<List<DocenteHorarioDto>> GetDocenteHorario(string rfc);
    Task<List<AlumnoHorarioDto>> GetAlumnoHorario(long noBoleta);
    Task<List<HorarioGeneralDto>> GetHorarioGeneral(int idPlan, int? semestre, string? turno);
    Task<List<HorarioPorGrupoDto>> GetHorarioPorGrupo(string secuencia);
}
