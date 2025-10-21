namespace Application.DTOs.DatosPersonales;

public class DatosPersonalesDocenteDto
{
    public string Rfc { get; set; } = null!;
    public string? Nombre { get; set; }
    public string? EmailPersonal { get; set; }
    public string? EmailInstitucional { get; set; }
    public string? Telefono { get; set; }
    public string Calle { get; set; } = null!;
    public string NoExt { get; set; } = null!;
    public string NoInt { get; set; } = null!;
    public string Colonia { get; set; } = null!;
    public string Delegacion { get; set; } = null!;
    public decimal Cp { get; set; }
    public string Academia { get; set; } = null!;
    public string Edificio { get; set; } = null!;
}