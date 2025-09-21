using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class CarreraConfig : IEntityTypeConfiguration<Carrera>
{
    public void Configure(EntityTypeBuilder<Carrera> builder)
    {
        builder.HasKey(e => e.AbrCarr).HasName("PRIMARY");

        builder.HasIndex(e => e.IdInst, "id_inst");

        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.CredTotal).HasColumnName("cred_total");
        builder.Property(e => e.DescCarr)
            .HasMaxLength(64)
            .HasColumnName("desc_carr");
        builder.Property(e => e.IdInst).HasColumnName("id_inst");
        builder.Property(e => e.MaxSemestres).HasColumnName("max_semestres");
        builder.Property(e => e.NoSem).HasColumnName("no_sem");

        builder.HasOne(d => d.IdInstNavigation).WithMany(p => p.Carrera)
            .HasForeignKey(d => d.IdInst)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Carrera_ibfk_1");
    }
}