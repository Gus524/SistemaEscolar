using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class GrupoHorarioConfig : IEntityTypeConfiguration<GrupoHorario>
{
    public void Configure(EntityTypeBuilder<GrupoHorario> builder)
    {
        builder.HasKey(e => new { e.IdPeriodo, e.AbrCarr, e.IdPlan, e.Semestre, e.Turno, e.NoGrupo, e.NoMateria })
            .HasName("PRIMARY")
            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

        builder.ToTable("Grupo_Horario");

        builder.HasIndex(e => new { e.IdPlan, e.AbrCarr, e.Semestre, e.NoMateria }, "id_plan");

        builder.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
        builder.Property(e => e.AbrCarr)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("abr_carr");
        builder.Property(e => e.IdPlan).HasColumnName("id_plan");
        builder.Property(e => e.Semestre).HasColumnName("semestre");
        builder.Property(e => e.Turno)
            .HasMaxLength(1)
            .IsFixedLength()
            .HasColumnName("turno");
        builder.Property(e => e.NoGrupo).HasColumnName("no_grupo");
        builder.Property(e => e.NoMateria)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("no_materia");
        builder.Property(e => e.Cupo)
            .HasDefaultValueSql("'40'")
            .HasColumnName("cupo");
        builder.Property(e => e.Disponibles)
            .HasDefaultValueSql("'40'")
            .HasColumnName("disponibles");
        builder.Property(e => e.Inscritos)
            .HasDefaultValueSql("'0'")
            .HasColumnName("inscritos");
        builder.Property(e => e.JueF)
            .HasColumnType("time")
            .HasColumnName("jue_f");
        builder.Property(e => e.JueI)
            .HasColumnType("time")
            .HasColumnName("jue_i");
        builder.Property(e => e.JueSal)
            .HasMaxLength(10)
            .HasColumnName("jue_sal");
        builder.Property(e => e.LunF)
            .HasColumnType("time")
            .HasColumnName("lun_f");
        builder.Property(e => e.LunI)
            .HasColumnType("time")
            .HasColumnName("lun_i");
        builder.Property(e => e.LunSal)
            .HasMaxLength(10)
            .HasColumnName("lun_sal");
        builder.Property(e => e.MarF)
            .HasColumnType("time")
            .HasColumnName("mar_f");
        builder.Property(e => e.MarI)
            .HasColumnType("time")
            .HasColumnName("mar_i");
        builder.Property(e => e.MarSal)
            .HasMaxLength(10)
            .HasColumnName("mar_sal");
        builder.Property(e => e.MieF)
            .HasColumnType("time")
            .HasColumnName("mie_f");
        builder.Property(e => e.MieI)
            .HasColumnType("time")
            .HasColumnName("mie_i");
        builder.Property(e => e.MieSal)
            .HasMaxLength(10)
            .HasColumnName("mie_sal");
        builder.Property(e => e.Sobrecupo)
            .HasDefaultValueSql("'0'")
            .HasColumnName("sobrecupo");
        builder.Property(e => e.VieF)
            .HasColumnType("time")
            .HasColumnName("vie_f");
        builder.Property(e => e.VieI)
            .HasColumnType("time")
            .HasColumnName("vie_i");
        builder.Property(e => e.VieSal)
            .HasMaxLength(10)
            .HasColumnName("vie_sal");

        builder.HasOne(d => d.MapaCurricular).WithMany(p => p.GrupoHorario)
            .HasForeignKey(d => new { d.IdPlan, d.AbrCarr, d.Semestre, d.NoMateria })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Grupo_Horario_ibfk_2");

        builder.HasOne(d => d.Grupo).WithMany(p => p.GrupoHorario)
            .HasForeignKey(d => new { d.IdPeriodo, d.AbrCarr, d.IdPlan, d.Semestre, d.Turno, d.NoGrupo })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Grupo_Horario_ibfk_1");
    }
}