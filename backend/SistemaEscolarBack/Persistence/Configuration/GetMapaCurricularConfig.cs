using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetMapaCurricularConfig : IEntityTypeConfiguration<GetMapaCurricular>
{
    public void Configure(EntityTypeBuilder<GetMapaCurricular> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetMapaCurricular");

        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.Clave)
            .HasMaxLength(14)
            .HasColumnName("clave");
        builder.Property(e => e.Creditos).HasColumnName("creditos");
        builder.Property(e => e.HorasPrac).HasColumnName("horas_prac");
        builder.Property(e => e.HorasTeoria).HasColumnName("horas_teoria");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.NomMateria)
            .HasMaxLength(64)
            .HasColumnName("nom_materia");
        builder.Property(e => e.Semestre).HasColumnName("semestre");
        builder.Property(e => e.TipoMateria)
            .HasMaxLength(20)
            .HasColumnName("tipo_materia");
    }
}