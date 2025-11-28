using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Application.DTOs.Auth;
using Application.Exceptions;
using Application.Interfaces;
using Common.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Identity.Services;

public class AuthenticateService(
    IConfiguration configuration,
    UserManager<ApplicationUser> userManager,
    ILogger<AuthenticateService> logger
) : IAuthenticateService
{
    public string GenerateToken(UserTokenDto userInfo)
    {
        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, userInfo.UserId),
            new(ClaimTypes.Name, userInfo.UserName),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new("UserType", userInfo.UserType.ToString())
        };

        foreach (var role in userInfo.Roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }
        
        var jwtSettings = configuration.GetSection("JwtSettings");
        var key = new SymmetricSecurityKey(
            Encoding.Default.GetBytes(jwtSettings["Key"] 
                                   ?? throw new InvalidOperationException("JWT Key not configured."))
            );
        
        var issuer = jwtSettings["Issuer"]
                     ?? throw new InvalidOperationException("JWT Issuer not configured");
        
        var audience = jwtSettings["Audience"]
                       ?? throw new InvalidOperationException("JWT Audience not configured");
        var expiryInMinutes = int.Parse(jwtSettings["ExpiryInMinutes"] ?? "60");

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(expiryInMinutes),
            signingCredentials: creds
        );
        
        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public async Task<string?> ValidateCredentialsAsync(string username, string password)
    {
        var user = await userManager.FindByNameAsync(username);
        if (user == null)
        {
            logger.LogWarning("Validation failed (user not found): {username}", username);
            return null;
        }
        
        var passwordValid = await userManager.CheckPasswordAsync(user, password);
        if (passwordValid) return user.Id;
        
        logger.LogWarning("Validation failed (password not valid): {username}", username);
        return null;

    }

    public async Task<UserTokenDto?> GetUserForTokenAsync(string userId)
    {
        var user = await userManager.FindByIdAsync(userId);
        if (user == null)
        {
            logger.LogWarning("Could not find user for token generation: {userId}", userId);
            return null;
        }

        var roles = await userManager.GetRolesAsync(user);

        return new UserTokenDto
        {
            UserId = user.Id,
            UserName = user.UserName ?? string.Empty,
            UserType = user.UserType,
            Roles = roles,
        };
    }
}