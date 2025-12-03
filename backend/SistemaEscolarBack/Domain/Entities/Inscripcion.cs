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
    private Inscripcion() {}
    public void AgregarMateria(InscripcionDetalle nuevoDetalle, HorarioTemporal nuevoHorario)
    {
        if (_inscripcionDetalle.Any(d =>
                d.IdPlan == nuevoDetalle.IdPlan && d.Semestre == nuevoDetalle.Semestre &&
                d.NoMateria == nuevoDetalle.NoMateria))
            throw new InvalidOperationException("No se puede agregar la misma materia más de una vez.");

        foreach (var detalleExistente in _inscripcionDetalle)
        {
            if (detalleExistente.HorarioTemporal == null)
                throw new InvalidOperationException(
                    $"Error de lógica: El horario para {detalleExistente.NoMateria} no fue cargado en el Agregado.");

            if (nuevoHorario.ComprobarEmpalme(detalleExistente.HorarioTemporal))
                throw new InvalidOperationException(
                    $"Conflicto de horario: la materia {detalleExistente.NoMateria} del grupo {detalleExistente.FormatearGrupo()} " +
                    $"se empalma con la materia {nuevoDetalle.NoMateria} del grupo {nuevoDetalle.FormatearGrupo()}");
        }
        nuevoDetalle.CargarHorario(nuevoHorario);
        _inscripcionDetalle.Add(nuevoDetalle);
    }
    public InscripcionDetalle CrearDetalle(long boleta, int semestre, string turno, string carrera, int grupo, int periodo,
        string noMateria, int plan)
    {
        return new InscripcionDetalle(boleta, semestre, turno, carrera, grupo, periodo, noMateria, plan);
    }
}