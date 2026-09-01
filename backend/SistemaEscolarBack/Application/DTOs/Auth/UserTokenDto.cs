using Domain.Enums;

namespace Application.DTOs.Auth;

public class UserTokenDto
{
    public string UserId { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public UserType UserType { get; set; } 
    public IList<string> Roles { get; set; } = [];
}