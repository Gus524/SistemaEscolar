namespace Persistence.Views;

public class GetGruposPlan
{
    public string? Secuencia { get; set; }

    public int Semestre { get; set; }

    public int IdPeriodo { get; set; }

    public int IdPlan { get; set; }

    public string Turno { get; set; } = null!;

    public bool Activo { get; set; }
}