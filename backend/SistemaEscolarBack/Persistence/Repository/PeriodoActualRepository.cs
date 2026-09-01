using Application.DTOs.PeriodoActual;
using Application.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repository;

public class PeriodoActualRepository(ApplicationDbContext context, IMapper mapper) : IPeriodoActualRepository
{
    public async Task<List<AlumnoCalificacionesDto>> GetAlumnoCalificaciones(long noBoleta, int idPlan)
    {
        var calificaciones = await context.GetAlumnoCalificaciones
            .AsNoTracking()
            .Where(a => a.NoBoleta == noBoleta && a.IdPlan == idPlan)
            .ToListAsync();
        
        return mapper.Map<List<AlumnoCalificacionesDto>>(calificaciones);
    }

    public async Task<List<AlumnosGrupoDto>> GetAlumnosGrupo(string grupo, string clave)
    {
        var alumnos = await context.GetAlumnosGrupo
            .AsNoTracking()
            .Where(g => g.Grupo == grupo && g.Clave == clave)
            .ToListAsync();

        return mapper.Map<List<AlumnosGrupoDto>>(alumnos);
    }

    public async Task<List<AlumnoCalificacionesDto>> GetAlumnoCalificaciones(long boleta)
    {
        var calificaciones = await context.GetAlumnoCalificaciones
            .Where(a => a.NoBoleta == boleta)
            .ToListAsync();
        
        return mapper.Map<List<AlumnoCalificacionesDto>>(calificaciones);
    }
}