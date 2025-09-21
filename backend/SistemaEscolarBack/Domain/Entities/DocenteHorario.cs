namespace Domain.Entities;

public class DocenteHorario
{
    public string Rfc { get; set; } = null!;

    public int Semestre { get; set; }

    public string AbrCarr { get; set; } = null!;

    public int IdPlan { get; set; }

    public string Turno { get; set; } = null!;

    public int NoGrupo { get; set; }

    public int IdPeriodo { get; set; }

    public string NoMateria { get; set; } = null!;

    public virtual GrupoHorario GrupoHorario { get; set; } = null!;

    public virtual Docente RfcNavigation { get; set; } = null!;
}