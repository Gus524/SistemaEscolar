namespace Persistence.Views;

public class GetAlumnoCalificaciones
{
    public long NoBoleta { get; set; }

    public int IdPlan { get; set; }

    public int IdPeriodo { get; set; }

    public string? Grupo { get; set; }

    public string NomMateria { get; set; } = null!;

    public string? Clave { get; set; }

    public int? CalParcial1 { get; set; }

    public int? CalParcial2 { get; set; }

    public int? CalParcial3 { get; set; }

    public int? CalExtra { get; set; }

    public int? CalFinal { get; set; }
}