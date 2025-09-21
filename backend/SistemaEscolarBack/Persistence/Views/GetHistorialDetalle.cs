namespace Persistence.Views;

public class GetHistorialDetalle
{
    public string? Clave { get; set; }

    public string NomMateria { get; set; } = null!;

    public DateOnly FechaEval { get; set; }

    public string DescPeriodo { get; set; } = null!;

    public string? FormaEval { get; set; }

    public int Calificacion { get; set; }

    public int IdPlan { get; set; }

    public long NoBoleta { get; set; }

    public int Semestre { get; set; }
}