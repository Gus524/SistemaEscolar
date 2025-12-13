using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Testcontainers.MySql;

namespace SistemaEscolar.IntegrationTests.AuthTest;

public class IntegrationTestWebAppFactory : WebApplicationFactory<Program>, IAsyncLifetime
{
    private readonly MySqlContainer _dbContainer = new MySqlBuilder()
        .WithImage("mysql:8.0")
        .WithDatabase("test_db")
        .WithUsername("root")
        .WithPassword("Pasword123!")
        .Build();

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.UseEnvironment("Testing");
        
        builder.ConfigureAppConfiguration((context, config) =>
        {
            config.AddInMemoryCollection(new Dictionary<string, string?>
            {
                { "JwtSettings:Key", "EstaEsUnaClaveSecretaMuyLargaParaPruebas123!" },
                { "JwtSettings:Issuer", "TestIssuer" },
                { "JwtSettings:Audience", "TestAudience" },
                { "JwtSettings:ExpiryInMinutes", "60" }
            });
        });
        
        builder.ConfigureTestServices(services =>
        {
            var descriptor =
                services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<ApplicationDbContext>));
            
            if (descriptor is not null) services.Remove(descriptor);

            var connectionString = _dbContainer.GetConnectionString();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });
            
        });
    }

    public Task InitializeAsync()
    {
        return _dbContainer.StartAsync();
    }

    public new Task DisposeAsync()
    {
        return _dbContainer.StopAsync();
    }
}