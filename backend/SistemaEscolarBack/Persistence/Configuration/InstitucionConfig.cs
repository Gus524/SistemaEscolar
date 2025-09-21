using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class InstitucionConfig : IEntityTypeConfiguration<Institucion>
{
    public void Configure(EntityTypeBuilder<Institucion> builder)
    {
        builder.HasKey(e => e.IdInst).HasName("PRIMARY");

        builder.HasIndex(e => e.Abreviatura, "abreviatura").IsUnique();

        builder.HasIndex(e => e.NomInst, "nom_inst").IsUnique();

        builder.Property(e => e.IdInst).HasColumnName("id_inst");
        builder.Property(e => e.Abreviatura)
            .HasMaxLength(20)
            .HasColumnName("abreviatura");
        builder.Property(e => e.NomInst)
            .HasMaxLength(128)
            .HasColumnName("nom_inst");
    }
}