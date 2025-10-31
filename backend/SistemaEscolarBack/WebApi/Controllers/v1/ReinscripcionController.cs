using Application.Features.Reinscripcion.Commands.ValidarNuevaMateria;
using Application.Features.Reinscripcion.Commands.ValidarReinscripcion;
using Application.Features.Reinscripcion.Queries.GetMateriasReinscripcionCurrent;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class ReinscripcionController(IMediator mediator) : BaseApiController
{
    [HttpGet("materiasDisponibles")]
    [Authorize(Roles = "Alumno")]
    public async Task<IActionResult> GetMateriasDisponibles()
    {
        return Ok(await mediator.Send(new GetMateriasReinscripcionCurrentQuery()));
    }

    [HttpPost("nuevaMateria")]
    [Authorize(Roles = "Alumno")]
    public async Task<IActionResult> NuevaMateria([FromBody] ValidarNuevaMateriaCommand command)
    {
        return Ok(await mediator.Send(command));
    }

    [HttpPost("inscribirHorario")]
    [Authorize(Roles = "Alumno")]
    public async Task<IActionResult> InscribirHorario([FromBody] ValidarReinscripcionCommand command)
    {
        return Ok(await mediator.Send(command));
    }
}