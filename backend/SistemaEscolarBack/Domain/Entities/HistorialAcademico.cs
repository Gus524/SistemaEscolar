using System.Collections.Generic;
using Domain.Enums;

namespace Domain.Entities;

public class HistorialAcademico
{
    public long NoBoleta { get; set; }

    public int IdPlan { get; set; }

    public float? Promedio { get; set; }

    public int? UltimoSemestre { get; set; }
    public EstadoHistorial EstadoHistorial { get; set; } = EstadoHistorial.Activo;

    public virtual ICollection<HistorialDetalle> HistorialDetalle { get; set; } = new List<HistorialDetalle>();

    public virtual PlanEstudios IdPlanNavigation { get; set; } = null!;

    public virtual ICollection<Inscripcion> Inscripcion { get; set; } = new List<Inscripcion>();

    public virtual Alumno NoBoletaNavigation { get; set; } = null!;
    public virtual TrayectoriaAlumno TrayectoriaAlumno { get; set; } = null!;
    public virtual ICollection<EstadoGeneral> EstadoGeneral { get; set; } = new List<EstadoGeneral>();
    private HistorialAcademico(){ }
    
}