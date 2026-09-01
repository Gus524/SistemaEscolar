using Domain.Enums;

namespace Application.DTOs.Auth;

public class LoginResponseDto
{
    public string Token { get; set; }
    public AuthUserDto User { get; set; }
}