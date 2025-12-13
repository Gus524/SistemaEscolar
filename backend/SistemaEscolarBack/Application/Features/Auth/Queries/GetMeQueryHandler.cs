using Application.DTOs.Auth;
using Application.Interfaces;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Auth.Queries;

public class GetMeQueryHandler(
    ICurrentUserService currentUserService,
    IAuthenticateService authenticateService
) : IRequestHandler<GetMeQuery, Response<AuthUserDto>>
{
    public async Task<Response<AuthUserDto>> Handle(GetMeQuery request, CancellationToken cancellationToken)
    {
        var user = currentUserService.UserId;
        if (string.IsNullOrEmpty(user))
            return Response<AuthUserDto>.Fail("Credenciales inválidas.");

        var current = await authenticateService.GetUserForTokenAsync(user);
        
        if (current == null) 
            return Response<AuthUserDto>.NotFound("Credenciales inválidas.");
        
        var response = new AuthUserDto(current.UserName, current.UserType);
        return Response<AuthUserDto>.Success(response);
    }
}