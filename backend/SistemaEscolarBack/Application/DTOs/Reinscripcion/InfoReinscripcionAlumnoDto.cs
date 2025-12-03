namespace Application.DTOs.Reinscripcion;

public class InfoReinscripcionAlumnoDto
{
    public TrayectoriaAlumnoDto TrayectoriaAlumno { get; set; } = null!;
    public IReadOnlyList<MateriasDisponiblesDto> MateriasDisponibles { get; set; } = null!;
}