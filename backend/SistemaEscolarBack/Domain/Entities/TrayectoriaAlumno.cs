namespace Domain.Entities;

public class TrayectoriaAlumno
{
    public int? PerCursados { get; set; }

    public int? PerDisponibles { get; set; }

    public float? CredPermitidos { get; set; }

    public float? CredFaltantes { get; set; }

    public float? CredObtenidos { get; set; }

    public long? NoBoleta { get; set; }

    public int? IdPlan { get; set; }

    public virtual HistorialAcademico? HistorialAcademico { get; set; }
}