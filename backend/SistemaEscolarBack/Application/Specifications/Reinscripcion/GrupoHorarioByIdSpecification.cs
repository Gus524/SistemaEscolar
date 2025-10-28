using Ardalis.Specification;
using Domain.Entities;

namespace Application.Specifications.Reinscripcion;

public class GrupoHorarioByIdSpecification : Specification<GrupoHorario>
{
    public GrupoHorarioByIdSpecification(string carrera, int idPlan, int semestre, string turno, int noGrupo, string noMateria)
    {
        Query.Where(gh => gh.AbrCarr == carrera &&
                          gh.IdPlan == idPlan &&
                          gh.Semestre == semestre &&
                          gh.Turno == turno &&
                          gh.NoGrupo == noGrupo &&
                          gh.NoMateria == noMateria)
            .Include(gh => gh.Grupo)
            .ThenInclude(g => g.IdPeriodoNavigation.Activo);
    }
}