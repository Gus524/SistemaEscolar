namespace Persistence.Views;

public class GetMateriasReinscripcion
{
    public long NoBoleta { get; set; }
    public string Materia { get; set; } = null!;
    public string Grupo { get; set; } = null!;
    public string Clave { get; set; } = null!;
    public string? Lunes { get; set; }
    public string? Martes { get; set; }
    public string? Miercoles { get; set; }
    public string? Jueves { get; set; } 
    public string? Viernes { get; set; }
    public int Cupo { get; set; }
    public int Disponibles { get; set; }
    public int Semestre { get; set; }
    public string Turno { get; set; } = null!;
    public int NoGrupo { get; set; }
    public string NoMateria { get; set; } = null!;
    public string Carrera { get; set; } = null!;
}