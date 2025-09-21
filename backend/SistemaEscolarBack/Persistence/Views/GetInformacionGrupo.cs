namespace Persistence.Views;

public class GetInformacionGrupo
{
    public int Semestre { get; set; }

    public string Turno { get; set; } = null!;

    public int NoGrupo { get; set; }

    public string AbrCarr { get; set; } = null!;

    public string NoMateria { get; set; } = null!;

    public string NomMateria { get; set; } = null!;

    public int? Disponibles { get; set; }

    public int? Cupo { get; set; }

    public int? Sobrecupo { get; set; }
}