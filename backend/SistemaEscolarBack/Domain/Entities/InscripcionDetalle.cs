using System.ComponentModel.DataAnnotations.Schema;
using Domain.ValueObjects;

namespace Domain.Entities;

public class InscripcionDetalle
{
    public int? CalParcial1 { get; set; }

    public int? CalParcial2 { get; set; }

    public int? CalParcial3 { get; set; }

    public int? CalExtra { get; set; }

    public int? CalFinal { get; set; }

    public long NoBoleta { get; set; }

    public int Semestre { get; set; }

    public string AbrCarr { get; set; } = null!;

    public string Turno { get; set; } = null!;

    public int NoGrupo { get; set; }

    public int IdPeriodo { get; set; }

    public string NoMateria { get; set; } = null!;

    public int IdPlan { get; set; }

    public virtual GrupoHorario GrupoHorario { get; set; } = null!;

    public virtual Inscripcion Inscripcion { get; set; } = null!;

    [NotMapped] 
    public HorarioTemporal? HorarioTemporal { get; private set; }
    private InscripcionDetalle() {}

    internal InscripcionDetalle(long boleta, int semestre, string turno, string carrera, int grupo, int periodo,
        string noMateria, int plan)
    {
        NoBoleta = boleta;
        Semestre = semestre;
        AbrCarr = carrera;
        Turno = turno;
        NoGrupo = grupo;
        IdPeriodo = periodo;
        NoMateria = noMateria;
        IdPlan = plan;
    }
    
    internal string FormatearGrupo()
    {
        return Semestre + AbrCarr + Turno + NoGrupo;
    }

    internal void CargarHorario(HorarioTemporal horario)
    {
        HorarioTemporal = horario;
    }
}