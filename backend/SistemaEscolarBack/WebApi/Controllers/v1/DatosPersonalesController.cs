using Application.Features.DatosPersonales.Queries.GetDatosPersonales;
using Application.Features.DatosPersonales.Queries.GetDatosPersonalesDocente;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class DatosPersonalesController(IMediator mediator) : BaseApiController
{
    [HttpGet("datosAlumno")]
    public async Task<IActionResult> GetDatosPersonalesAlumno(long noBoleta)
    {
        return Ok(await mediator.Send(new GetDatosPersonalesQuery { NoBoleta = noBoleta }));
    }

    [HttpGet("datosDocente")]
    public async Task<IActionResult> GetDatosPersonalesDocente(string rfc)
    {
        return Ok(await mediator.Send(new GetDatosPersonalesDocenteQuery { Rfc = rfc }));
    }
}