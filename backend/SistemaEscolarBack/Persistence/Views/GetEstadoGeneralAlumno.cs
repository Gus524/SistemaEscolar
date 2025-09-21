namespace Persistence.Views;

public class GetEstadoGeneralAlumno
{
    public long? NoBoleta { get; set; }

    public int IdPlan { get; set; }

    public string? Estado { get; set; }

    public string NomMateria { get; set; } = null!;

    public string NomAcademia { get; set; } = null!;
}