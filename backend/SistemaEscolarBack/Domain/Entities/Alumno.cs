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

    public decimal Cp { get; set; }

    public virtual ICollection<HistorialAcademico> HistorialAcademico { get; set; } = new List<HistorialAcademico>();

    public virtual ICollection<Tramite> Tramite { get; set; } = new List<Tramite>();
}