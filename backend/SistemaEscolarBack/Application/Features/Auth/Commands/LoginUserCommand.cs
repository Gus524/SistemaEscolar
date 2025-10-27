using Application.DTOs.Auth;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Auth.Commands;

public class LoginUserCommand(string userName, string password) : IRequest<Response<LoginResponseDto>>
{
    public string UserName { get; } = userName;
    public string Password { get; } = password;
}