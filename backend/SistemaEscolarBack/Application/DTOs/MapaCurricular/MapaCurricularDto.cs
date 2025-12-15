namespace Application.DTOs.MapaCurricular;

public class MapaCurricularDto
{
    public int Semestre { get; set; }
    public string? Clave { get; set; }
    public string NombreMateria { get; set; } = null!;
    public string TipoMateria { get; set; } = null!;
    public int Creditos { get; set; }
    public int HorasTeoria { get; set; }
    public int HorasPractica { get; set; }
}