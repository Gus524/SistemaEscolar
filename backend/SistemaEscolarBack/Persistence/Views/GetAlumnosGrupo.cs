namespace Persistence.Views;

public class GetAlumnosGrupo
{
    public string Rfc { get; set; } = null!;

    public long NoBoleta { get; set; }

    public string EmailPAlumno { get; set; } = null!;

    public string? EmailIAlumno { get; set; }

    public string? Grupo { get; set; }

    public string? Clave { get; set; }

    public string Nombre { get; set; } = null!;

    public string Ap { get; set; } = null!;

    public string Am { get; set; } = null!;

    public int? CalParcial1 { get; set; }

    public int? CalParcial2 { get; set; }

    public int? CalParcial3 { get; set; }

    public int? CalExtra { get; set; }

    public int? CalFinal { get; set; }
}