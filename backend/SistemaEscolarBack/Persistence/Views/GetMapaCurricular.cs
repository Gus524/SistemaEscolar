namespace Persistence.Views;

public class GetMapaCurricular
{
    public string? Clave { get; set; }

    public string NomMateria { get; set; } = null!;

    public string TipoMateria { get; set; } = null!;

    public int Creditos { get; set; }

    public int HorasTeoria { get; set; }

    public int HorasPrac { get; set; }

    public string AbrCarr { get; set; } = null!;

    public int IdPlan { get; set; }

    public int Semestre { get; set; }
}