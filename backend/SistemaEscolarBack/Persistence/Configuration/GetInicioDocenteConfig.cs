using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetInicioDocenteConfig : IEntityTypeConfiguration<GetInicioDocente>
{
    public void Configure(EntityTypeBuilder<GetInicioDocente> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetInicioDocente");

        builder.Property(e => e.IdInst).HasColumnName("id_inst");
        builder.Property(e => e.NomAcademia)
            .HasMaxLength(64)
            .HasColumnName("nom_academia");
        builder.Property(e => e.NomInst)
            .HasMaxLength(128)
            .HasColumnName("nom_inst");
        builder.Property(e => e.Nombre)
            .HasMaxLength(194)
            .HasColumnName("nombre");
        builder.Property(e => e.Rfc)
            .HasMaxLength(13)
            .HasColumnName("rfc");
    }
}