using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FixingRelationsTrayectoriaHistorial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Estado_General_ibfk_1",
                table: "Estado_General");

            migrationBuilder.DropForeignKey(
                name: "Trayectoria_Alumno_ibfk_1",
                table: "Trayectoria_Alumno");

            migrationBuilder.RenameIndex(
                name: "no_boleta",
                table: "Trayectoria_Alumno",
                newName: "no_boleta3");

            migrationBuilder.RenameIndex(
                name: "no_boleta1",
                table: "Tramite",
                newName: "no_boleta2");

            migrationBuilder.RenameIndex(
                name: "no_boleta",
                table: "Inscripcion",
                newName: "no_boleta1");

            migrationBuilder.RenameIndex(
                name: "id_plan3",
                table: "Historial_Detalle",
                newName: "id_plan4");

            migrationBuilder.RenameIndex(
                name: "id_plan2",
                table: "Historial_Academico",
                newName: "id_plan3");

            migrationBuilder.RenameIndex(
                name: "id_plan1",
                table: "Grupo_Horario",
                newName: "id_plan2");

            migrationBuilder.RenameIndex(
                name: "id_plan",
                table: "ETS",
                newName: "id_plan1");

            migrationBuilder.AlterColumn<long>(
                name: "no_boleta",
                table: "Trayectoria_Alumno",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_plan",
                table: "Trayectoria_Alumno",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "estado_historial",
                table: "Historial_Academico",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AlterColumn<long>(
                name: "no_boleta",
                table: "Estado_General",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trayectoria_Alumno",
                table: "Trayectoria_Alumno",
                columns: new[] { "no_boleta", "id_plan" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estado_General",
                table: "Estado_General",
                columns: new[] { "no_boleta", "id_plan", "abr_carr", "semestre", "no_materia" });

            migrationBuilder.AddForeignKey(
                name: "Estado_General_ibfk_1",
                table: "Estado_General",
                columns: new[] { "no_boleta", "id_plan" },
                principalTable: "Historial_Academico",
                principalColumns: new[] { "no_boleta", "id_plan" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trayectoria_HistorialAcademico",
                table: "Trayectoria_Alumno",
                columns: new[] { "no_boleta", "id_plan" },
                principalTable: "Historial_Academico",
                principalColumns: new[] { "no_boleta", "id_plan" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Estado_General_ibfk_1",
                table: "Estado_General");

            migrationBuilder.DropForeignKey(
                name: "FK_Trayectoria_HistorialAcademico",
                table: "Trayectoria_Alumno");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trayectoria_Alumno",
                table: "Trayectoria_Alumno");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estado_General",
                table: "Estado_General");

            migrationBuilder.DropColumn(
                name: "estado_historial",
                table: "Historial_Academico");

            migrationBuilder.RenameIndex(
                name: "no_boleta3",
                table: "Trayectoria_Alumno",
                newName: "no_boleta");

            migrationBuilder.RenameIndex(
                name: "no_boleta2",
                table: "Tramite",
                newName: "no_boleta1");

            migrationBuilder.RenameIndex(
                name: "no_boleta1",
                table: "Inscripcion",
                newName: "no_boleta");

            migrationBuilder.RenameIndex(
                name: "id_plan4",
                table: "Historial_Detalle",
                newName: "id_plan3");

            migrationBuilder.RenameIndex(
                name: "id_plan3",
                table: "Historial_Academico",
                newName: "id_plan2");

            migrationBuilder.RenameIndex(
                name: "id_plan2",
                table: "Grupo_Horario",
                newName: "id_plan1");

            migrationBuilder.RenameIndex(
                name: "id_plan1",
                table: "ETS",
                newName: "id_plan");

            migrationBuilder.AlterColumn<int>(
                name: "id_plan",
                table: "Trayectoria_Alumno",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "no_boleta",
                table: "Trayectoria_Alumno",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "no_boleta",
                table: "Estado_General",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "Estado_General_ibfk_1",
                table: "Estado_General",
                columns: new[] { "no_boleta", "id_plan" },
                principalTable: "Historial_Academico",
                principalColumns: new[] { "no_boleta", "id_plan" });

            migrationBuilder.AddForeignKey(
                name: "Trayectoria_Alumno_ibfk_1",
                table: "Trayectoria_Alumno",
                columns: new[] { "no_boleta", "id_plan" },
                principalTable: "Historial_Academico",
                principalColumns: new[] { "no_boleta", "id_plan" });
        }
    }
}
