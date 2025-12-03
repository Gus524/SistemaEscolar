using Application.DTOs.Reinscripcion;

namespace Application.Interfaces;

public interface IGrupoIdentificadorGenerator
{
    string GetGrupoMateria(IdentificadorGrupoHorario grupo);
    List<string> GetGrupos(List<IdentificadorGrupoHorario> grupos);
}