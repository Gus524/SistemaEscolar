using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetDatosDocenteConfig : IEntityTypeConfiguration<GetDatosDocente>
{
    public void Configure(EntityTypeBuilder<GetDatosDocente> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetDatosDocente");

        builder.Property(e => e.Calle)
            .HasMaxLength(64)
            .HasColumnName("calle");
        builder.Property(e => e.Colonia)
            .HasMaxLength(64)
            .HasColumnName("colonia");
        builder.Property(e => e.Cp)
            .HasPrecision(5)
            .HasColumnName("cp");
        builder.Property(e => e.Delegacion)
            .HasMaxLength(64)
            .HasColumnName("delegacion");
        builder.Property(e => e.DescEdificio)
            .HasMaxLength(64)
            .HasColumnName("desc_edificio");
        builder.Property(e => e.EmailIDoc)
            .HasMaxLength(128)
            .HasColumnName("email_i_doc");
        builder.Property(e => e.EmailPDoc)
            .HasMaxLength(128)
            .HasColumnName("email_p_doc");
        builder.Property(e => e.NoExt)
            .HasMaxLength(10)
            .HasColumnName("no_ext");
        builder.Property(e => e.NoInt)
            .HasMaxLength(10)
            .HasColumnName("no_int");
        builder.Property(e => e.NomAcademia)
            .HasMaxLength(64)
            .HasColumnName("nom_academia");
        builder.Property(e => e.Nombre)
            .HasMaxLength(194)
            .HasColumnName("nombre");
        builder.Property(e => e.Rfc)
            .HasMaxLength(13)
            .HasColumnName("rfc");
        builder.Property(e => e.TelDoc)
            .HasMaxLength(10)
            .HasColumnName("tel_doc");
    }
}