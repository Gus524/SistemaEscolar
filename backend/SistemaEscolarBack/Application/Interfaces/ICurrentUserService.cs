using Domain.Enums;

namespace Application.Interfaces;

public interface ICurrentUserService
{
    string? UserId { get; }
    string? UserName { get; }
    UserType? GetCurrentUserType();
    bool IsInRole(string role);
}