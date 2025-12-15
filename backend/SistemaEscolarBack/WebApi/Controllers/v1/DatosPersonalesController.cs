using Application.Features.DatosPersonales.Queries.GetDatosPersonales;
using Application.Features.DatosPersonales.Queries.GetDatosPersonalesAlumnoCurrent;
using Application.Features.DatosPersonales.Queries.GetDatosPersonalesDocente;
using Application.Features.DatosPersonales.Queries.GetDatosPersonalesDocenteCurrent;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class DatosPersonalesController(IMediator mediator) : BaseApiController
{
    [HttpGet("datosAlumno")]
    [Authorize(Roles = "Gestion")]
    public async Task<IActionResult> GetDatosPersonalesAlumno(long noBoleta)
    {
        return Ok(await mediator.Send(new GetDatosPersonalesQuery { NoBoleta = noBoleta }));
    }

    [HttpGet("datosDocente")]
    [Authorize(Roles = "Gestion")]
    public async Task<IActionResult> GetDatosPersonalesDocente(string rfc)
    {
        return Ok(await mediator.Send(new GetDatosPersonalesDocenteQuery { Rfc = rfc }));
    }

    [HttpGet("misDatosAlumno")]
    [Authorize(Roles = "Alumno")]
    public async Task<IActionResult> GetDatosAlumnoCurrent()
    {
        return Ok(await mediator.Send(new GetDatosPersonalesAlumnoCurrentQuery()));
    }
    
    [HttpGet("misDatosDocente")]
    [Authorize(Roles = "Docente")]
    public async Task<IActionResult> GetDatosDocenteCurrent()
    {
        return Ok(await mediator.Send(new GetDatosPersonalesDocenteCurrentQuery()));
    }
}