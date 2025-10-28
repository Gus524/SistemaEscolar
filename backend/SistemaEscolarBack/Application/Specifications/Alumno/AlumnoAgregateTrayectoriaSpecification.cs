using Ardalis.Specification;

namespace Application.Specifications.Alumno;

public class AlumnoAgregateTrayectoriaSpecification : Specification<Domain.Entities.Alumno>
{
    public AlumnoAgregateTrayectoriaSpecification(long boleta)
    {
        Query.Where(a => a.NoBoleta.Equals(boleta))
            .Include(h => h.HistorialAcademico)
            .ThenInclude(t => t.TrayectoriaAlumno);
    }
}