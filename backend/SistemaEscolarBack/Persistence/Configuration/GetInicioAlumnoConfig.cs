using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetInicioAlumnoConfig : IEntityTypeConfiguration<GetInicioAlumno>
{
    public void Configure(EntityTypeBuilder<GetInicioAlumno> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetInicioAlumno");

        builder.Property(e => e.DescCarr)
            .HasMaxLength(64)
            .HasColumnName("desc_carr");
        builder.Property(e => e.IdInst).HasColumnName("id_inst");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.NomInst)
            .HasMaxLength(128)
            .HasColumnName("nom_inst");
        builder.Property(e => e.Nombre)
            .HasMaxLength(194)
            .HasColumnName("nombre");
    }
}