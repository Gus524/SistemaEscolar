using System.Collections.Generic;

namespace Domain.Entities;

public class Inscripcion
{
    public long NoBoleta { get; set; }

    public int IdPeriodo { get; set; }

    public int IdPlan { get; set; }

    public DateOnly FechaInscripcion { get; set; }

    public virtual HistorialAcademico HistorialAcademico { get; set; } = null!;

    public virtual PeriodoEscolar IdPeriodoNavigation { get; set; } = null!;

    public virtual ICollection<InscripcionDetalle> InscripcionDetalle { get; set; } = new List<InscripcionDetalle>();

    public void AgregarMateria(int semestre, string turno, string carrera, int grupo,
        string noMateria)
    {
        if (InscripcionDetalle.Any(d =>
                d.NoBoleta == NoBoleta && d.IdPeriodo == IdPeriodo && d.IdPlan == IdPlan && d.Semestre == semestre &&
                d.Turno == turno && d.AbrCarr == carrera && d.NoGrupo == grupo && d.NoMateria == noMateria))
            throw new InvalidOperationException("No se puede agregar la misma materia más de una vez.");
        
        // TODO logica de empalme
        
        var nuevoDetalle = new InscripcionDetalle(NoBoleta, semestre, turno, carrera, grupo, IdPeriodo, noMateria, IdPlan);
        InscripcionDetalle.Add(nuevoDetalle);
    }

}