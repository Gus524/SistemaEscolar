using System.Collections.Generic;

namespace Domain.Entities;

public class Docente
{
    public string Rfc { get; set; } = null!;

    public int IdAcademia { get; set; }

    public string NomDoc { get; set; } = null!;

    public string ApDoc { get; set; } = null!;

    public string AmDoc { get; set; } = null!;

    public string? EmailPDoc { get; set; }

    public string? EmailIDoc { get; set; }

    public string? TelDoc { get; set; }

    public string Calle { get; set; } = null!;

    public string NoExt { get; set; } = null!;

    public string NoInt { get; set; } = null!;

    public string Colonia { get; set; } = null!;

    public string Delegacion { get; set; } = null!;

    public string Cp { get; set; }

    public virtual ICollection<Ets> Ets { get; set; } = new List<Ets>();

    public virtual Academia IdAcademiaNavigation { get; set; } = null!;
}