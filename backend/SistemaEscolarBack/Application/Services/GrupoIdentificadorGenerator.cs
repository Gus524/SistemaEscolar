using Application.DTOs.Reinscripcion;
using Application.Interfaces;

namespace Application.Services;

public class GrupoIdentificadorGenerator : IGrupoIdentificadorGenerator
{
    public string GetGrupoMateria(IdentificadorGrupoHorario grupo)
    {
        return grupo.Semestre + grupo.Carrera + grupo.Turno + grupo.NoGrupo + grupo.NoMateria;
    }

    public List<string> GetGrupos(List<IdentificadorGrupoHorario> grupos)
    {
        return grupos.Select(GetGrupoMateria).ToList();
    }
}