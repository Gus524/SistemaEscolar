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
    private readonly List<HistorialDetalle> _historialDetalle = [];

    public virtual IReadOnlyCollection<HistorialDetalle> HistorialDetalle => _historialDetalle;

    public virtual PlanEstudios IdPlanNavigation { get; set; } = null!;
    private readonly List<Inscripcion> _inscripcion = [];

    public virtual IReadOnlyCollection<Inscripcion> Inscripcion => _inscripcion;

    public virtual Alumno NoBoletaNavigation { get; set; } = null!;
    public virtual TrayectoriaAlumno TrayectoriaAlumno { get; set; } = null!;
    private readonly List<EstadoGeneral> _estadoGeneral = [];
    public virtual IReadOnlyCollection<EstadoGeneral> EstadoGeneral => _estadoGeneral;
    private HistorialAcademico(){ }
    
}