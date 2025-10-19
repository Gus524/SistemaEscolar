namespace Application.DTOs.HistorialAcademico;

public class SemestreHistorialDto
{
    public int Semestre { get; set; }
    public List<MateriaDetalleDto> Materias { get; set; } = new();
}
