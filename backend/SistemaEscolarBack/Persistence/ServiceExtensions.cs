using System.Reflection;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repository;
using Persistence.Seeders;

namespace Persistence;

public static class ServiceExtensions
{
    public static void AddPersistenceInfraestructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(
            configuration.GetConnectionString("DefaultConnection"),
            serverVersion: ServerVersion.AutoDetect(configuration.GetConnectionString("DefaultConnection")),
            b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
        );

        services.AddScoped<IDbSeeder, DbSeeder>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        #region Repositories

        services.AddTransient(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>));
        services.AddTransient(typeof(IReadRepositoryAsync<>), typeof(RepositoryAsync<>));
        services.AddTransient<IDatosPersonalesRepository, DatosPersonalesRepository>();
        services.AddTransient<IHistorialAcademicoRepository, HistorialAcademicoRepository>();
        services.AddTransient<IHorarioRepository, HorarioRepository>();
        services.AddTransient<IPeriodoActualRepository, PeriodoActualRepository>();
        services.AddTransient<IMapaCurricularRepository, MapaCurricularRepository>();
        services.AddTransient<IReinscripcionRepository, ReinscripcionRepository>();

        #endregion
    }
}