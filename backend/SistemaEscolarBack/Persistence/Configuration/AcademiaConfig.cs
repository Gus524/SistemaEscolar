using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Contexts;

namespace Persistence.Configuration;

public class AcademiaConfig : IEntityTypeConfiguration<Academia>
{
    public void Configure(EntityTypeBuilder<Academia> builder)
    {
        builder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        builder.HasKey(e => e.IdAcademia).HasName("PRIMARY");

        builder.HasIndex(e => e.IdEdificio, "id_edificio");

        builder.Property(e => e.IdAcademia).HasColumnName("id_academia");
        builder.Property(e => e.IdEdificio).HasColumnName("id_edificio");
        builder.Property(e => e.NomAcademia)
            .HasMaxLength(64)
            .HasColumnName("nom_academia");

        builder.HasOne(d => d.IdEdificioNavigation).WithMany(p => p.Academia)
            .HasForeignKey(d => d.IdEdificio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Academia_ibfk_1");
    }
}