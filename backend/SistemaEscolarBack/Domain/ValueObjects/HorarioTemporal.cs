using Domain.Entities;

namespace Domain.ValueObjects;

public class HorarioTemporal
{
    public IReadOnlyList<HorarioBloque> Bloques { get; }

    private HorarioTemporal(List<HorarioBloque> bloques)
    {
        Bloques = bloques.OrderBy(b => b.Dia).ThenBy(b => b.HoraInicio).ToList().AsReadOnly();
    }

    public static HorarioTemporal FromGrupoHorarioEntity(GrupoHorario gh)
    {
        var bloques = new List<HorarioBloque>();

        try
        {
            if (gh is { LunI: not null, LunF: not null })
                bloques.Add(new HorarioBloque(DayOfWeek.Monday, gh.LunI.Value, gh.LunF.Value));

            if (gh is { MarI: not null, MarF: not null })
                bloques.Add(new HorarioBloque(DayOfWeek.Tuesday, gh.MarI.Value, gh.MarF.Value));

            if (gh is { MieI: not null, MieF: not null })
                bloques.Add(new HorarioBloque(DayOfWeek.Wednesday, gh.MieI.Value, gh.MieF.Value));

            if (gh is { JueI: not null, JueF: not null })
                bloques.Add(new HorarioBloque(DayOfWeek.Thursday, gh.JueI.Value, gh.JueF.Value));

            if (gh is { VieI: not null, VieF: not null })
                bloques.Add(new HorarioBloque(DayOfWeek.Friday, gh.VieI.Value, gh.VieF.Value));
        }
        catch (ArgumentException ex)
        {
            throw new InvalidOperationException(
                $"Datos inválidos para el horario {gh.Semestre}-{gh.AbrCarr}-{gh.Turno}-{gh.NoGrupo} con materia: {gh.NoMateria}");
        }

        return new HorarioTemporal(bloques);
    }

    public bool ComprobarEmpalme(HorarioTemporal otro)
    {
        foreach (var bloqueActual in Bloques)
        {
            foreach (var nuevoBloque in otro.Bloques)
            {
                if (bloqueActual.ComprobarEmpalme(nuevoBloque))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null || GetType() != obj.GetType()) return false;

        HorarioTemporal otro = (HorarioTemporal)obj;
        
        return Bloques.SequenceEqual(otro.Bloques);
    }

    public override int GetHashCode()
    {
        int hash = 19;
        foreach (var bloque in Bloques)
        {
            hash = hash * 31 + bloque.GetHashCode();
        }

        return hash;
    }
}