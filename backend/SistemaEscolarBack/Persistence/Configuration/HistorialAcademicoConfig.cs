using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class HistorialAcademicoConfig : IEntityTypeConfiguration<HistorialAcademico>
{
    public void Configure(EntityTypeBuilder<HistorialAcademico> builder)
    {
        builder.HasKey(e => new { e.NoBoleta, e.IdPlan })
            .HasName("PRIMARY")
            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

        builder.ToTable("Historial_Academico");

        builder.HasIndex(e => e.IdPlan, "id_plan");

        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.Promedio)
            .HasDefaultValueSql("'0'")
            .HasColumnName("promedio");
        builder.Property(e => e.UltimoSemestre)
            .HasDefaultValueSql("'0'")
            .HasColumnName("ultimo_semestre");

        builder.Property(e => e.EstadoHistorial)
            .HasColumnName("estado_historial")
            .HasDefaultValueSql("1");

        builder.HasOne(d => d.IdPlanNavigation).WithMany(p => p.HistorialAcademico)
            .HasForeignKey(d => d.IdPlan)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Historial_Academico_ibfk_2");

        builder.HasOne(d => d.NoBoletaNavigation).WithMany(p => p.HistorialAcademico)
            .HasForeignKey(d => d.NoBoleta)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Historial_Academico_ibfk_1");

        builder.HasOne(d => d.TrayectoriaAlumno)
            .WithOne(ta => ta.HistorialAcademico)
            .HasForeignKey<TrayectoriaAlumno>(ta => new { ta.NoBoleta, ta.IdPlan });

        builder.HasMany(d => d.EstadoGeneral)
            .WithOne(d => d.HistorialAcademico)
            .HasForeignKey(d => new { d.NoBoleta, d.IdPlan });
    }
}