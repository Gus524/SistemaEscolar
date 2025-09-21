using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class AlumnoEtsConfig : IEntityTypeConfiguration<AlumnoEts>
{
    public void Configure(EntityTypeBuilder<AlumnoEts> builder)
    {
        builder
            .HasNoKey()
            .ToTable("Alumno_ETS");

        builder.HasIndex(e => new { e.IdPeriodo, e.AbrCarr, e.IdPlan, e.Ronda, e.Semestre, e.Turno, e.NoMateria }, "id_periodo");

        builder.HasIndex(e => e.NoBoleta, "no_boleta");

        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.Calificacion).HasColumnName("calificacion");
        builder.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.NoMateria)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("no_materia");
        builder.Property(e => e.Ronda).HasColumnName("ronda");
        builder.Property(e => e.Semestre).HasColumnName("semestre");
        builder.Property(e => e.Turno)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("turno");

        builder.HasOne(d => d.NoBoletaNavigation).WithMany()
            .HasForeignKey(d => d.NoBoleta)
            .HasConstraintName("Alumno_ETS_ibfk_1");

        builder.HasOne(d => d.Ets).WithMany()
            .HasForeignKey(d => new { d.IdPeriodo, d.AbrCarr, d.IdPlan, d.Ronda, d.Semestre, d.Turno, d.NoMateria })
            .HasConstraintName("Alumno_ETS_ibfk_2");
    }
}