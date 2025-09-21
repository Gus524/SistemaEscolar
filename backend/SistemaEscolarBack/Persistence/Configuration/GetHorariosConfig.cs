using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetHorariosConfig : IEntityTypeConfiguration<GetHorarios>
{
    public void Configure(EntityTypeBuilder<GetHorarios> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetHorarios");

        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.Activo)
            .HasDefaultValueSql("'0'")
            .HasColumnName("activo");
        builder.Property(e => e.Cupo)
            .HasDefaultValueSql("'40'")
            .HasColumnName("cupo");
        builder.Property(e => e.Disponibles)
            .HasDefaultValueSql("'40'")
            .HasColumnName("disponibles");
        builder.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.Jue)
            .HasMaxLength(21)
            .HasColumnName("jue");
        builder.Property(e => e.Lunes)
            .HasMaxLength(21)
            .HasColumnName("lunes");
        builder.Property(e => e.Martes)
            .HasMaxLength(21)
            .HasColumnName("martes");
        builder.Property(e => e.Materia)
            .HasMaxLength(64)
            .HasColumnName("materia");
        builder.Property(e => e.Miercoles)
            .HasMaxLength(21)
            .HasColumnName("miercoles");
        builder.Property(e => e.NoGrupo).HasColumnName("no_grupo");
        builder.Property(e => e.NoMateria)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("no_materia");
        builder.Property(e => e.Nombre)
            .HasMaxLength(194)
            .HasColumnName("nombre");
        builder.Property(e => e.Semestre).HasColumnName("semestre");
        builder.Property(e => e.Sobrecupo)
            .HasDefaultValueSql("'0'")
            .HasColumnName("sobrecupo");
        builder.Property(e => e.Turno)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("turno");
        builder.Property(e => e.Viernes)
            .HasMaxLength(21)
            .HasColumnName("viernes");
    }
}