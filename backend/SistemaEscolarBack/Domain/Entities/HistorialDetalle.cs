namespace Domain.Entities;

public class HistorialDetalle
{
    public int Calificacion { get; set; }

    public string? FormaEval { get; set; }

    public DateOnly FechaEval { get; set; }

    public int IdPeriodo { get; set; }

    public long NoBoleta { get; set; }

    public string AbrCarr { get; set; } = null!;

    public int IdPlan { get; set; }

    public int Semestre { get; set; }

    public string NoMateria { get; set; } = null!;

    public virtual HistorialAcademico HistorialAcademico { get; set; } = null!;

    public virtual PeriodoEscolar IdPeriodoNavigation { get; set; } = null!;

    public virtual MapaCurricular MapaCurricular { get; set; } = null!;
}