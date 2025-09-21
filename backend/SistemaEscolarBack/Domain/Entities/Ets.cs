namespace Domain.Entities;

public class Ets
{
    public string? Rfc { get; set; }

    public string AbrCarr { get; set; } = null!;

    public int IdPlan { get; set; }

    public string Turno { get; set; } = null!;

    public int Semestre { get; set; }

    public string NoMateria { get; set; } = null!;

    public string? Dia { get; set; }

    public TimeOnly? HoraI { get; set; }

    public TimeOnly? HoraFin { get; set; }

    public string? Salon { get; set; }

    public int IdPeriodo { get; set; }

    public int Ronda { get; set; }

    public virtual PeriodoEscolar IdPeriodoNavigation { get; set; } = null!;

    public virtual MapaCurricular MapaCurricular { get; set; } = null!;

    public virtual Docente? RfcNavigation { get; set; }
}