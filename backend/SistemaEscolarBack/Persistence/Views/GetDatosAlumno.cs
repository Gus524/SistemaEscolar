namespace Persistence.Views;

public class GetDatosAlumno
{
    public long NoBoleta { get; set; }

    public string? Nombre { get; set; }

    public string EmailPAlumno { get; set; } = null!;

    public string? EmailIAlumno { get; set; }

    public string? Curp { get; set; }

    public string? TelfAlumno { get; set; }

    public string? TelmAlumno { get; set; }

    public string Calle { get; set; } = null!;

    public string NoExt { get; set; } = null!;

    public string NoInt { get; set; } = null!;

    public string Colonia { get; set; } = null!;

    public string Delegacion { get; set; } = null!;

    public string Cp { get; set; }

    public string DescCarr { get; set; } = null!;

    public string DescPlan { get; set; } = null!;

    public float? Promedio { get; set; }

    public string Institucion { get; set; } = null!;
}