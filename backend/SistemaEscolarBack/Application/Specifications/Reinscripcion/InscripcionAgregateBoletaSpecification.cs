using Ardalis.Specification;
using Domain.Entities;

namespace Application.Specifications.Reinscripcion;

public class InscripcionAgregateBoletaSpecification : Specification<Inscripcion>, ISingleResultSpecification<Inscripcion>
{
    public InscripcionAgregateBoletaSpecification(long boleta)
    {
        Query.Where(i => i.NoBoleta == boleta)
            .Include(i => i.IdPeriodoNavigation.Activo)
            .Include(i => i.InscripcionDetalle);
    }
}