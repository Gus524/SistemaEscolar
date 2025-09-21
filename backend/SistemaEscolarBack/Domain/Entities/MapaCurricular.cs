using System.Collections.Generic;

namespace Domain.Entities;

public class MapaCurricular
{
    public string AbrCarr { get; set; } = null!;

    public int IdPlan { get; set; }

    public int IdMateria { get; set; }

    public int Semestre { get; set; }

    public int Creditos { get; set; }

    public string NoMateria { get; set; } = null!;

    public virtual Carrera AbrCarrNavigation { get; set; } = null!;

    public virtual ICollection<Ets> Ets { get; set; } = new List<Ets>();

    public virtual ICollection<GrupoHorario> GrupoHorario { get; set; } = new List<GrupoHorario>();

    public virtual ICollection<HistorialDetalle> HistorialDetalle { get; set; } = new List<HistorialDetalle>();

    public virtual Materia IdMateriaNavigation { get; set; } = null!;

    public virtual PlanEstudios IdPlanNavigation { get; set; } = null!;
}