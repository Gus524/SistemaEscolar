using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetGruposDocenteConfig : IEntityTypeConfiguration<GetGruposDocente>
{
    public void Configure(EntityTypeBuilder<GetGruposDocente> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetGruposDocente");

        builder.Property(e => e.Clave)
            .HasMaxLength(14)
            .HasColumnName("clave");
        builder.Property(e => e.Grupo)
            .HasMaxLength(35)
            .HasColumnName("grupo");
        builder.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
        builder.Property(e => e.NomMateria)
            .HasMaxLength(64)
            .HasColumnName("nom_materia");
        builder.Property(e => e.Rfc)
            .HasMaxLength(13)
            .HasColumnName("rfc");
    }
}