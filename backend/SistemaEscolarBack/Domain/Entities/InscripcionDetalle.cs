namespace Domain.Entities;

public class InscripcionDetalle
{
    public int? CalParcial1 { get; set; }

    public int? CalParcial2 { get; set; }

    public int? CalParcial3 { get; set; }

    public int? CalExtra { get; set; }

    public int? CalFinal { get; set; }

    public long NoBoleta { get; set; }

    public int Semestre { get; set; }

    public string AbrCarr { get; set; } = null!;

    public string Turno { get; set; } = null!;

    public int NoGrupo { get; set; }

    public int IdPeriodo { get; set; }

    public string NoMateria { get; set; } = null!;

    public int IdPlan { get; set; }

    public virtual GrupoHorario GrupoHorario { get; set; } = null!;

    public virtual Inscripcion Inscripcion { get; set; } = null!;
}