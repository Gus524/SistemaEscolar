using Application.Features.HistorialAcademico.Queries.GetEstadoGeneralAlumno;
using Application.Features.HistorialAcademico.Queries.GetHistorialAlumno;
using Application.Features.HistorialAcademico.Queries.GetHistorialDetalle;
using Application.Features.HistorialAcademico.Queries.GetHistorialDetalleAlumnoCurrent;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class HistorialAcademicoController(IMediator mediator) : BaseApiController
{
    [HttpGet("alumno")]
    [Authorize(Roles = "Gestion")]
    public async Task<IActionResult> GetHistorialAlumno(long noBoleta)
    {
        return Ok(await mediator.Send(new GetHistorialAlumnoQuery { NoBoleta = noBoleta }));
    }

    [HttpGet("detalle")]
    [Authorize(Roles = "Gestion")]
    public async Task<IActionResult> GetHistorialDetalle(long noBoleta)
    {
        return Ok(await mediator.Send(new GetHistorialDetalleQuery { NoBoleta = noBoleta }));
    }

    [HttpGet("estadoGeneral")]
    [Authorize(Roles = "Gestion,Alumno")]
    public async Task<IActionResult> GetEstadoGeneralAlumno(long noBoleta, int idPlan)
    {
        return Ok(await mediator.Send(new GetEstadoGeneralAlumnoQuery { NoBoleta = noBoleta, IdPlan = idPlan }));
    }

    [HttpGet("historialAlumno")]
    [Authorize(Roles = "Alumno")]
    public async Task<IActionResult> GetHistorialAlumnoActual()
    {
        return Ok(await mediator.Send(new GetHistorialDetalleAlumnoCurrentQuery()));
    }
}