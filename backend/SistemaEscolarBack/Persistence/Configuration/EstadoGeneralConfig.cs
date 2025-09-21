using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class EstadoGeneralConfig : IEntityTypeConfiguration<EstadoGeneral>
{
    public void Configure(EntityTypeBuilder<EstadoGeneral> builder)
    {
        builder
            .HasNoKey()
            .ToTable("Estado_General");

        builder.HasIndex(e => new { e.IdPlan, e.AbrCarr, e.Semestre, e.NoMateria }, "id_plan");

        builder.HasIndex(e => new { e.NoBoleta, e.IdPlan }, "no_boleta");

        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.Estado)
            .HasMaxLength(10)
            .HasDefaultValueSql("'NO CURSADA'")
            .HasColumnName("estado");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.NoMateria)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("no_materia");
        builder.Property(e => e.Semestre).HasColumnName("semestre");

        builder.HasOne(d => d.HistorialAcademico).WithMany()
            .HasForeignKey(d => new { d.NoBoleta, d.IdPlan })
            .HasConstraintName("Estado_General_ibfk_1");

        builder.HasOne(d => d.MapaCurricular).WithMany()
            .HasForeignKey(d => new { d.IdPlan, d.AbrCarr, d.Semestre, d.NoMateria })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Estado_General_ibfk_2");
    }
}