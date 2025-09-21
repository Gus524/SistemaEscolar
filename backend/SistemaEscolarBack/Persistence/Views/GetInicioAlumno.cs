namespace Persistence.Views;

public class GetInicioAlumno
{
    public string? Nombre { get; set; }

    public long NoBoleta { get; set; }

    public int IdInst { get; set; }

    public string NomInst { get; set; } = null!;

    public string DescCarr { get; set; } = null!;

    public int IdPlan { get; set; }
}