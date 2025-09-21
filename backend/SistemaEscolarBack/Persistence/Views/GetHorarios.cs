namespace Persistence.Views;

public class GetHorarios
{
    public string? Nombre { get; set; }

    public string Materia { get; set; } = null!;

    public int Semestre { get; set; }

    public string AbrCarr { get; set; } = null!;

    public string Turno { get; set; } = null!;

    public int NoGrupo { get; set; }

    public int IdPlan { get; set; }

    public int IdPeriodo { get; set; }

    public string? Lunes { get; set; }

    public string? Martes { get; set; }

    public string? Miercoles { get; set; }

    public string? Jue { get; set; }

    public string? Viernes { get; set; }

    public int? Cupo { get; set; }

    public int? Disponibles { get; set; }

    public int? Sobrecupo { get; set; }

    public string NoMateria { get; set; } = null!;

    public bool? Activo { get; set; }
}