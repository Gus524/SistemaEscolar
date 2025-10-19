using Application.DTOs.HistorialAcademico;
using Application.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repository;

public class HistorialAcademicoRepository(ApplicationDbContext context, IMapper mapper) : IHistorialAcademicoRepository
{
    public async Task<HistorialAlumnoDto> GetHistorialAlumno(long noBoleta)
    {
        var historial = await context.GetHistorialAlumno
            .AsNoTracking()
            .FirstOrDefaultAsync(h => h.NoBoleta == noBoleta);
        return mapper.Map<HistorialAlumnoDto>(historial);
    }

    public async Task<List<MateriaDetalleDto>> GetHistorialDetalle(long noBoleta)
    {
        var detalle = await context.GetHistorialDetalle
            .AsNoTracking()
            .Where(d => d.NoBoleta == noBoleta)
            .OrderBy(d => d.Clave)
            .ToListAsync();
        return mapper.Map<List<MateriaDetalleDto>>(detalle);
    }

    public async Task<List<EstadoGeneralAlumnoDto>> GetEstadoGeneralAlumno(long noBoleta, int idPlan)
    {
        var estado = await context.GetEstadoGeneralAlumno
            .AsNoTracking()
            .Where(e => e.NoBoleta == noBoleta && e.IdPlan == idPlan)
            .ToListAsync();
        return mapper.Map<List<EstadoGeneralAlumnoDto>>(estado);
    }
}
