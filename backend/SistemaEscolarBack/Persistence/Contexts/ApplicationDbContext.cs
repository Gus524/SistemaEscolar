using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Views;

namespace Persistence.Contexts;

public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;    
    }
    
    public DbSet<Academia> Academia { get; set; }

    public DbSet<Alumno> Alumno { get; set; }

    public DbSet<AlumnoEts> AlumnoEts { get; set; }

    public DbSet<Carrera> Carrera { get; set; }

    public DbSet<Docente> Docente { get; set; }

    public DbSet<DocenteHorario> DocenteHorario { get; set; }

    public DbSet<Edificio> Edificio { get; set; }

    public DbSet<EstadoGeneral> EstadoGeneral { get; set; }

    public DbSet<Ets> Ets { get; set; }

    public DbSet<Gestion> Gestion { get; set; }

    public DbSet<GetAlumnoCalificaciones> GetAlumnoCalificaciones { get; set; }

    public DbSet<GetAlumnoHorario> GetAlumnoHorario { get; set; }

    public DbSet<GetAlumnosGrupo> GetAlumnosGrupo { get; set; }

    public DbSet<GetCarrerasInst> GetCarrerasInst { get; set; }

    public DbSet<GetDatosAlumno> GetDatosAlumno { get; set; }

    public DbSet<GetDatosDocente> GetDatosDocente { get; set; }

    public DbSet<GetDocenteHorario> GetDocenteHorario { get; set; }

    public DbSet<GetEstadoGeneralAlumno> GetEstadoGeneralAlumno { get; set; }

    public DbSet<GetForMapa> GetForMapa { get; set; }

    public DbSet<GetGruposDocente> GetGruposDocente { get; set; }

    public DbSet<GetGruposPlan> GetGruposPlan { get; set; }

    public DbSet<GetHistorialAlumno> GetHistorialAlumno { get; set; }

    public DbSet<GetHistorialDetalle> GetHistorialDetalle { get; set; }

    public DbSet<GetHorarios> GetHorarios { get; set; }

    public DbSet<GetInformacionGrupo> GetInformacionGrupo { get; set; }

    public DbSet<GetInicioAlumno> GetInicioAlumno { get; set; }

    public DbSet<GetInicioDocente> GetInicioDocente { get; set; }

    public DbSet<GetInicioGestion> GetInicioGestion { get; set; }

    public DbSet<GetMapaCurricular> GetMapaCurricular { get; set; }

    public DbSet<Grupo> Grupo { get; set; }

    public DbSet<GrupoHorario> GrupoHorario { get; set; }

    public DbSet<HistorialAcademico> HistorialAcademico { get; set; }

    public DbSet<HistorialDetalle> HistorialDetalle { get; set; }

    public DbSet<Inscripcion> Inscripcion { get; set; }

    public DbSet<InscripcionDetalle> InscripcionDetalle { get; set; }

    public DbSet<Institucion> Institucion { get; set; }

    public DbSet<MapaCurricular> MapaCurricular { get; set; }

    public DbSet<Materia> Materia { get; set; }

    public DbSet<PeriodoEscolar> PeriodoEscolar { get; set; }

    public DbSet<PlanEstudios> PlanEstudios { get; set; }

    public DbSet<Tramite> Tramite { get; set; }

    public DbSet<TrayectoriaAlumno> TrayectoriaAlumno { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
    }
}
