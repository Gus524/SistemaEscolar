using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class DocenteConfig : IEntityTypeConfiguration<Docente>
{
    public void Configure(EntityTypeBuilder<Docente> builder)
    {
        builder.HasKey(e => e.Rfc).HasName("PRIMARY");

        builder.HasIndex(e => e.IdAcademia, "id_academia");

        builder.Property(e => e.Rfc)
            .HasMaxLength(13)
            .HasColumnName("rfc");
        builder.Property(e => e.AmDoc)
            .HasMaxLength(64)
            .HasColumnName("am_doc");
        builder.Property(e => e.ApDoc)
            .HasMaxLength(64)
            .HasColumnName("ap_doc");
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
        builder.Property(e => e.EmailIDoc)
            .HasMaxLength(128)
            .HasColumnName("email_i_doc");
        builder.Property(e => e.EmailPDoc)
            .HasMaxLength(128)
            .HasColumnName("email_p_doc");
        builder.Property(e => e.IdAcademia).HasColumnName("id_academia");
        builder.Property(e => e.NoExt)
            .HasMaxLength(10)
            .HasColumnName("no_ext");
        builder.Property(e => e.NoInt)
            .HasMaxLength(10)
            .HasColumnName("no_int");
        builder.Property(e => e.NomDoc)
            .HasMaxLength(64)
            .HasColumnName("nom_doc");
        builder.Property(e => e.TelDoc)
            .HasMaxLength(10)
            .HasColumnName("tel_doc");

        builder.HasOne(d => d.IdAcademiaNavigation).WithMany(p => p.Docente)
            .HasForeignKey(d => d.IdAcademia)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Docente_ibfk_1");
    }
}