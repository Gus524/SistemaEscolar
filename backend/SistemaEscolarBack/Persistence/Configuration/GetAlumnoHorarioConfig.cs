using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetAlumnoHorarioConfig : IEntityTypeConfiguration<GetAlumnoHorario>
{
    public void Configure(EntityTypeBuilder<GetAlumnoHorario> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetAlumnoHorario");

        builder.Property(e => e.Clave)
            .HasMaxLength(14)
            .HasColumnName("clave");
        builder.Property(e => e.Grupo)
            .HasMaxLength(35)
            .HasColumnName("grupo");
        builder.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
        builder.Property(e => e.Jue)
            .HasMaxLength(21)
            .HasColumnName("jue");
        builder.Property(e => e.Lunes)
            .HasMaxLength(21)
            .HasColumnName("lunes");
        builder.Property(e => e.Martes)
            .HasMaxLength(21)
            .HasColumnName("martes");
        builder.Property(e => e.Miercoles)
            .HasMaxLength(21)
            .HasColumnName("miercoles");
        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.NomMateria)
            .HasMaxLength(64)
            .HasColumnName("nom_materia");
        builder.Property(e => e.Nombre)
            .HasMaxLength(194)
            .HasColumnName("nombre");
        builder.Property(e => e.Rfc)
            .HasMaxLength(13)
            .HasColumnName("rfc");
        builder.Property(e => e.Viernes)
            .HasMaxLength(21)
            .HasColumnName("viernes");
    }
}