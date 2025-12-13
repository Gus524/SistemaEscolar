using Application.Features.Inicio.Queries.GetInicioAlumno;
using Application.Features.Inicio.Queries.GetInicioDocente;
using Application.Features.Inicio.Queries.GetInicioGestion;
using Application.Interfaces;
using Application.Wrapper;
using Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class InicioController(
    IMediator mediator, 
    ICurrentUserService currentUserService
) : BaseApiController
{
    [HttpGet]
    [Authorize]
    public async Task<IActionResult> GetInicio()
    {
        var tipoUsuario = currentUserService.GetCurrentUserType();
        var usuario = currentUserService.UserName;

        if (usuario is null || tipoUsuario is null)
        {
            return HandleResult(Response<string>
                .Fail("El token no contiene la información requerida."));
        }

        return tipoUsuario switch
        {
            UserType.Alumno => HandleResult(await mediator.Send(new GetInicioAlumnoQuery(usuario))),
            UserType.Docente => HandleResult(await mediator.Send(new GetInicioDocenteQuery(usuario))),
            UserType.Gestion => HandleResult(await mediator.Send(new GetInicioGestionQuery(usuario))),
            _ => HandleResult(Response<string>.Fail("Rol de usuario no soportado."))
        };
    }
}