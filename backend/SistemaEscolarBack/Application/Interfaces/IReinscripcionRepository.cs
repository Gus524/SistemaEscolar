using Application.DTOs.Reinscripcion;

namespace Application.Interfaces;

public interface IReinscripcionRepository
{
    Task<IReadOnlyList<MateriasDisponiblesDto>> GetMateriasDisponibles(long boleta);

    Task<GrupoActivoDto?> GetGrupoActivo(string abrCarr, int idPlan, int semestre,
        string turno, int noGrupo, string noMateria, CancellationToken cancellationToken = default);
}