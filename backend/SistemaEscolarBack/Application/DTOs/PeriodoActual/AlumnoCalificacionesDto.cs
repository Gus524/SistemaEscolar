namespace Application.DTOs.PeriodoActual;

public class AlumnoCalificacionesDto
{
    public long NoBoleta { get; set; }

    public int IdPlan { get; set; }

    public int IdPeriodo { get; set; }

    public string? Grupo { get; set; }

    public string Materia { get; set; } = null!;

    public string? Clave { get; set; }

    public int? PrimerParcial { get; set; }

    public int? SegundoParcial { get; set; }

    public int? TercerParcial { get; set; }

    public int? Extra { get; set; }

    public int? CalificacionFinal { get; set; }
}