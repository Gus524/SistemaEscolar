using Application.Features.HistorialAcademico.Queries.GetEstadoGeneralAlumno;
using Application.Features.HistorialAcademico.Queries.GetHistorialAlumno;
using Application.Features.HistorialAcademico.Queries.GetHistorialDetalle;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class HistorialAcademicoController(IMediator mediator) : BaseApiController
{
    [HttpGet("alumno")]
    [Authorize(Roles = "Alumno")]
    public async Task<IActionResult> GetHistorialAlumno(long noBoleta)
    {
        return Ok(await mediator.Send(new GetHistorialAlumnoQuery { NoBoleta = noBoleta }));
    }

    [HttpGet("detalle")]
    public async Task<IActionResult> GetHistorialDetalle(long noBoleta)
    {
        return Ok(await mediator.Send(new GetHistorialDetalleQuery { NoBoleta = noBoleta }));
    }

    [HttpGet("estadoGeneral")]
    public async Task<IActionResult> GetEstadoGeneralAlumno(long noBoleta, int idPlan)
    {
        return Ok(await mediator.Send(new GetEstadoGeneralAlumnoQuery { NoBoleta = noBoleta, IdPlan = idPlan }));
    }
}