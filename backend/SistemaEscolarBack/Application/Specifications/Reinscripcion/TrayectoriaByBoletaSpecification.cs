using Application.DTOs.Reinscripcion;
using Ardalis.Specification;
using Domain.Entities;

namespace Application.Specifications.Reinscripcion;

public class TrayectoriaByBoletaSpecification : Specification<TrayectoriaAlumno, TrayectoriaAlumnoDto>
{
    public TrayectoriaByBoletaSpecification(long boleta)
    {
        Query.Where(t => t.NoBoleta == boleta);
        
        Query.Select(t => new TrayectoriaAlumnoDto
        {
            CreditosPermitidos = t.CredPermitidos ?? 0,
            PeriodosCursados = t.PerCursados ?? 0,
            PeriodosDisponibles = t.PerDisponibles ?? 0,
        });
    }
}