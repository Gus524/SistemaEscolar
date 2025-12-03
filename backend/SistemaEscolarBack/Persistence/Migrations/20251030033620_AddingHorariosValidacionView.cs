using System.Reflection;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddingHorariosValidacionView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            ExecuteSqlScript(migrationBuilder, "Persistence.SqlScripts.Views.GetHorariosValidacion.sql");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS GetHorariosValidacion;");
        }
        private void ExecuteSqlScript(MigrationBuilder migrationBuilder, string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new FileNotFoundException($"No se pudo encontrar el recurso incrustado: {resourceName}");
                }

                using (var reader = new StreamReader(stream))
                {
                    var sql = reader.ReadToEnd();
                    migrationBuilder.Sql(sql);
                }
            }
        }
    }
}
