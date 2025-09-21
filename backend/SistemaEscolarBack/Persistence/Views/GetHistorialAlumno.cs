namespace Persistence.Views;

public class GetHistorialAlumno
{
    public long NoBoleta { get; set; }

    public string? Nombre { get; set; }

    public string DescCarr { get; set; } = null!;

    public string DescPlan { get; set; } = null!;

    public int IdPlan { get; set; }

    public float? Promedio { get; set; }

    public int? UltimoSemestre { get; set; }
}