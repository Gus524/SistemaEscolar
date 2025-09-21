namespace Domain.Entities;

public class Academia
{
    public int IdAcademia { get; set; }

    public string NomAcademia { get; set; } = null!;

    public int IdEdificio { get; set; }

    public virtual ICollection<Docente> Docente { get; set; } = new List<Docente>();

    public virtual Edificio IdEdificioNavigation { get; set; } = null!;

    public virtual ICollection<Materia> Materia { get; set; } = new List<Materia>();
}