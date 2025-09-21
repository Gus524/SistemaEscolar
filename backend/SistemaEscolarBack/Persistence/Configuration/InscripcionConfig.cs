using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class InscripcionConfig : IEntityTypeConfiguration<Inscripcion>
{
    public void Configure(EntityTypeBuilder<Inscripcion> builder)
    {
        builder.HasKey(e => new { e.NoBoleta, e.IdPeriodo, e.IdPlan })
            .HasName("PRIMARY")
            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

        builder.HasIndex(e => e.IdPeriodo, "id_periodo");

        builder.HasIndex(e => new { e.NoBoleta, e.IdPlan }, "no_boleta");

        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.FechaInscripcion).HasColumnName("fecha_inscripcion");

        builder.HasOne(d => d.IdPeriodoNavigation).WithMany(p => p.Inscripcion)
            .HasForeignKey(d => d.IdPeriodo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Inscripcion_ibfk_2");

        builder.HasOne(d => d.HistorialAcademico).WithMany(p => p.Inscripcion)
            .HasForeignKey(d => new { d.NoBoleta, d.IdPlan })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Inscripcion_ibfk_1");
    }
}