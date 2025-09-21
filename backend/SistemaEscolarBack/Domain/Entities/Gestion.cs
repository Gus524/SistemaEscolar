namespace Domain.Entities;

public class Gestion
{
    public string? Usuario { get; set; }

    public int? IdInst { get; set; }

    public virtual Institucion? IdInstNavigation { get; set; }
}