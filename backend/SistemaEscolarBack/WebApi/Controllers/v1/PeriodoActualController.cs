using Application.Features.PeriodoActual.Queries.GetAlumnoCalificaciones;
using Application.Features.PeriodoActual.Queries.GetAlumnosGrupo;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class PeriodoActualController(IMediator mediator) : BaseApiController
{
    [HttpGet("calificaciones")]
    public async Task<IActionResult> GetAlumnoCalificaciones([FromQuery] GetAlumnoCalificacionesQuery query)
    {
        return Ok(await mediator.Send(query));
    }

    [HttpGet("alumnos-grupo")]
    public async Task<IActionResult> GetAlumnosGrupo([FromQuery] GetAlumnosGrupoQuery query)
    {
        return Ok(await mediator.Send(query));
    }
}