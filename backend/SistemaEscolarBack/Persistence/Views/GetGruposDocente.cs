namespace Persistence.Views;

public class GetGruposDocente
{
    public string NomMateria { get; set; } = null!;

    public int IdPeriodo { get; set; }

    public string? Clave { get; set; }

    public string? Grupo { get; set; }

    public string Rfc { get; set; } = null!;
}