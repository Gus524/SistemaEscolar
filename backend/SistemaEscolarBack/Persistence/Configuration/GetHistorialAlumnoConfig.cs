using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetHistorialAlumnoConfig : IEntityTypeConfiguration<GetHistorialAlumno>
{
    public void Configure(EntityTypeBuilder<GetHistorialAlumno> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetHistorialAlumno");

        builder.Property(e => e.DescCarr)
            .HasMaxLength(64)
            .HasColumnName("desc_carr");
        builder.Property(e => e.DescPlan)
            .HasMaxLength(64)
            .HasColumnName("desc_plan");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.Nombre)
            .HasMaxLength(194)
            .HasColumnName("nombre");
        builder.Property(e => e.Promedio)
            .HasDefaultValueSql("'0'")
            .HasColumnName("promedio");
        builder.Property(e => e.UltimoSemestre)
            .HasDefaultValueSql("'0'")
            .HasColumnName("ultimo_semestre");
    }
}