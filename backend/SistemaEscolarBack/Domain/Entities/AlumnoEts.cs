namespace Domain.Entities;

public class AlumnoEts
{
    public int? Calificacion { get; set; }

    public long? NoBoleta { get; set; }

    public string? AbrCarr { get; set; }

    public int? IdPlan { get; set; }

    public string? Turno { get; set; }

    public int? Semestre { get; set; }

    public string? NoMateria { get; set; }

    public int? IdPeriodo { get; set; }

    public int? Ronda { get; set; }

    public virtual Ets? Ets { get; set; }

    public virtual Alumno? NoBoletaNavigation { get; set; }
}