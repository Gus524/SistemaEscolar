using Application.DTOs.Auth;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Auth.Commands;

public class LoginUserCommand : IRequest<Response<LoginResponseDto>>
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}