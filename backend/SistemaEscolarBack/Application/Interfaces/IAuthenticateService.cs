using Application.DTOs.Auth;

namespace Application.Interfaces;

public interface IAuthenticateService
{
    string GenerateToken(UserTokenDto userInfo);
    Task<string?> ValidateCredentialsAsync(string username, string password);
    Task<UserTokenDto?> GetUserForTokenAsync(string userId);
}