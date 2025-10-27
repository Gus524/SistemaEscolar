using Application.DTOs.Reinscripcion;

namespace Application.Interfaces;

public interface IReinscripcionRepository
{
    Task<IReadOnlyList<MateriasDisponiblesDto>> GetMateriasDisponibles(long boleta);
}