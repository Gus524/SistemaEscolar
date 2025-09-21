using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetEstadoGeneralAlumnoConfig : IEntityTypeConfiguration<GetEstadoGeneralAlumno>
{
    public void Configure(EntityTypeBuilder<GetEstadoGeneralAlumno> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetEstadoGeneralAlumno");

        builder.Property(e => e.Estado)
            .HasMaxLength(10)
            .HasDefaultValueSql("'NO CURSADA'")
            .HasColumnName("estado");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.NomAcademia)
            .HasMaxLength(64)
            .HasColumnName("nom_academia");
        builder.Property(e => e.NomMateria)
            .HasMaxLength(64)
            .HasColumnName("nom_materia");
    }
}