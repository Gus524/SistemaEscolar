using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class TramiteConfig : IEntityTypeConfiguration<Tramite>
{
    public void Configure(EntityTypeBuilder<Tramite> builder)
    {
        builder.HasKey(e => e.IdTramite).HasName("PRIMARY");

        builder.HasIndex(e => e.NoBoleta, "no_boleta");

        builder.Property(e => e.IdTramite).HasColumnName("id_tramite");
        builder.Property(e => e.Estado)
            .HasMaxLength(20)
            .HasColumnName("estado");
        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.TipoTramite)
            .HasMaxLength(64)
            .HasColumnName("tipo_tramite");

        builder.HasOne(d => d.NoBoletaNavigation).WithMany(p => p.Tramite)
            .HasForeignKey(d => d.NoBoleta)
            .HasConstraintName("Tramite_ibfk_1");
    }
}