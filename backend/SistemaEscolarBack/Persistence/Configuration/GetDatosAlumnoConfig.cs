using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetDatosAlumnoConfig : IEntityTypeConfiguration<GetDatosAlumno>
{
    public void Configure(EntityTypeBuilder<GetDatosAlumno> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetDatosAlumno");

        builder.Property(e => e.Calle)
            .HasMaxLength(64)
            .HasColumnName("calle");
        builder.Property(e => e.Colonia)
            .HasMaxLength(64)
            .HasColumnName("colonia");
        builder.Property(e => e.Cp)
            .HasPrecision(5)
            .HasColumnName("cp");
        builder.Property(e => e.Curp).HasColumnName("curp");
        builder.Property(e => e.Delegacion)
            .HasMaxLength(64)
            .HasColumnName("delegacion");
        builder.Property(e => e.DescCarr)
            .HasMaxLength(64)
            .HasColumnName("desc_carr");
        builder.Property(e => e.DescPlan)
            .HasMaxLength(64)
            .HasColumnName("desc_plan");
        builder.Property(e => e.EmailIAlumno)
            .HasMaxLength(128)
            .HasColumnName("email_i_alumno");
        builder.Property(e => e.EmailPAlumno)
            .HasMaxLength(128)
            .HasColumnName("email_p_alumno");
        builder.Property(e => e.Institucion)
            .HasMaxLength(128)
            .HasColumnName("institucion");
        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.NoExt)
            .HasMaxLength(10)
            .HasColumnName("no_ext");
        builder.Property(e => e.NoInt)
            .HasMaxLength(10)
            .HasColumnName("no_int");
        builder.Property(e => e.Nombre)
            .HasMaxLength(194)
            .HasColumnName("nombre");
        builder.Property(e => e.Promedio)
            .HasDefaultValueSql("'0'")
            .HasColumnName("promedio");
        builder.Property(e => e.TelfAlumno).HasColumnName("telf_alumno");
        builder.Property(e => e.TelmAlumno).HasColumnName("telm_alumno");
    }
}