using Application.DTOs.Reinscripcion;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Reinscripcion.Commands.ValidarReinscripcion;

public class ValidarReinscripcionCommand(
    List<IdentificadorGrupoHorario> horario
) : IRequest<Response<bool>>
{
    public List<IdentificadorGrupoHorario> Horario { get; } = horario;
}