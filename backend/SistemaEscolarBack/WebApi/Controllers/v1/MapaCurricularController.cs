using Application.Features.MapaCurricular.Queries.GetCarreras;
using Application.Features.MapaCurricular.Queries.GetMapaCurricular;
using Application.Features.MapaCurricular.Queries.GetPlanesEstudio;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class MapaCurricularController(IMediator mediator) : BaseApiController
{
    [HttpGet("mapaCurricular")]
    public async Task<IActionResult> GetMapaCurricular(string carrera, int plan)
    {
        return Ok(await mediator.Send(new GetMapaCurricularQuery {  Carrera = carrera,  Plan = plan }));
    }

    [HttpGet("carreras/{institucion}")]
    public async Task<IActionResult> GetCarreras(int institucion)
    {
        return Ok(await mediator.Send(new GetCarrerasQuery { Institucion = institucion }));
    }
    
    [HttpGet("planes/{carrera}")]
    public async Task<IActionResult> GetPlanes(string carrera)
    {
        return Ok(await mediator.Send(new GetPlanesEstudioQuery { Carrera = carrera }));
    }
}