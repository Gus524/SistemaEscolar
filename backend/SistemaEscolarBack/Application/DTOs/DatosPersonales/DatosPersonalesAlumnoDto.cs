namespace Application.DTOs.DatosPersonales;

public class DatosPersonalesAlumnoDto
{
    public long NoBoleta { get; set; }

    public string? Nombre { get; set; }

    public string EmailPersonal { get; set; } = null!;

    public string? EmailInstitucional { get; set; }

    public string? Curp { get; set; }

    public string? Telefono { get; set; }

    public string? TelefonoMovil { get; set; }

    public string Calle { get; set; } = null!;

    public string NoExt { get; set; } = null!;

    public string NoInt { get; set; } = null!;

    public string Colonia { get; set; } = null!;

    public string Delegacion { get; set; } = null!;

    public decimal Cp { get; set; }

    public string DescCarr { get; set; } = null!;

    public string DescPlan { get; set; } = null!;

    public float? Promedio { get; set; }

    public string Institucion { get; set; } = null!;
}