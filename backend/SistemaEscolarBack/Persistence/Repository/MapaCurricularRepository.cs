using Application.DTOs.MapaCurricular;
using Application.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repository;

public class MapaCurricularRepository(
    ApplicationDbContext context,
    IMapper mapper
) : IMapaCurricularRepository
{
    public async Task<List<CarrerasDto>> GetCarreras(int institucion)
    {
        var carreras = await context.GetCarrerasInst
            .Where(c => c.IdInst == institucion)
            .ToListAsync();
        
        return mapper.Map<List<CarrerasDto>>(carreras);
    }

    public async Task<List<PlanEstudiosDto>> GetPlanEstudios(string carrera)
    {
        var planes = await context.GetForMapa
            .Where(p => p.AbrCarr == carrera)
            .ToListAsync();
        
        return mapper.Map<List<PlanEstudiosDto>>(planes);
    }

    public async Task<List<MapaCurricularDto>> GetMapaCurricular(int plan, string carrera)
    {
        var mapa = await context.GetMapaCurricular
            .Where(m => m.AbrCarr == carrera && m.IdPlan == plan)
            .ToListAsync();
        
        return mapper.Map<List<MapaCurricularDto>>(mapa);
    }
}