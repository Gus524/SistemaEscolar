namespace Application.DTOs.HistorialAcademico;

public class HistorialAlumnoResponseDto
{
    public HistorialAlumnoDto HistorialAlumno { get; set; } = null!;
    public List<SemestreHistorialDto> SemestreHistorial { get; set; } = null!;
}