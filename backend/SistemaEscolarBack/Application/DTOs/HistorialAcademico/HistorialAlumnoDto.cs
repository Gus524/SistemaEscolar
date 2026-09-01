namespace Application.DTOs.HistorialAcademico;

public class HistorialAlumnoDto
{
    public long NoBoleta { get; set; }
    public string? Nombre { get; set; }
    public string Carrera { get; set; } = null!;
    public string Plan { get; set; } = null!;
    public int IdPlan { get; set; }
    public float? Promedio { get; set; }
    public int? UltimoSemestre { get; set; }
}
