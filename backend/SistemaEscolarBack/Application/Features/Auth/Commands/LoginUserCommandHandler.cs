using Application.DTOs.Auth;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Auth.Commands;

internal class LoginUserCommandHandler(IAuthenticateService authService) : IRequestHandler<LoginUserCommand, Response<LoginResponseDto>>
{
    public async Task<Response<LoginResponseDto>> Handle(LoginUserCommand request, CancellationToken cancellationToken)
    {
        var userId = await authService.ValidateCredentialsAsync(request.UserName, request.Password);
        
        if (userId is null)
            return Response<LoginResponseDto>.Unauthorized("Credenciales inválidas.");
        
        var userInfo = await authService.GetUserForTokenAsync(userId);
        
        if (userInfo is null)
            return Response<LoginResponseDto>.Unauthorized("Credenciales inválidas.");

        var token = authService.GenerateToken(userInfo);

        var response = new LoginResponseDto
        {
            Token = token,
            UserId = userInfo.UserId,
            UserName = userInfo.UserName,
            Role = userInfo.UserType
        };
        
        return Response<LoginResponseDto>.Success(response, "Sesión iniciada correctamente.");
    }
}