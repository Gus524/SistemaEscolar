using System.Collections.Generic;

namespace Domain.Entities;

public class GrupoHorario
{
    public int Semestre { get; set; }

    public string AbrCarr { get; set; } = null!;

    public string Turno { get; set; } = null!;

    public int NoGrupo { get; set; }

    public int IdPeriodo { get; set; }

    public string NoMateria { get; set; } = null!;

    public int IdPlan { get; set; }

    public int? Cupo { get; set; }

    public int? Disponibles { get; set; }

    public int? Sobrecupo { get; set; }

    public int? Inscritos { get; set; }

    public TimeOnly? LunI { get; set; }

    public TimeOnly? LunF { get; set; }

    public string? LunSal { get; set; }

    public TimeOnly? MarI { get; set; }

    public TimeOnly? MarF { get; set; }

    public string? MarSal { get; set; }

    public TimeOnly? MieI { get; set; }

    public TimeOnly? MieF { get; set; }

    public string? MieSal { get; set; }

    public TimeOnly? JueI { get; set; }

    public TimeOnly? JueF { get; set; }

    public string? JueSal { get; set; }

    public TimeOnly? VieI { get; set; }

    public TimeOnly? VieF { get; set; }

    public string? VieSal { get; set; }

    public virtual Grupo Grupo { get; set; } = null!;

    public virtual ICollection<InscripcionDetalle> InscripcionDetalle { get; set; } = new List<InscripcionDetalle>();

    public virtual MapaCurricular MapaCurricular { get; set; } = null!;
}