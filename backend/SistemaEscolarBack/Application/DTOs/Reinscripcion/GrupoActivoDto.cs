namespace Application.DTOs.Reinscripcion;

public class GrupoActivoDto
{
    public int IdPeriodo { get; init; }
    public string AbrCarr { get; init; } = string.Empty;
    public int Semestre { get; init; }
    public int IdPlan { get; init; }
    public string NoMateria { get; init; } = string.Empty;
    public string Turno { get; init; } = null!;
    public int NoGrupo { get; init; }
    public int Creditos { get; init; }
    public int Disponibles { get; init; }
}