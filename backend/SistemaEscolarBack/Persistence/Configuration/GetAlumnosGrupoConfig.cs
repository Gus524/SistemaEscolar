using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetAlumnosGrupoConfig : IEntityTypeConfiguration<GetAlumnosGrupo>
{
    public void Configure(EntityTypeBuilder<GetAlumnosGrupo> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetAlumnosGrupo");

        builder.Property(e => e.Am)
            .HasMaxLength(64)
            .HasColumnName("am");
        builder.Property(e => e.Ap)
            .HasMaxLength(64)
            .HasColumnName("ap");
        builder.Property(e => e.CalExtra).HasColumnName("cal_extra");
        builder.Property(e => e.CalFinal).HasColumnName("cal_final");
        builder.Property(e => e.CalParcial1).HasColumnName("cal_parcial_1");
        builder.Property(e => e.CalParcial2).HasColumnName("cal_parcial_2");
        builder.Property(e => e.CalParcial3).HasColumnName("cal_parcial_3");
        builder.Property(e => e.Clave)
            .HasMaxLength(14)
            .HasColumnName("clave");
        builder.Property(e => e.EmailIAlumno)
            .HasMaxLength(128)
            .HasColumnName("email_i_alumno");
        builder.Property(e => e.EmailPAlumno)
            .HasMaxLength(128)
            .HasColumnName("email_p_alumno");
        builder.Property(e => e.Grupo)
            .HasMaxLength(35)
            .HasColumnName("grupo");
        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.Nombre)
            .HasMaxLength(64)
            .HasColumnName("nombre");
        builder.Property(e => e.Rfc)
            .HasMaxLength(13)
            .HasColumnName("rfc");
    }
}