using Application.DTOs.Auth;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Auth.Commands;

public class LoginUserCommandHandler(IAuthenticateService authService) : IRequestHandler<LoginUserCommand, Response<LoginResponseDto>>
{
    public async Task<Response<LoginResponseDto>> Handle(LoginUserCommand request, CancellationToken cancellationToken)
    {
        var userId = await authService.ValidateCredentialsAsync(request.Username, request.Password);
        var userInfo = await authService.GetUserForTokenAsync(userId) ??
                       throw new KeyNotFoundException("No se eocntro información para el usuario.");

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