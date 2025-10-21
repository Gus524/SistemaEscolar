using Domain.Enums;

namespace Application.DTOs.Auth;

public class LoginResponseDto
{
    public string Token { get; set; }
    public string UserId { get; set; }
    public string UserName { get; set; }
    public UserType Role { get; set; }
}