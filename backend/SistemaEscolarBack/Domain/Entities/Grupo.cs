using System.Collections.Generic;

namespace Domain.Entities;

public class Grupo
{
    public int Semestre { get; set; }

    public string AbrCarr { get; set; } = null!;

    public int IdPlan { get; set; }

    public string Turno { get; set; } = null!;

    public int NoGrupo { get; set; }

    public int IdPeriodo { get; set; }

    public virtual Carrera AbrCarrNavigation { get; set; } = null!;

    public virtual ICollection<GrupoHorario> GrupoHorario { get; set; } = new List<GrupoHorario>();

    public virtual PeriodoEscolar IdPeriodoNavigation { get; set; } = null!;
}