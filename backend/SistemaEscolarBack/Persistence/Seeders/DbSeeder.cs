using Application.Interfaces;
using Common.Data;
using Domain.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence.Contexts;

namespace Persistence.Seeders;

public class DbSeeder (
    ApplicationDbContext context, 
    ILogger<DbSeeder> logger,
    UserManager<ApplicationUser> userManager, 
    RoleManager<IdentityRole> roleManager
) : IDbSeeder
{
    private const string DefaultPass = "Password123!";

    public async Task InitializeAsync()
    {
        try
        {
            if (context.Database.IsMySql())
                await context.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred seeding the DB.");
            throw;
        }
    }

    public async Task SeedUsersAsync()
    {
        await SeedRolesAsync();
        await SeedAlumnoAsync();
        await SeedDocenteAsync();
        await SeedGestionAsync();
    }

    private async Task SeedRolesAsync()
    {
        string[] roleNames = { "Alumno", "Docente", "Gestion" };
        foreach (var role in roleNames)
        {
            var roleExist = await roleManager.RoleExistsAsync(role);
            if (!roleExist)
                await  roleManager.CreateAsync(new IdentityRole(role));
        }
    }

    private async Task SeedAlumnoAsync()
    {
        var alumnos = await context.Alumno.ToListAsync();

        foreach (var alumno in alumnos)
        {
            string userName = alumno.NoBoleta.ToString();
            var existingUser = await userManager.FindByNameAsync(userName);

            if (existingUser == null)
            {
                var newUser = new ApplicationUser
                {
                    UserName = userName,
                    Email = alumno.EmailIAlumno ?? alumno.EmailPAlumno,
                    EmailConfirmed = true,
                    UserType = UserType.Alumno,
                    AlumnoNoBoleta = alumno.NoBoleta
                };
                
                var result = await userManager.CreateAsync(newUser, DefaultPass);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(newUser, "Alumno");
                }
                else
                {
                    logger.LogError($"Error creating user {userName}: {string.Join(", ", result.Errors.Select(e => e.Description))}");
                }
            }
        }
    }

    private async Task SeedDocenteAsync()
    {
        var docentes = await context.Docente.ToListAsync();
        foreach (var docente in docentes)
        {
            string userName = docente.Rfc;
            var existingUser = await userManager.FindByNameAsync(userName);
            if (existingUser == null)
            {
                var newUser = new ApplicationUser
                {
                    UserName = userName,
                    Email = docente.EmailIDoc ?? docente.EmailPDoc, 
                    EmailConfirmed = true,
                    UserType = UserType.Docente,
                    DocenteRfc = docente.Rfc
                };
                var result = await userManager.CreateAsync(newUser, DefaultPass);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(newUser, "Docente");
                }
                else
                {
                    logger.LogError($"Error creating user {userName}: {string.Join(", ", result.Errors.Select(e => e.Description))}");
                }
            }
        }
    }
    private async Task SeedGestionAsync()
    {
        var gestiones = await context.Gestion.Where(g => g.Usuario != null).ToListAsync();
        foreach (var gestion in gestiones)
        {
            string userName = $"G{gestion.Usuario}"; // Usa Usuario como base
            var existingUser = await userManager.FindByNameAsync(userName);
            if (existingUser == null)
            {
                var newUser = new ApplicationUser
                {
                    UserName = userName,
                    UserType = UserType.Gestion,
                    GestionUsuario = gestion.Usuario
                };
                var result = await userManager.CreateAsync(newUser, DefaultPass);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(newUser, "Gestion");
                }
                else
                {
                    logger.LogError($"Error creating user {userName}: {string.Join(", ", result.Errors.Select(e => e.Description))}");
                }
            }
        }
    }
}