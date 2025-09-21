using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetAlumnoCalificacionesConfig : IEntityTypeConfiguration<GetAlumnoCalificaciones>
{
    public void Configure(EntityTypeBuilder<GetAlumnoCalificaciones> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetAlumnoCalificaciones");

        builder.Property(e => e.CalExtra).HasColumnName("cal_extra");
        builder.Property(e => e.CalFinal).HasColumnName("cal_final");
        builder.Property(e => e.CalParcial1).HasColumnName("cal_parcial_1");
        builder.Property(e => e.CalParcial2).HasColumnName("cal_parcial_2");
        builder.Property(e => e.CalParcial3).HasColumnName("cal_parcial_3");
        builder.Property(e => e.Clave)
            .HasMaxLength(14)
            .HasColumnName("clave");
        builder.Property(e => e.Grupo)
            .HasMaxLength(35)
            .HasColumnName("grupo");
        builder.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.NoBoleta).HasColumnName("no_boleta");
        builder.Property(e => e.NomMateria)
            .HasMaxLength(64)
            .HasColumnName("nom_materia");
    }
}