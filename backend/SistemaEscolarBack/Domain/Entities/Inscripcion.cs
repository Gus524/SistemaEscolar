using System.Collections.Generic;
using Domain.ValueObjects;

namespace Domain.Entities;

public class Inscripcion
{
    public long NoBoleta { get; set; }

    public int IdPeriodo { get; set; }

    public int IdPlan { get; set; }

    public DateOnly FechaInscripcion { get; set; }

    public virtual HistorialAcademico HistorialAcademico { get; set; } = null!;

    public virtual PeriodoEscolar IdPeriodoNavigation { get; set; } = null!;
    private List<InscripcionDetalle> _inscripcionDetalle = [];

    public virtual IReadOnlyCollection<InscripcionDetalle> InscripcionDetalle => _inscripcionDetalle;

    public void AgregarMateria(InscripcionDetalle nuevoDetalle, HorarioTemporal nuevoHorario, IEnumerable<HorarioTemporal> horarioActual)
    {
        if (_inscripcionDetalle.Any(d =>
                d.IdPlan == nuevoDetalle.IdPlan && d.Semestre == nuevoDetalle.Semestre &&
                d.NoMateria == nuevoDetalle.NoMateria))
            throw new InvalidOperationException("No se puede agregar la misma materia más de una vez.");
        
        foreach (var horario in horarioActual)
        {
            if (nuevoHorario.ComprobarEmpalme(horario))
                throw new InvalidOperationException("Conflicto de horario al agregar la materia.");
        }
        _inscripcionDetalle.Add(nuevoDetalle);
    }

    internal void AddDetalle(InscripcionDetalle nuevoDetalle)
    {
        _inscripcionDetalle.Add(nuevoDetalle);
    }
}