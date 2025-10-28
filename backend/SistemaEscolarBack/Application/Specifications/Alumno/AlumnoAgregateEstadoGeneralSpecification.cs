using Ardalis.Specification;

namespace Application.Specifications.Alumno;

public class AlumnoAgregateEstadoGeneralSpecification : Specification<Domain.Entities.Alumno>
{
    public AlumnoAgregateEstadoGeneralSpecification(long boleta)
    {
        Query.Where(a => a.NoBoleta.Equals(boleta))
            .Include(h => h.HistorialAcademico)
            .ThenInclude(e => e.EstadoGeneral);
    }
}