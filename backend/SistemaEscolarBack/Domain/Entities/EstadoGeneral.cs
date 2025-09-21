namespace Domain.Entities;

public class EstadoGeneral
{
    public string? Estado { get; set; }

    public long? NoBoleta { get; set; }

    public string AbrCarr { get; set; } = null!;

    public int Semestre { get; set; }

    public int IdPlan { get; set; }

    public string NoMateria { get; set; } = null!;

    public virtual HistorialAcademico? HistorialAcademico { get; set; }

    public virtual MapaCurricular MapaCurricular { get; set; } = null!;
}