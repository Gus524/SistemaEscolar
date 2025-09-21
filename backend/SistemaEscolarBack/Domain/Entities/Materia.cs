using System.Collections.Generic;

namespace Domain.Entities;

public class Materia
{
    public int IdMateria { get; set; }

    public string TipoMateria { get; set; } = null!;

    public string NomMateria { get; set; } = null!;

    public int HorasTeoria { get; set; }

    public int HorasPrac { get; set; }

    public int IdAcademia { get; set; }

    public virtual Academia IdAcademiaNavigation { get; set; } = null!;

    public virtual ICollection<MapaCurricular> MapaCurricular { get; set; } = new List<MapaCurricular>();
}