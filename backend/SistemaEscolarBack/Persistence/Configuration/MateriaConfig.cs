using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class MateriaConfig : IEntityTypeConfiguration<Materia>
{
    public void Configure(EntityTypeBuilder<Materia> builder)
    {
        builder.HasKey(e => e.IdMateria).HasName("PRIMARY");

        builder.HasIndex(e => e.IdAcademia, "id_academia");

        builder.Property(e => e.IdMateria).HasColumnName("id_materia");
        builder.Property(e => e.HorasPrac).HasColumnName("horas_prac");
        builder.Property(e => e.HorasTeoria).HasColumnName("horas_teoria");
        builder.Property(e => e.IdAcademia).HasColumnName("id_academia");
        builder.Property(e => e.NomMateria)
            .HasMaxLength(64)
            .HasColumnName("nom_materia");
        builder.Property(e => e.TipoMateria)
            .HasMaxLength(20)
            .HasColumnName("tipo_materia");

        builder.HasOne(d => d.IdAcademiaNavigation).WithMany(p => p.Materia)
            .HasForeignKey(d => d.IdAcademia)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Materia_ibfk_1");
    }
}