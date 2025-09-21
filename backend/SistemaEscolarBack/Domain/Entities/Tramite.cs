namespace Domain.Entities;

public class Tramite
{
    public int IdTramite { get; set; }

    public string? TipoTramite { get; set; }

    public string? Estado { get; set; }

    public long? NoBoleta { get; set; }

    public virtual Alumno? NoBoletaNavigation { get; set; }
}