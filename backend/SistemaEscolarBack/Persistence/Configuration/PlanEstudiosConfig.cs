using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class PlanEstudiosConfig : IEntityTypeConfiguration<PlanEstudios>
{
    public void Configure(EntityTypeBuilder<PlanEstudios> builder)
    {
        builder.HasKey(e => e.IdPlan).HasName("PRIMARY");

        builder.ToTable("Plan_Estudios");

        builder.HasIndex(e => e.AbrCarr, "abr_carr");

        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.DescPlan)
            .HasMaxLength(64)
            .HasColumnName("desc_plan");
        builder.Property(e => e.NoPlan)
            .HasPrecision(3, 0)
            .HasColumnName("no_plan");

        builder.HasOne(d => d.AbrCarrNavigation).WithMany(p => p.PlanEstudios)
            .HasForeignKey(d => d.AbrCarr)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Plan_Estudios_ibfk_1");
    }
}