using Application.DTOs.Inicio;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repository;

internal class GetInicioRepository(
    ApplicationDbContext context
) : IGetInicioRepository
{
    public async Task<InicioAlumnoDto?> GetInicioAlumno(long noBoleta)
    {
        return await context.GetInicioAlumno
            .Where(a => a.NoBoleta == noBoleta)
            .AsNoTracking()
            .Select(a => new InicioAlumnoDto(a.IdInst, a.NomInst, a.IdPlan, a.DescCarr, a.Nombre!))
            .FirstOrDefaultAsync();
    }

    public async Task<InicioDocenteDto?> GetInicioDocente(string rfc)
    {
        return await context.GetInicioDocente
            .Where(a => a.Rfc == rfc)
            .AsNoTracking()
            .Select(d => new InicioDocenteDto(d.IdInst, d.NomInst, d.NomAcademia, d.Nombre!))
            .FirstOrDefaultAsync();
    }

    public async Task<InicioGestionDto?> GetInicioGestion(string usuario)
    {
        return await context.GetInicioGestion
            .Where(g => g.Usuario == usuario)
            .AsNoTracking()
            .Select(g => new InicioGestionDto(g.IdInst, g.NomInst))
            .FirstOrDefaultAsync();
    }
}