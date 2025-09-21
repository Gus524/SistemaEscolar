using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class GestionConfig : IEntityTypeConfiguration<Gestion>
{
    public void Configure(EntityTypeBuilder<Gestion> builder)
    {
        builder.HasNoKey();

        builder.HasIndex(e => e.IdInst, "id_inst");

        builder.Property(e => e.IdInst).HasColumnName("id_inst");
        builder.Property(e => e.Usuario)
            .HasMaxLength(64)
            .HasColumnName("usuario");

        builder.HasOne(d => d.IdInstNavigation).WithMany()
            .HasForeignKey(d => d.IdInst)
            .HasConstraintName("Gestion_ibfk_1");
    }
}