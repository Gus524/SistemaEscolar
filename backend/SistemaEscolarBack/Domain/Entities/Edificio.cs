using System.Collections.Generic;

namespace Domain.Entities;

public class Edificio
{
    public int IdEdificio { get; set; }

    public string DescEdificio { get; set; } = null!;

    public string AbrEdificio { get; set; } = null!;

    public int IdInst { get; set; }

    public virtual ICollection<Academia> Academia { get; set; } = new List<Academia>();

    public virtual Institucion IdInstNavigation { get; set; } = null!;
}