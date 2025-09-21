using System.Collections.Generic;

namespace Domain.Entities;

public class Carrera
{
    public string AbrCarr { get; set; } = null!;

    public string DescCarr { get; set; } = null!;

    public int NoSem { get; set; }

    public int? MaxSemestres { get; set; }

    public int IdInst { get; set; }

    public int CredTotal { get; set; }

    public virtual ICollection<Grupo> Grupo { get; set; } = new List<Grupo>();

    public virtual Institucion IdInstNavigation { get; set; } = null!;

    public virtual ICollection<MapaCurricular> MapaCurricular { get; set; } = new List<MapaCurricular>();

    public virtual ICollection<PlanEstudios> PlanEstudios { get; set; } = new List<PlanEstudios>();
}