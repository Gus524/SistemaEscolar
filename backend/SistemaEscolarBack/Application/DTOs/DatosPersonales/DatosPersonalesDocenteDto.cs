
namespace Application.DTOs.DatosPersonales;

public class DatosPersonalesDocenteDto
{
    public string Rfc { get; set; } = null!;
    public string? Nombre { get; set; }
    public string? EmailPDoc { get; set; }
    public string? EmailIDoc { get; set; }
    public string? TelDoc { get; set; }
    public string Calle { get; set; } = null!;
    public string NoExt { get; set; } = null!;
    public string NoInt { get; set; } = null!;
    public string Colonia { get; set; } = null!;
    public string Delegacion { get; set; } = null!;
    public decimal Cp { get; set; }
    public string NomAcademia { get; set; } = null!;
    public string DescEdificio { get; set; } = null!;
}
