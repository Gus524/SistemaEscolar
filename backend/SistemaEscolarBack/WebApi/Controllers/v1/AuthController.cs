using Application.Features.Auth.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class AuthController(IMediator mediator) : BaseApiController
{
    [HttpPost("auth")]
    public async Task<IActionResult> Auth(LoginUserCommand command)
    {
        return Ok(await mediator.Send(command));
    }
}