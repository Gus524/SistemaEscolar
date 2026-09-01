using Application.DTOs.DatosPersonales;
using Application.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repository;

public class DatosPersonalesRepository(ApplicationDbContext context, IMapper mapper) : IDatosPersonalesRepository
{
    public async Task<DatosPersonalesAlumnoDto> GetDatosPersonalesAlumno(long noBoleta)
    {
        var alumnos = await context.
            GetDatosAlumno
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.NoBoleta == noBoleta);
        return mapper.Map<DatosPersonalesAlumnoDto>(alumnos);
    }

    public async Task<DatosPersonalesDocenteDto> GetDatosPersonalesDocente(string rfc)
    {
        var docentes = await context.
            GetDatosDocente
            .AsNoTracking()
            .FirstOrDefaultAsync(d => d.Rfc == rfc);
        return mapper.Map<DatosPersonalesDocenteDto>(docentes);
    }
}