using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Views;

namespace Persistence.Configuration;

public class GetMateriasInscripcionConfig : IEntityTypeConfiguration<GetMateriasReinscripcion>
{
    public void Configure(EntityTypeBuilder<GetMateriasReinscripcion> builder)
    {
        builder
            .HasNoKey()
            .ToView("GetMateriasReinscripcion");
        
        builder.Property(x => x.Carrera)
            .HasMaxLength(3)
            .HasColumnName("abr_carr");
        
        builder.Property(x => x.Grupo)
            .HasMaxLength(10)
            .HasColumnName("grupo");
        
        builder.Property(x => x.Materia)
            .HasMaxLength(100)
            .HasColumnName("nom_materia");
        
        builder.Property(x => x.NoGrupo)
            .HasColumnName("no_grupo");
        
        builder.Property(x => x.NoMateria)
            .HasMaxLength(3)
            .HasColumnName("no_materia");
        
        builder.Property(x => x.NoBoleta)
            .HasColumnName("no_boleta");
        
        builder.Property(x => x.Clave)
            .HasMaxLength(10)
            .HasColumnName("clave");
        
        builder.Property(x => x.Lunes)
            .HasMaxLength(20)
            .HasColumnName("lunes");
        
        builder.Property(x => x.Martes)
            .HasMaxLength(20)
            .HasColumnName("martes");
        
        builder.Property(x => x.Miercoles)
            .HasMaxLength(20)
            .HasColumnName("miercoles");
        
        builder.Property(x => x.Jueves)
            .HasMaxLength(20)
            .HasColumnName("jueves");
        
        builder.Property(x => x.Viernes)
            .HasMaxLength(20)
            .HasColumnName("viernes");
        
        builder.Property(x => x.Cupo)
            .HasColumnName("cupo");
        
        builder.Property(x => x.Semestre)
            .HasColumnName("semestre");
        
        builder.Property(x => x.Turno)
            .HasMaxLength(1)
            .HasColumnName("turno");
        
        builder.Property(x => x.Disponibles)
            .HasColumnName("disponibles");
    }
    
}