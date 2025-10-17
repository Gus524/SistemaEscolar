namespace Application.DTOs.PeriodoActual;

public class AlumnosGrupoDto
{
    public string Rfc { get; set; } = null!;

    public long NoBoleta { get; set; }

    public string EmailPersonal { get; set; } = null!;

    public string? EmailInstitucional { get; set; }

    public string? Grupo { get; set; }

    public string? Clave { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string ApellidoMaterno { get; set; } = null!;

    public int? PrimerParcial { get; set; }

    public int? SegundoParcial { get; set; }

    public int? TercerParcial { get; set; }

    public int? Extra { get; set; }

    public int? Final { get; set; }
}