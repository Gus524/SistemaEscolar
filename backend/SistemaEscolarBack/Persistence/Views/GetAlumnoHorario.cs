namespace Persistence.Views;

public class GetAlumnoHorario
{
    public long NoBoleta { get; set; }

    public int IdPeriodo { get; set; }

    public string? Grupo { get; set; }

    public string NomMateria { get; set; } = null!;

    public string Rfc { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Clave { get; set; }

    public string? Lunes { get; set; }

    public string? Martes { get; set; }

    public string? Miercoles { get; set; }

    public string? Jue { get; set; }

    public string? Viernes { get; set; }
}