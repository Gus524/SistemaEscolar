using Application.Features.Horario.Queries.GetAlumnoHorario;
using Application.Features.Horario.Queries.GetAlumnoHorarioCurrent;
using Application.Features.Horario.Queries.GetDocenteHorario;
using Application.Features.Horario.Queries.GetDocenteHorarioCurrent;
using Application.Features.Horario.Queries.GetGrupos;
using Application.Features.Horario.Queries.GetHorarioGeneral;
using Application.Features.Horario.Queries.GetHorarioPorGrupo;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class HorarioController(IMediator mediator) : BaseApiController
{
    [HttpGet("docente")]
    [Authorize(Roles = "Gestion")]
    public async Task<IActionResult> GetDocenteHorario(string rfc)
    {
        return Ok(await mediator.Send(new GetDocenteHorarioQuery { Rfc = rfc }));
    }

    [HttpGet("alumno")]
    [Authorize(Roles = "Gestion")]
    public async Task<IActionResult> GetAlumnoHorario(long noBoleta)
    {
        return Ok(await mediator.Send(new GetAlumnoHorarioQuery { NoBoleta = noBoleta }));
    }

    [HttpGet("general")]
    [Authorize]
    public async Task<IActionResult> GetHorarioGeneral([FromQuery] GetHorarioGeneralQuery query)
    {
        return Ok(await mediator.Send(query));
    }

    [HttpGet("grupo/{secuencia}")]
    [Authorize]
    public async Task<IActionResult> GetHorarioPorGrupo(string secuencia)
    {
        return Ok(await mediator.Send(new GetHorarioPorGrupoQuery { Secuencia = secuencia }));
    }

    [HttpGet("secuencias")]
    [Authorize]
    public async Task<IActionResult> GetSecuencias(int plan, int semestre, string? turno)
    {
        return Ok(await mediator.Send(new GetGruposQuery { PlanId = plan, Semestre = semestre, Turno = turno }));
    }

    [HttpGet("miHorarioAlumno")]
    [Authorize(Roles = "Alumno")]
    public async Task<IActionResult> GetHorarioAlumnoActual()
    {
        return Ok(await mediator.Send(new GetAlumnoHorarioCurrentQuery()));
    }
    
    [HttpGet("miHorarioDocente")]
    [Authorize(Roles = "Docente")]
    public async Task<IActionResult> GetHorarioDocenteActual()
    {
        return Ok(await mediator.Send(new GetDocenteHorarioCurrentQuery()));
    }
}