namespace Application.DTOs.Reinscripcion;

public class MateriasDisponiblesDto
{
    public string? Grupo { get; set; }
    public int Total { get; set; }
    public int Inscritos { get; set; }
    public int Disponibles { get; set; }
    public string Materia { get; set; } = null!;
    public string? Clave { get; set; }
    public string? Lunes { get; set; }
    public string? Martes { get; set; }
    public string? Miercoles { get; set; }
    public string? Jueves { get; set; }
    public string? Viernes { get; set; }
    public string? NoMateria { get; set; }
    public int IdPlan { get; set; }
    public int Semestre { get; set; }
    public string Carrera { get; set; } = null!;
    public string Turno { get; set; } = null!;
    public int NoGrupo { get; set; }
}