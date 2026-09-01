using Ardalis.Specification;

namespace Application.Specifications.Alumno;

public class AlumnoAgregateEstadoTrayectoriaSpecification : Specification<Domain.Entities.Alumno>
{
    public AlumnoAgregateEstadoTrayectoriaSpecification(long boleta)
    {
        Query.Where(a => a.NoBoleta.Equals(boleta))
            .Include(h => h.HistorialAcademico)
            .ThenInclude(e => e.EstadoGeneral);

        Query.Include(h => h.HistorialAcademico)
            .ThenInclude(e => e.TrayectoriaAlumno);
    }
}