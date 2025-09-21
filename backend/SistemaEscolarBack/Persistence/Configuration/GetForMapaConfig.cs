using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetForMapaConfig : IEntityTypeConfiguration<GetForMapa>
{
    public void Configure(EntityTypeBuilder<GetForMapa> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetForMapa");

        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.Plan)
            .HasMaxLength(64)
            .HasColumnName("plan");
    }
}