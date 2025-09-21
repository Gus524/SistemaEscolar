using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class InscripcionDetalleConfig : IEntityTypeConfiguration<InscripcionDetalle>
{
    public void Configure(EntityTypeBuilder<InscripcionDetalle> builder)
    {
        builder.HasKey(e => new { e.NoBoleta, e.IdPeriodo, e.IdPlan, e.AbrCarr, e.Semestre, e.Turno, e.NoGrupo, e.NoMateria })
            .HasName("PRIMARY")
            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });

        builder.ToTable("Inscripcion_Detalle");

        builder.HasIndex(e => new { e.IdPeriodo, e.AbrCarr, e.IdPlan, e.Semestre, e.Turno, e.NoGrupo, e.NoMateria }, "id_periodo");

        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.Semestre).HasColumnName("semestre");
        builder.Property(e => e.Turno)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("turno");
        builder.Property(e => e.NoGrupo).HasColumnName("no_grupo");
        builder.Property(e => e.NoMateria)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("no_materia");
        builder.Property(e => e.CalExtra).HasColumnName("cal_extra");
        builder.Property(e => e.CalFinal).HasColumnName("cal_final");
        builder.Property(e => e.CalParcial1).HasColumnName("cal_parcial_1");
        builder.Property(e => e.CalParcial2).HasColumnName("cal_parcial_2");
        builder.Property(e => e.CalParcial3).HasColumnName("cal_parcial_3");

        builder.HasOne(d => d.Inscripcion).WithMany(p => p.InscripcionDetalle)
            .HasForeignKey(d => new { d.NoBoleta, d.IdPeriodo, d.IdPlan })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Inscripcion_Detalle_ibfk_1");

        builder.HasOne(d => d.GrupoHorario).WithMany(p => p.InscripcionDetalle)
            .HasForeignKey(d => new { d.IdPeriodo, d.AbrCarr, d.IdPlan, d.Semestre, d.Turno, d.NoGrupo, d.NoMateria })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Inscripcion_Detalle_ibfk_2");
    }
}