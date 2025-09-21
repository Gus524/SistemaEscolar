using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetGruposPlanConfig : IEntityTypeConfiguration<GetGruposPlan>
{
    public void Configure(EntityTypeBuilder<GetGruposPlan> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetGruposPlan");

        builder.Property(e => e.Activo)
            .HasDefaultValueSql("'0'")
            .HasColumnName("activo");
        builder.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.Secuencia)
            .HasMaxLength(35)
            .HasColumnName("secuencia");
        builder.Property(e => e.Semestre).HasColumnName("semestre");
        builder.Property(e => e.Turno)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("turno");
    }
}