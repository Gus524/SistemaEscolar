using Application.Features.Horario.Queries.GetAlumnoHorario;
using Application.Features.Horario.Queries.GetDocenteHorario;
using Application.Features.Horario.Queries.GetGrupos;
using Application.Features.Horario.Queries.GetHorarioGeneral;
using Application.Features.Horario.Queries.GetHorarioPorGrupo;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class HorarioController(IMediator mediator) : BaseApiController
{
    [HttpGet("docente")]
    public async Task<IActionResult> GetDocenteHorario(string rfc)
    {
        return Ok(await mediator.Send(new GetDocenteHorarioQuery { Rfc = rfc }));
    }

    [HttpGet("alumno")]
    public async Task<IActionResult> GetAlumnoHorario(long noBoleta)
    {
        return Ok(await mediator.Send(new GetAlumnoHorarioQuery { NoBoleta = noBoleta }));
    }

    [HttpGet("general")]
    public async Task<IActionResult> GetHorarioGeneral([FromQuery] GetHorarioGeneralQuery query)
    {
        return Ok(await mediator.Send(query));
    }

    [HttpGet("grupo/{secuencia}")]
    public async Task<IActionResult> GetHorarioPorGrupo(string secuencia)
    {
        return Ok(await mediator.Send(new GetHorarioPorGrupoQuery { Secuencia = secuencia }));
    }

    [HttpGet("secuencias")]
    public async Task<IActionResult> GetSecuencias(int plan, int semestre, string? turno)
    {
        return Ok(await mediator.Send(new GetGruposQuery { PlanId = plan, Semestre = semestre, Turno = turno }));
    }
    
}