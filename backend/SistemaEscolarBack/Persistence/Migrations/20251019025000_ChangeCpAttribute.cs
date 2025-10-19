using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeCpAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "no_plan",
                table: "Plan_Estudios",
                type: "decimal(3)",
                precision: 3,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,30)",
                oldPrecision: 3);

            migrationBuilder.AlterColumn<string>(
                name: "cp",
                table: "Docente",
                type: "longtext",
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,30)",
                oldPrecision: 5)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cp",
                table: "Alumno",
                type: "longtext",
                precision: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,30)",
                oldPrecision: 5)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "no_plan",
                table: "Plan_Estudios",
                type: "decimal(3,30)",
                precision: 3,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3)",
                oldPrecision: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "cp",
                table: "Docente",
                type: "decimal(5,30)",
                precision: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldPrecision: 5)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "cp",
                table: "Alumno",
                type: "decimal(5,30)",
                precision: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldPrecision: 5)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
