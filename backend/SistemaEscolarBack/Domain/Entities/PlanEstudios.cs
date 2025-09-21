using System.Collections.Generic;

namespace Domain.Entities;

public class PlanEstudios
{
    public int IdPlan { get; set; }

    public string DescPlan { get; set; } = null!;

    public decimal NoPlan { get; set; }

    public string AbrCarr { get; set; } = null!;

    public virtual Carrera AbrCarrNavigation { get; set; } = null!;

    public virtual ICollection<HistorialAcademico> HistorialAcademico { get; set; } = new List<HistorialAcademico>();

    public virtual ICollection<MapaCurricular> MapaCurricular { get; set; } = new List<MapaCurricular>();
}