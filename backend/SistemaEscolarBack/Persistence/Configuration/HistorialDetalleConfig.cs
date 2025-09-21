using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class HistorialDetalleConfig : IEntityTypeConfiguration<HistorialDetalle>
{
    public void Configure(EntityTypeBuilder<HistorialDetalle> builder)
    {
        builder.HasKey(e => new { e.NoBoleta, e.IdPlan, e.Semestre, e.NoMateria })
            .HasName("PRIMARY")
            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

        builder.ToTable("Historial_Detalle");

        builder.HasIndex(e => e.IdPeriodo, "id_periodo");

        builder.HasIndex(e => new { e.IdPlan, e.AbrCarr, e.Semestre, e.NoMateria }, "id_plan");

        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.Semestre).HasColumnName("semestre");
        builder.Property(e => e.NoMateria)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("no_materia");
        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.Calificacion).HasColumnName("calificacion");
        builder.Property(e => e.FechaEval).HasColumnName("fecha_eval");
        builder.Property(e => e.FormaEval)
            .HasMaxLength(3)
            .HasColumnName("forma_eval");
        builder.Property(e => e.IdPeriodo).HasColumnName("id_periodo");

        builder.HasOne(d => d.IdPeriodoNavigation).WithMany(p => p.HistorialDetalle)
            .HasForeignKey(d => d.IdPeriodo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Historial_Detalle_ibfk_1");

        builder.HasOne(d => d.HistorialAcademico).WithMany(p => p.HistorialDetalle)
            .HasForeignKey(d => new { d.NoBoleta, d.IdPlan })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Historial_Detalle_ibfk_2");

        builder.HasOne(d => d.MapaCurricular).WithMany(p => p.HistorialDetalle)
            .HasForeignKey(d => new { d.IdPlan, d.AbrCarr, d.Semestre, d.NoMateria })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Historial_Detalle_ibfk_3");
    }
}