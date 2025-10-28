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

    public async Task<GrupoActivoDto?> GetGrupoActivo(string abrCarr, int idPlan, int semestre, string turno, int noGrupo, string noMateria,
        CancellationToken cancellationToken = default)
    {
        var query = from p in context.PeriodoEscolar 
            join gh in context.GrupoHorario on p.IdPeriodo equals gh.IdPeriodo
        join mc in context.MapaCurricular on new { gh.IdPlan, gh.AbrCarr, gh.Semestre, gh.NoMateria }
        equals new { mc.IdPlan, mc.AbrCarr, mc.Semestre, mc.NoMateria }
            where p.Activo == true
            && gh.AbrCarr == abrCarr
            && gh.IdPlan == idPlan
            && gh.Semestre == semestre
            && gh.Turno == turno
            && gh.NoGrupo == noGrupo
            && gh.NoMateria == noMateria 
            select new GrupoActivoDto
        {
            IdPeriodo = p.IdPeriodo,
            AbrCarr = gh.AbrCarr,
            Semestre = gh.Semestre,
            IdPlan = gh.IdPlan,
            NoMateria = gh.NoMateria,
            Turno = gh.Turno,
            NoGrupo = gh.NoGrupo,
            Creditos = mc.Creditos,
            Disponibles = gh.Disponibles ?? 0,
        };

        return await query.AsNoTracking().FirstOrDefaultAsync(cancellationToken);
    }
}