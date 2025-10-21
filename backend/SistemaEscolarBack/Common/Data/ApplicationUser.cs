using Domain.Entities;
using Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace Common.Data;

public class ApplicationUser : IdentityUser
{
    public UserType UserType { get; set; }
    public long? AlumnoNoBoleta { get; set; }
    public virtual Alumno Alumno { get; set; }
    public string? DocenteRfc { get; set; } = null;
    public virtual Docente Docente { get; set; }
    public string? GestionUsuario { get; set; } = null;
    public virtual Gestion Gestion { get; set; }
}