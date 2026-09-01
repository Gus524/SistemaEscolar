using System.Collections.Generic;

namespace Domain.Entities;

public class Alumno
{
    public long NoBoleta { get; set; }
    public string NomAl { get; set; } = null!;
    public string ApAl { get; set; } = null!;
    public string AmAl { get; set; } = null!;
    public string? Curp { get; set; }
    public string EmailPAlumno { get; set; } = null!;
    public string? EmailIAlumno { get; set; }
    public string? TelfAlumno { get; set; }
    public string? TelmAlumno { get; set; }
    public string Calle { get; set; } = null!;
    public string NoExt { get; set; } = null!;
    public string NoInt { get; set; } = null!;
    public string Colonia { get; set; } = null!;
    public string Delegacion { get; set; } = null!;
    public string Cp { get; set; }
    private readonly List<HistorialAcademico> _historialAcademico = [];
    public virtual IReadOnlyCollection<HistorialAcademico> HistorialAcademico => _historialAcademico;
    public virtual ICollection<Tramite> Tramite { get; set; } = new List<Tramite>();

    public void PuedeInscribirMateria(string noMateria, int idPlan, int semestre)
    {
        var historial = _historialAcademico.FirstOrDefault(h => h.NoBoleta == NoBoleta && h.IdPlan == idPlan) ??
                      throw new KeyNotFoundException("No se encontró un historial para el alumno.");

        var materia = historial.EstadoGeneral.FirstOrDefault(d => d.Semestre == semestre && d.NoMateria == noMateria) ??
                      throw new KeyNotFoundException("No existe la materia en el estado general del alumno.");
        
        if (materia.Estado != "NO CURSADA" && materia.Estado != "REPROBADA")
            throw new InvalidOperationException($"El alumno no puede inscribir la materia porque la tiene en un estado {materia.Estado}.");

        if (materia.Semestre > historial.UltimoSemestre + 3 || materia.Semestre < historial.UltimoSemestre - 3)
            throw new InvalidOperationException("El alumno no puede inscribir materias con 3 semestres de diferencia.");
    }

    public void CreditosSuficientes(int creditosPropuestos, int idPlan)
    {
        var historial = _historialAcademico.FirstOrDefault(h => h.NoBoleta == NoBoleta && h.IdPlan == idPlan) ??
                                        throw new KeyNotFoundException("No se encontró un historial para el alumno.");

        if (historial.TrayectoriaAlumno?.CredPermitidos < creditosPropuestos)
            throw new InvalidOperationException("El alumno no tiene crŕeditos suficientes.");
    }
}