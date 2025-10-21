using Application.Features.PeriodoActual.Queries.GetAlumnoCalificaciones;
using Application.Features.PeriodoActual.Queries.GetAlumnoCalificacionesCurrent;
using Application.Features.PeriodoActual.Queries.GetAlumnosGrupo;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class PeriodoActualController(IMediator mediator) : BaseApiController
{
    [HttpGet("calificaciones")]
    [Authorize(Roles = "Gestion")]
    public async Task<IActionResult> GetAlumnoCalificaciones([FromQuery] GetAlumnoCalificacionesQuery query)
    {
        return Ok(await mediator.Send(query));
    }

    [HttpGet("alumnos-grupo")]
    [Authorize(Roles = "Gestion,Docente")]
    public async Task<IActionResult> GetAlumnosGrupo([FromQuery] GetAlumnosGrupoQuery query)
    {
        return Ok(await mediator.Send(query));
    }

    [HttpGet("misCalificaciones")]
    [Authorize(Roles = "Alumno")]
    public async Task<IActionResult> GetAlumnoCalificacionesActual()
    {
        return Ok(await mediator.Send(new GetAlumnoCalificacionesCurrentQuery()));
    }
}