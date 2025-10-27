using Application.DTOs.Reinscripcion;
using Application.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repository;

public class ReinscripcionRepository(
    ApplicationDbContext context, 
    IMapper mapper
) : IReinscripcionRepository
{
    public async Task<IReadOnlyList<MateriasDisponiblesDto>> GetMateriasDisponibles(long boleta)
    {
        var materias = await context.GetMateriasInscripcion
            .AsNoTracking().Where(m => m.NoBoleta == boleta)
            .OrderBy(m => m.Semestre)
            .ThenBy(m => m.Turno)
            .ThenBy(m => m.NoGrupo)
            .ThenBy(m => m.NoMateria)
            .ToListAsync();
        
        return mapper.Map<IReadOnlyList<MateriasDisponiblesDto>>(materias);
    }
}