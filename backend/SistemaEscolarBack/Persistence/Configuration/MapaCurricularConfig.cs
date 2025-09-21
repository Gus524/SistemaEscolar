using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class MapaCurricularConfig : IEntityTypeConfiguration<MapaCurricular>
{
    public void Configure(EntityTypeBuilder<MapaCurricular> builder)
    {
        builder.HasKey(e => new { e.IdPlan, e.AbrCarr, e.Semestre, e.NoMateria })
            .HasName("PRIMARY")
            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

        builder.ToTable("Mapa_Curricular");

        builder.HasIndex(e => e.AbrCarr, "abr_carr");

        builder.HasIndex(e => e.IdMateria, "id_materia");

        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.Semestre).HasColumnName("semestre");
        builder.Property(e => e.NoMateria)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("no_materia");
        builder.Property(e => e.Creditos).HasColumnName("creditos");
        builder.Property(e => e.IdMateria).HasColumnName("id_materia");

        builder.HasOne(d => d.AbrCarrNavigation).WithMany(p => p.MapaCurricular)
            .HasForeignKey(d => d.AbrCarr)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Mapa_Curricular_ibfk_3");

        builder.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.MapaCurricular)
            .HasForeignKey(d => d.IdMateria)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Mapa_Curricular_ibfk_2");

        builder.HasOne(d => d.IdPlanNavigation).WithMany(p => p.MapaCurricular)
            .HasForeignKey(d => d.IdPlan)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Mapa_Curricular_ibfk_1");
    }
}