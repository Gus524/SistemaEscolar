namespace Application.DTOs.Horario;

public class AlumnoHorarioDto
{
    public string? Grupo { get; set; }
    public string NomMateria { get; set; } = null!;
    public string? NombreDocente { get; set; }
    public string? Clave { get; set; }
    public string? Lunes { get; set; }
    public string? Martes { get; set; }
    public string? Miercoles { get; set; }
    public string? Jueves { get; set; }
    public string? Viernes { get; set; }
}
