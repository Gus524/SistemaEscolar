using Application.Features.Auth.Commands;
using Application.Features.Auth.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class AuthController(IMediator mediator) : BaseApiController
{
    [HttpPost("auth")]
    public async Task<IActionResult> Auth(LoginUserCommand command)
    {
        return HandleResult(await mediator.Send(command));
    }

    [HttpGet("me")]
    [Authorize]
    public async Task<IActionResult> Me()
    {
        return HandleResult(await mediator.Send(new GetMeQuery()));
    }
}