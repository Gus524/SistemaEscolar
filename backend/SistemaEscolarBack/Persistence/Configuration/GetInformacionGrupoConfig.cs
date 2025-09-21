using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetInformacionGrupoConfig : IEntityTypeConfiguration<GetInformacionGrupo>
{
    public void Configure(EntityTypeBuilder<GetInformacionGrupo> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetInformacionGrupo");

        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.Cupo)
            .HasDefaultValueSql("'40'")
            .HasColumnName("cupo");
        builder.Property(e => e.Disponibles)
            .HasDefaultValueSql("'40'")
            .HasColumnName("disponibles");
        builder.Property(e => e.NoGrupo).HasColumnName("no_grupo");
        builder.Property(e => e.NoMateria)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("no_materia");
        builder.Property(e => e.NomMateria)
            .HasMaxLength(64)
            .HasColumnName("nom_materia");
        builder.Property(e => e.Semestre).HasColumnName("semestre");
        builder.Property(e => e.Sobrecupo)
            .HasDefaultValueSql("'0'")
            .HasColumnName("sobrecupo");
        builder.Property(e => e.Turno)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("turno");
    }
}