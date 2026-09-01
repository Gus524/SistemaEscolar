using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DetectPendingModelChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "no_plan",
                table: "Plan_Estudios",
                type: "decimal(3,0)",
                precision: 3,
                scale: 0,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,30)",
                oldPrecision: 3);
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
                oldType: "decimal(3,0)",
                oldPrecision: 3,
                oldScale: 0);
        }
    }
}
