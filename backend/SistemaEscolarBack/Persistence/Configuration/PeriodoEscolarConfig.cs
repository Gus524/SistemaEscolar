using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class PeriodoEscolarConfig : IEntityTypeConfiguration<PeriodoEscolar>
{
    public void Configure(EntityTypeBuilder<PeriodoEscolar> builder)
    {
        builder.HasKey(e => e.IdPeriodo).HasName("PRIMARY");

        builder.ToTable("Periodo_Escolar");

        builder.Property(e => e.IdPeriodo)
            .ValueGeneratedNever()
            .HasColumnName("id_periodo");
        builder.Property(e => e.Activo)
            .HasDefaultValueSql("'0'")
            .HasColumnName("activo");
        builder.Property(e => e.DescPeriodo)
            .HasMaxLength(4)
            .HasColumnName("desc_periodo");
        builder.Property(e => e.FechaFin).HasColumnName("fecha_fin");
        builder.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
    }
}