namespace Application.DTOs.Horario;

public class HorarioGeneralDto
{
    public string Secuencia { get; set; } = null!;
    public string Clave { get; set; } = null!;
    public string? NombreProfesor { get; set; }
    public string Materia { get; set; } = null!;
    public int Semestre { get; set; }
    public string Turno { get; set; } = null!;
    public int NoGrupo { get; set; }
    public string? Lunes { get; set; }
    public string? Martes { get; set; }
    public string? Miercoles { get; set; }
    public string? Jueves { get; set; }
    public string? Viernes { get; set; }
    public string NoMateria { get; set; } = null!;
}
