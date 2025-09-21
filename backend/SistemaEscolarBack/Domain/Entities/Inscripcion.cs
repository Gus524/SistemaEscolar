using System.Collections.Generic;

namespace Domain.Entities;

public class Inscripcion
{
    public long NoBoleta { get; set; }

    public int IdPeriodo { get; set; }

    public int IdPlan { get; set; }

    public DateOnly FechaInscripcion { get; set; }

    public virtual HistorialAcademico HistorialAcademico { get; set; } = null!;

    public virtual PeriodoEscolar IdPeriodoNavigation { get; set; } = null!;

    public virtual ICollection<InscripcionDetalle> InscripcionDetalle { get; set; } = new List<InscripcionDetalle>();
}