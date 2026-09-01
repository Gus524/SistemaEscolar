using Application.DTOs.Auth;
using Application.Wrapper;
using MediatR;

namespace Application.Features.Auth.Queries;

public class GetMeQuery : IRequest<Response<AuthUserDto>>;