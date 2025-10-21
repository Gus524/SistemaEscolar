using Common.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.HasOne(a => a.Alumno)
            .WithOne()
            .HasForeignKey<ApplicationUser>(a => a.AlumnoNoBoleta);
        
        builder.HasOne(a => a.Docente)
            .WithOne()
            .HasForeignKey<ApplicationUser>(a => a.DocenteRfc);

        builder.HasOne(a => a.Gestion)
            .WithOne()
            .HasForeignKey<ApplicationUser>(a => a.GestionUsuario);
    }
    
}