namespace Application.DTOs.HistorialAcademico;

public class MateriaDetalleDto
{
    public string? Clave { get; set; }
    public string Materia { get; set; } = null!;
    public DateOnly FechaEval { get; set; }
    public string DescPeriodo { get; set; } = null!;
    public string? FormaEval { get; set; }
    public int Calificacion { get; set; }
    public int Semestre { get; set; }
}
