namespace Persistence.Views;

public class GetInicioDocente
{
    public string? Nombre { get; set; }

    public string NomAcademia { get; set; } = null!;

    public string NomInst { get; set; } = null!;

    public string Rfc { get; set; } = null!;

    public int IdInst { get; set; }
}