using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class TrayectoriaAlumnoConfig : IEntityTypeConfiguration<TrayectoriaAlumno>
{
    public void Configure(EntityTypeBuilder<TrayectoriaAlumno> builder)
    {
        builder
            .HasNoKey()
            .ToTable("Trayectoria_Alumno");

        builder.HasIndex(e => new { e.NoBoleta, e.IdPlan }, "no_boleta");

        builder.Property(e => e.CredFaltantes).HasColumnName("cred_faltantes");
        builder.Property(e => e.CredObtenidos)
            .HasDefaultValueSql("'0'")
            .HasColumnName("cred_obtenidos");
        builder.Property(e => e.CredPermitidos)
            .HasDefaultValueSql("'0'")
            .HasColumnName("cred_permitidos");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.PerCursados)
            .HasDefaultValueSql("'0'")
            .HasColumnName("per_cursados");
        builder.Property(e => e.PerDisponibles).HasColumnName("per_disponibles");

        builder.HasOne(d => d.HistorialAcademico).WithMany()
            .HasForeignKey(d => new { d.NoBoleta, d.IdPlan })
            .HasConstraintName("Trayectoria_Alumno_ibfk_1");
    }
}