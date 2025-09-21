using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class GrupoConfig : IEntityTypeConfiguration<Grupo>
{
    public void Configure(EntityTypeBuilder<Grupo> builder)
    {
        builder.HasKey(e => new { e.IdPeriodo, e.AbrCarr, e.IdPlan, e.Semestre, e.Turno, e.NoGrupo })
            .HasName("PRIMARY")
            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

        builder.HasIndex(e => e.AbrCarr, "abr_carr");

        builder.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.Semestre).HasColumnName("semestre");
        builder.Property(e => e.Turno)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("turno");
        builder.Property(e => e.NoGrupo).HasColumnName("no_grupo");

        builder.HasOne(d => d.AbrCarrNavigation).WithMany(p => p.Grupo)
            .HasForeignKey(d => d.AbrCarr)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Grupo_ibfk_1");

        builder.HasOne(d => d.IdPeriodoNavigation).WithMany(p => p.Grupo)
            .HasForeignKey(d => d.IdPeriodo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Grupo_ibfk_2");
    }
}