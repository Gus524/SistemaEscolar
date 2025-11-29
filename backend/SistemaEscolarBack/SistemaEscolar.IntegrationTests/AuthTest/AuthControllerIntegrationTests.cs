using System.Net;
using System.Net.Http.Json;
using Application.DTOs.Auth;
using Application.Wrapper;
using Common.Data;
using Domain.Enums;
using FluentAssertions;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;

namespace SistemaEscolar.IntegrationTests.AuthTest;

public class AuthControllerIntegrationTests(
    IntegrationTestWebAppFactory factory
) : IClassFixture<IntegrationTestWebAppFactory>, IAsyncLifetime
{
    private readonly HttpClient _client = factory.CreateClient();

    public async Task InitializeAsync()
    {
        using var scope = factory.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        
        await dbContext.Database.EnsureDeletedAsync();
        await dbContext.Database.EnsureCreatedAsync();
    }

    public Task DisposeAsync() => Task.CompletedTask;
    
    [Fact]
    public async Task Login_WithValidCredential_ReturnsOkAndToken()
    {
        var testPassword = "Password123!";
        var testUser = new ApplicationUser
        {
            UserName = "testuser",
            UserType = UserType.Gestion
        };

        var command = new
        {
            UserName = testUser.UserName,
            Password = testPassword
        };
        
        using (var scope = factory.Services.CreateScope())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var result = await userManager.CreateAsync(testUser, testPassword);
            
            if (!result.Succeeded) 
                throw new Exception($"Fallo al seedear: {string.Join(", ", result.Errors.Select(e => e.Description))}");
        }
        
        var response = await _client.PostAsJsonAsync("/api/v1/Auth/auth", command);

        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var resultData = await response.Content.ReadFromJsonAsync<Response<LoginResponseDto>>();
        
        resultData.Should().NotBeNull();
        resultData.Succeeded.Should().BeTrue();
        resultData.Data.Token.Should().NotBeNullOrEmpty();
        resultData.Data.UserName.Should().Be(testUser.UserName);
        resultData.Data.Role.Should().Be(UserType.Gestion);

        var handler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
        var jsonToken = handler.ReadJwtToken(resultData.Data.Token);
        
        jsonToken.ValidTo.Should().BeAfter(DateTime.UtcNow);

        var roleClaim =
            jsonToken.Claims.FirstOrDefault(c => c.Type == "UserType" || c.Type == System.Security.Claims.ClaimTypes.Role);
        
        roleClaim.Should().NotBeNull("El token debe contener el rol");
        roleClaim.Value.Should().Be(nameof(UserType.Gestion));
    }
    
    [Fact]
    public async Task Login_WithNonExistingUser_ReturnsUnauthorized()
    {
        var command = new
        {
            UserName = "usuario_que_no_existe",
            Password = "Password123!"
        };

        var response = await _client.PostAsJsonAsync("/api/v1/Auth/auth", command);
        
        if (response.StatusCode == HttpStatusCode.InternalServerError)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            throw new Xunit.Sdk.XunitException($"API devolvió 500. Detalles: {errorContent}");
        }

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);

        var resultData = await response.Content.ReadFromJsonAsync<Response<LoginResponseDto>>();

        resultData.Should().NotBeNull();
        resultData.Succeeded.Should().BeFalse();
        resultData.Message.Should().Be("Credenciales inválidas.");
    }
    
    [Fact]
    public async Task Login_WithInvalidPassword_ReturnsUnauthorized()
    {
        var testUser = new ApplicationUser
        {
            UserName = "userwrongpass",
            UserType = UserType.Gestion
        };

        const string correctPassword = "Password123!";
        const string wrongPassword = "Incorrect@1";

        using (var scope = factory.Services.CreateScope())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            await dbContext.Database.EnsureCreatedAsync();

            var createResult = await userManager.CreateAsync(testUser, correctPassword);
            if (!createResult.Succeeded)
                throw new Exception("Error al crear el usuario de prueba.");
        }

        var command = new
        {
            UserName = testUser.UserName,
            Password = wrongPassword
        };

        var response = await _client.PostAsJsonAsync("/api/v1/Auth/auth", command);

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);

        var resultData = await response.Content.ReadFromJsonAsync<Response<LoginResponseDto>>();
        resultData.Should().NotBeNull();
        resultData.Succeeded.Should().BeFalse();
        resultData.Message.Should().Be("Credenciales inválidas.");
    }

    [Fact]
    public async Task Login_WithEmptyParams_ReturnsBadRequest()
    {
        string? userNull = null;
        string? passwordNull = null;
        var command = new
        {
            UserName = userNull,
            Password = passwordNull
        };
        
        var response = await _client.PostAsJsonAsync("/api/v1/Auth/auth", command);
        
        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        
        var resultData = await response.Content.ReadFromJsonAsync<Response<LoginResponseDto>>();
        resultData.Should().NotBeNull();
        resultData.Succeeded.Should().BeFalse();
        resultData.Message.Should().Be("Se han producido uno o más errores de validación");
        var errors = resultData.Errors.ToList();
        errors.Should().Contain("El usuario es requerido.").And.Contain("La contraseña es requerida.");
    }

    [Fact]
    public async Task Login_WithValidAlumnoCredentials_ReturnsOkAndToken()
    {
        var testPassword = "Password123!";
        var testUser = new ApplicationUser
        {
            UserName = "alumno_test",
            UserType = UserType.Alumno
        };

        var command = new
        {
            UserName = testUser.UserName,
            Password = testPassword
        };
        
        using (var scope = factory.Services.CreateScope())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var result = await userManager.CreateAsync(testUser, testPassword);
            
            if (!result.Succeeded) 
                throw new Exception($"Fallo al seedear: {string.Join(", ", result.Errors.Select(e => e.Description))}");
        }
        
        var response = await _client.PostAsJsonAsync("/api/v1/Auth/auth", command);

        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var resultData = await response.Content.ReadFromJsonAsync<Response<LoginResponseDto>>();
        
        resultData.Should().NotBeNull();
        resultData.Succeeded.Should().BeTrue();
        resultData.Data.Token.Should().NotBeNullOrEmpty();
        resultData.Data.UserName.Should().Be(testUser.UserName);
        resultData.Data.Role.Should().Be(UserType.Alumno);

        var handler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
        var jsonToken = handler.ReadJwtToken(resultData.Data.Token);
        
        jsonToken.ValidTo.Should().BeAfter(DateTime.UtcNow);

        var roleClaim =
            jsonToken.Claims.FirstOrDefault(c => c.Type == "UserType" || c.Type == System.Security.Claims.ClaimTypes.Role);
        
        roleClaim.Should().NotBeNull("El token debe contener el rol");
        roleClaim.Value.Should().Be(nameof(UserType.Alumno));
    }
    
    [Fact]
    public async Task Login_WithValidDocenteCredentials_ReturnsOkAndToken()
    {
        var testPassword = "Password123!";
        var testUser = new ApplicationUser
        {
            UserName = "docente_test",
            UserType = UserType.Docente
        };

        var command = new
        {
            UserName = testUser.UserName,
            Password = testPassword
        };
        
        using (var scope = factory.Services.CreateScope())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var result = await userManager.CreateAsync(testUser, testPassword);
            
            if (!result.Succeeded) 
                throw new Exception($"Fallo al seedear: {string.Join(", ", result.Errors.Select(e => e.Description))}");
        }
        
        var response = await _client.PostAsJsonAsync("/api/v1/Auth/auth", command);

        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var resultData = await response.Content.ReadFromJsonAsync<Response<LoginResponseDto>>();
        
        resultData.Should().NotBeNull();
        resultData.Succeeded.Should().BeTrue();
        resultData.Data.Token.Should().NotBeNullOrEmpty();
        resultData.Data.UserName.Should().Be(testUser.UserName);
        resultData.Data.Role.Should().Be(UserType.Docente);

        var handler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
        var jsonToken = handler.ReadJwtToken(resultData.Data.Token);
        
        jsonToken.ValidTo.Should().BeAfter(DateTime.UtcNow);

        var roleClaim =
            jsonToken.Claims.FirstOrDefault(c => c.Type == "UserType" || c.Type == System.Security.Claims.ClaimTypes.Role);
        
        roleClaim.Should().NotBeNull("El token debe contener el rol");
        roleClaim.Value.Should().Be(nameof(UserType.Docente));
    }
}