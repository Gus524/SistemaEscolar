using Application.DTOs.Horario;
using Application.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repository;

public class HorarioRepository(ApplicationDbContext context, IMapper mapper) : IHorarioRepository
{
    public async Task<List<DocenteHorarioDto>> GetDocenteHorario(string rfc)
    {
        var horario = await context.GetDocenteHorario
            .AsNoTracking()
            .Where(h => h.Rfc == rfc)
            .ToListAsync();
        return mapper.Map<List<DocenteHorarioDto>>(horario);
    }

    public async Task<List<AlumnoHorarioDto>> GetAlumnoHorario(long noBoleta)
    {
        var horario = await context.GetAlumnoHorario
            .AsNoTracking()
            .Where(h => h.NoBoleta == noBoleta)
            .ToListAsync();
        return mapper.Map<List<AlumnoHorarioDto>>(horario);
    }

    public async Task<List<HorarioGeneralDto>> GetHorarioGeneral(int idPlan, int? semestre, string? turno)
    {
        var query = context.GetHorarios.AsNoTracking();

        query = query.Where(h => h.IdPlan == idPlan);

        if (semestre.HasValue)
        {
            query = query.Where(h => h.Semestre == semestre.Value);
        }

        if (!string.IsNullOrEmpty(turno))
        {
            query = query.Where(h => h.Turno == turno);
        }

        var horario = await query.ToListAsync();
        return mapper.Map<List<HorarioGeneralDto>>(horario);
    }

    public async Task<List<HorarioPorGrupoDto>> GetHorarioPorGrupo(string secuencia)
    {
        var horario = await context.GetHorarios
            .AsNoTracking()
            .Where(h => h.Secuencia == secuencia)
            .ToListAsync();
        return mapper.Map<List<HorarioPorGrupoDto>>(horario);
    }

    public async Task<List<string?>> GetSecuencias(int plan, int semestre, string? turno)
    {
        var query = context.GetGruposPlan
            .AsNoTracking()
            .Where(s => s.IdPlan == plan && s.Semestre == semestre);

        if (!string.IsNullOrEmpty(turno))
            query = query.Where(s => s.Turno == turno);

        return await query.Select(s => s.Secuencia).ToListAsync();
    }
}