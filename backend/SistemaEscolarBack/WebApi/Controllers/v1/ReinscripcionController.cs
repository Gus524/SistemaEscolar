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
}