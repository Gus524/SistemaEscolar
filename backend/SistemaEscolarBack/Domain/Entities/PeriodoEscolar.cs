using System.Collections.Generic;

namespace Domain.Entities;

public class PeriodoEscolar
{
    public int IdPeriodo { get; set; }

    public string DescPeriodo { get; set; } = null!;

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public bool? Activo { get; set; } = false;

    public virtual ICollection<Ets> Ets { get; set; } = new List<Ets>();

    public virtual ICollection<Grupo> Grupo { get; set; } = new List<Grupo>();

    public virtual ICollection<HistorialDetalle> HistorialDetalle { get; set; } = new List<HistorialDetalle>();

    public virtual ICollection<Inscripcion> Inscripcion { get; set; } = new List<Inscripcion>();
}