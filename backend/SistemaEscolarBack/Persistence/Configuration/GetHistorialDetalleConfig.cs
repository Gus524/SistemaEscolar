using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetHistorialDetalleConfig : IEntityTypeConfiguration<GetHistorialDetalle>
{
    public void Configure(EntityTypeBuilder<GetHistorialDetalle> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetHistorialDetalle");

        builder.Property(e => e.Calificacion).HasColumnName("calificacion");
        builder.Property(e => e.Clave)
            .HasMaxLength(14)
            .HasColumnName("clave");
        builder.Property(e => e.DescPeriodo)
            .HasMaxLength(4)
            .HasColumnName("desc_periodo");
        builder.Property(e => e.FechaEval).HasColumnName("fecha_eval");
        builder.Property(e => e.FormaEval)
            .HasMaxLength(3)
            .HasColumnName("forma_eval");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.NomMateria)
            .HasMaxLength(64)
            .HasColumnName("nom_materia");
        builder.Property(e => e.Semestre).HasColumnName("semestre");
    }
}