using System.Collections.Generic;

namespace Domain.Entities;

public class Institucion
{
    public int IdInst { get; set; }

    public string NomInst { get; set; } = null!;

    public string Abreviatura { get; set; } = null!;

    public virtual ICollection<Carrera> Carrera { get; set; } = new List<Carrera>();

    public virtual ICollection<Edificio> Edificio { get; set; } = new List<Edificio>();
}