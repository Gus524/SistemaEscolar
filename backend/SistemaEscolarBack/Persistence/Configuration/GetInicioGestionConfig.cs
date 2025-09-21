using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetInicioGestionConfig : IEntityTypeConfiguration<GetInicioGestion>
{
    public void Configure(EntityTypeBuilder<GetInicioGestion> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetInicioGestion");

        builder.Property(e => e.IdInst).HasColumnName("id_inst");
        builder.Property(e => e.NomInst)
            .HasMaxLength(128)
            .HasColumnName("nom_inst");
        builder.Property(e => e.Usuario)
            .HasMaxLength(64)
            .HasColumnName("usuario");
    }
}