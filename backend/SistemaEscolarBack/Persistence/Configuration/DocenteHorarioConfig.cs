using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class DocenteHorarioConfig : IEntityTypeConfiguration<DocenteHorario>
{
    public void Configure(EntityTypeBuilder<DocenteHorario> builder)
    {
        builder
            .HasNoKey()
            .ToTable("Docente_Horario");

        builder.HasIndex(e => new { e.IdPeriodo, e.AbrCarr, e.IdPlan, e.Semestre, e.Turno, e.NoGrupo, e.NoMateria }, "id_periodo");

        builder.HasIndex(e => e.Rfc, "rfc");

        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.NoGrupo).HasColumnName("no_grupo");
        builder.Property(e => e.NoMateria)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("no_materia");
        builder.Property(e => e.Rfc)
            .HasMaxLength(13)
            .HasColumnName("rfc");
        builder.Property(e => e.Semestre).HasColumnName("semestre");
        builder.Property(e => e.Turno)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("turno");

        builder.HasOne(d => d.RfcNavigation).WithMany()
            .HasForeignKey(d => d.Rfc)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Docente_Horario_ibfk_1");

        builder.HasOne(d => d.GrupoHorario).WithMany()
            .HasForeignKey(d => new { d.IdPeriodo, d.AbrCarr, d.IdPlan, d.Semestre, d.Turno, d.NoGrupo, d.NoMateria })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Docente_Horario_ibfk_2");
    }
}