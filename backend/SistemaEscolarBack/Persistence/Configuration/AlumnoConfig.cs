using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Contexts;

namespace Persistence.Configuration;

public class AlumnoConfig : IEntityTypeConfiguration<Alumno>
{
    public void Configure(EntityTypeBuilder<Alumno> builder)
    {
        builder.HasKey(e => e.NoBoleta).HasName("PRIMARY");

        builder.Property(e => e.NoBoleta)
            .ValueGeneratedNever()
            .HasColumnName("no_boleta");
        builder.Property(e => e.AmAl)
            .HasMaxLength(64)
            .HasColumnName("am_al");
        builder.Property(e => e.ApAl)
            .HasMaxLength(64)
            .HasColumnName("ap_al");
        builder.Property(e => e.Calle)
            .HasMaxLength(64)
            .HasColumnName("calle");
        builder.Property(e => e.Colonia)
            .HasMaxLength(64)
            .HasColumnName("colonia");
        builder.Property(e => e.Cp)
            .HasPrecision(5)
            .HasColumnName("cp");
        builder.Property(e => e.Curp)
            .HasMaxLength(20)
            .HasColumnName("curp");
        builder.Property(e => e.Delegacion)
            .HasMaxLength(64)
            .HasColumnName("delegacion");
        builder.Property(e => e.EmailIAlumno)
            .HasMaxLength(128)
            .HasColumnName("email_i_alumno");
        builder.Property(e => e.EmailPAlumno)
            .HasMaxLength(128)
            .HasColumnName("email_p_alumno");
        builder.Property(e => e.NoExt)
            .HasMaxLength(10)
            .HasColumnName("no_ext");
        builder.Property(e => e.NoInt)
            .HasMaxLength(10)
            .HasColumnName("no_int");
        builder.Property(e => e.NomAl)
            .HasMaxLength(64)
            .HasColumnName("nom_al");
        builder.Property(e => e.TelfAlumno)
            .HasMaxLength(12)
            .HasColumnName("telf_alumno");
        builder.Property(e => e.TelmAlumno)
            .HasMaxLength(12)
            .HasColumnName("telm_alumno");
    }
}