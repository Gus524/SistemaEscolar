using Application.DTOs.Reinscripcion;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Reinscripcion.Commands.ValidarNuevaMateria;

public class ValidarNuevaMateriaCommand(
    List<IdentificadorGrupoHorario> horarioActual,
    IdentificadorGrupoHorario nuevaMateria
) : IRequest<Response<List<IdentificadorGrupoHorario>>>
{
    public List<IdentificadorGrupoHorario> HorarioActual { get; } = horarioActual;
    public IdentificadorGrupoHorario NuevaMateria { get; } = nuevaMateria;
}