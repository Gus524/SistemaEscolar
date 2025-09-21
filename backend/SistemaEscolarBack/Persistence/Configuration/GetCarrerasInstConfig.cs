using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetCarrerasInstConfig : IEntityTypeConfiguration<GetCarrerasInst>
{
    public void Configure(EntityTypeBuilder<GetCarrerasInst> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetCarrerasInst");

        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.Carrera)
            .HasMaxLength(64)
            .HasColumnName("carrera");
        builder.Property(e => e.IdInst).HasColumnName("id_inst");
        builder.Property(e => e.NoSem).HasColumnName("no_sem");
    }
}