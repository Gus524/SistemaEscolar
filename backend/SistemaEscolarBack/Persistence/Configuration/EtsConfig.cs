using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class EtsConfig : IEntityTypeConfiguration<Ets>
{
    public void Configure(EntityTypeBuilder<Ets> builder)
    {
        builder.HasKey(e => new { e.IdPeriodo, e.AbrCarr, e.IdPlan, e.Ronda, e.Semestre, e.Turno, e.NoMateria })
            .HasName("PRIMARY")
            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

        builder.ToTable("ETS");

        builder.HasIndex(e => new { e.IdPlan, e.AbrCarr, e.Semestre, e.NoMateria }, "id_plan");

        builder.HasIndex(e => e.Rfc, "rfc");

        builder.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.Ronda).HasColumnName("ronda");
        builder.Property(e => e.Semestre).HasColumnName("semestre");
        builder.Property(e => e.Turno)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("turno");
        builder.Property(e => e.NoMateria)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("no_materia");
        builder.Property(e => e.Dia)
            .HasMaxLength(8)
            .HasColumnName("dia");
        builder.Property(e => e.HoraFin)
            .HasColumnType("time")
            .HasColumnName("hora_fin");
        builder.Property(e => e.HoraI)
            .HasColumnType("time")
            .HasColumnName("hora_i");
        builder.Property(e => e.Rfc)
            .HasMaxLength(13)
            .HasColumnName("rfc");
        builder.Property(e => e.Salon)
            .HasMaxLength(20)
            .HasColumnName("salon");

        builder.HasOne(d => d.IdPeriodoNavigation).WithMany(p => p.Ets)
            .HasForeignKey(d => d.IdPeriodo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("ETS_ibfk_2");

        builder.HasOne(d => d.RfcNavigation).WithMany(p => p.Ets)
            .HasForeignKey(d => d.Rfc)
            .HasConstraintName("ETS_ibfk_1");

        builder.HasOne(d => d.MapaCurricular).WithMany(p => p.Ets)
            .HasForeignKey(d => new { d.IdPlan, d.AbrCarr, d.Semestre, d.NoMateria })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("ETS_ibfk_3");
    }
}