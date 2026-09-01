using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetHorariosValidacionConfig : IEntityTypeConfiguration<GetHorariosValidacion>
{
    public void Configure(EntityTypeBuilder<GetHorariosValidacion> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetHorariosValidacion");

        builder.Property(x => x.GrupoMateria)
            .HasMaxLength(8)
            .HasColumnName("grupo_materia");
        
        builder.Property(x => x.Semestre)
            .HasColumnName("semestre");
        
        builder.Property(x => x.AbrCarr)
            .HasColumnName("abr_carr");
        
        builder.Property(x => x.Turno)
            .HasColumnName("turno");
        
        builder.Property(x => x.NoGrupo)
            .HasColumnName("no_grupo");
        
        builder.Property(x => x.IdPeriodo)
            .HasColumnName("id_periodo");
        
        builder.Property(x => x.NoMateria)
            .HasColumnName("no_materia");
        
        builder.Property(x => x.IdPlan)
            .HasColumnName("id_plan");
        
        builder.Property(x => x.Cupo)
            .HasColumnName("cupo");
        
        builder.Property(x => x.Disponibles)
            .HasColumnName("disponibles");
        
        builder.Property(x => x.Sobrecupo)
            .HasColumnName("sobrecupo");
        
        builder.Property(x => x.LunI)
            .HasColumnName("lun_i");
        
        builder.Property(x => x.LunF)
            .HasColumnName("lun_f");
        
        builder.Property(x => x.MarI)
            .HasColumnName("mar_i");
        
        builder.Property(x => x.MarF)
            .HasColumnName("mar_f");
        
        builder.Property(x => x.MieI)
            .HasColumnName("mie_i");
        
        builder.Property(x => x.MieF)
            .HasColumnName("mie_f");
        
        builder.Property(x => x.JueI)
            .HasColumnName("jue_i");
        
        builder.Property(x => x.JueF)
            .HasColumnName("jue_f");
        
        builder.Property(x => x.VieI)
            .HasColumnName("vie_i");
        
        builder.Property(x => x.VieF)
            .HasColumnName("vie_f");
        
        builder.Property(x => x.Creditos)
            .HasColumnName("creditos");
    }
}