using System.Security.Claims;
using Application.Interfaces;
using Domain.Enums;

namespace WebApi.Services;

public class CurrentUserService(IHttpContextAccessor httpContextAccessor) : ICurrentUserService
{
    private ClaimsPrincipal? User => httpContextAccessor.HttpContext?.User;
    public string? UserId => User?.FindFirstValue(ClaimTypes.NameIdentifier);
    public string? UserName => User?.FindFirstValue(ClaimTypes.Name);
    public bool IsInRole(string role) => User?.IsInRole(role) ?? false;
    public UserType? GetCurrentUserType()
    {
        var userType = User?.FindFirstValue("UserType");
        if (userType != null && Enum.TryParse<UserType>(userType, out var type))
        {
            return type;
        }
        return null;
    }
}