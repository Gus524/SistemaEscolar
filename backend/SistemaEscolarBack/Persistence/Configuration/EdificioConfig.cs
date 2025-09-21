using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class EdificioConfig : IEntityTypeConfiguration<Edificio>
{
    public void Configure(EntityTypeBuilder<Edificio> builder)
    {
        builder.HasKey(e => e.IdEdificio).HasName("PRIMARY");

        builder.HasIndex(e => e.IdInst, "id_inst");

        builder.Property(e => e.IdEdificio).HasColumnName("id_edificio");
        builder.Property(e => e.AbrEdificio)
            .HasMaxLength(3)
            .IsFixedLength()
            .HasColumnName("abr_edificio");
        builder.Property(e => e.DescEdificio)
            .HasMaxLength(64)
            .HasColumnName("desc_edificio");
        builder.Property(e => e.IdInst).HasColumnName("id_inst");

        builder.HasOne(d => d.IdInstNavigation).WithMany(p => p.Edificio)
            .HasForeignKey(d => d.IdInst)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Edificio_ibfk_1");
    }
}