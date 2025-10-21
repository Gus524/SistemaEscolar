using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialBaseline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    no_boleta = table.Column<long>(type: "bigint", nullable: false),
                    nom_al = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ap_al = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    am_al = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    curp = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_p_alumno = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_i_alumno = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telf_alumno = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telm_alumno = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    calle = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    no_ext = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    no_int = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    colonia = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delegacion = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cp = table.Column<decimal>(type: "decimal(5)", precision: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.no_boleta);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Institucion",
                columns: table => new
                {
                    id_inst = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nom_inst = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    abreviatura = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_inst);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Periodo_Escolar",
                columns: table => new
                {
                    id_periodo = table.Column<int>(type: "int", nullable: false),
                    desc_periodo = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fecha_inicio = table.Column<DateOnly>(type: "date", nullable: true),
                    fecha_fin = table.Column<DateOnly>(type: "date", nullable: true),
                    activo = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_periodo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tramite",
                columns: table => new
                {
                    id_tramite = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipo_tramite = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    no_boleta = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_tramite);
                    table.ForeignKey(
                        name: "Tramite_ibfk_1",
                        column: x => x.no_boleta,
                        principalTable: "Alumno",
                        principalColumn: "no_boleta");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Carrera",
                columns: table => new
                {
                    abr_carr = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    desc_carr = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    no_sem = table.Column<int>(type: "int", nullable: false),
                    max_semestres = table.Column<int>(type: "int", nullable: true),
                    id_inst = table.Column<int>(type: "int", nullable: false),
                    cred_total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.abr_carr);
                    table.ForeignKey(
                        name: "Carrera_ibfk_1",
                        column: x => x.id_inst,
                        principalTable: "Institucion",
                        principalColumn: "id_inst");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Edificio",
                columns: table => new
                {
                    id_edificio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    desc_edificio = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    abr_edificio = table.Column<string>(type: "char(3)", fixedLength: true, maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_inst = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_edificio);
                    table.ForeignKey(
                        name: "Edificio_ibfk_1",
                        column: x => x.id_inst,
                        principalTable: "Institucion",
                        principalColumn: "id_inst");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Gestion",
                columns: table => new
                {
                    usuario = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_inst = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "Gestion_ibfk_1",
                        column: x => x.id_inst,
                        principalTable: "Institucion",
                        principalColumn: "id_inst");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    semestre = table.Column<int>(type: "int", nullable: false),
                    abr_carr = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_plan = table.Column<int>(type: "int", nullable: false),
                    turno = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    no_grupo = table.Column<int>(type: "int", nullable: false),
                    id_periodo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.id_periodo, x.abr_carr, x.id_plan, x.semestre, x.turno, x.no_grupo })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });
                    table.ForeignKey(
                        name: "Grupo_ibfk_1",
                        column: x => x.abr_carr,
                        principalTable: "Carrera",
                        principalColumn: "abr_carr");
                    table.ForeignKey(
                        name: "Grupo_ibfk_2",
                        column: x => x.id_periodo,
                        principalTable: "Periodo_Escolar",
                        principalColumn: "id_periodo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Plan_Estudios",
                columns: table => new
                {
                    id_plan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    desc_plan = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    no_plan = table.Column<decimal>(type: "decimal(3)", precision: 3, nullable: false),
                    abr_carr = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_plan);
                    table.ForeignKey(
                        name: "Plan_Estudios_ibfk_1",
                        column: x => x.abr_carr,
                        principalTable: "Carrera",
                        principalColumn: "abr_carr");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Academia",
                columns: table => new
                {
                    id_academia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nom_academia = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_edificio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_academia);
                    table.ForeignKey(
                        name: "Academia_ibfk_1",
                        column: x => x.id_edificio,
                        principalTable: "Edificio",
                        principalColumn: "id_edificio");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "Historial_Academico",
                columns: table => new
                {
                    no_boleta = table.Column<long>(type: "bigint", nullable: false),
                    id_plan = table.Column<int>(type: "int", nullable: false),
                    promedio = table.Column<float>(type: "float", nullable: true, defaultValueSql: "'0'"),
                    ultimo_semestre = table.Column<int>(type: "int", nullable: true, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.no_boleta, x.id_plan })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "Historial_Academico_ibfk_1",
                        column: x => x.no_boleta,
                        principalTable: "Alumno",
                        principalColumn: "no_boleta");
                    table.ForeignKey(
                        name: "Historial_Academico_ibfk_2",
                        column: x => x.id_plan,
                        principalTable: "Plan_Estudios",
                        principalColumn: "id_plan");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Docente",
                columns: table => new
                {
                    rfc = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_academia = table.Column<int>(type: "int", nullable: false),
                    nom_doc = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ap_doc = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    am_doc = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_p_doc = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_i_doc = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tel_doc = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    calle = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    no_ext = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    no_int = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    colonia = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    delegacion = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cp = table.Column<decimal>(type: "decimal(5)", precision: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.rfc);
                    table.ForeignKey(
                        name: "Docente_ibfk_1",
                        column: x => x.id_academia,
                        principalTable: "Academia",
                        principalColumn: "id_academia");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    id_materia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipo_materia = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nom_materia = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    horas_teoria = table.Column<int>(type: "int", nullable: false),
                    horas_prac = table.Column<int>(type: "int", nullable: false),
                    id_academia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_materia);
                    table.ForeignKey(
                        name: "Materia_ibfk_1",
                        column: x => x.id_academia,
                        principalTable: "Academia",
                        principalColumn: "id_academia");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inscripcion",
                columns: table => new
                {
                    no_boleta = table.Column<long>(type: "bigint", nullable: false),
                    id_periodo = table.Column<int>(type: "int", nullable: false),
                    id_plan = table.Column<int>(type: "int", nullable: false),
                    fecha_inscripcion = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.no_boleta, x.id_periodo, x.id_plan })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                    table.ForeignKey(
                        name: "Inscripcion_ibfk_1",
                        columns: x => new { x.no_boleta, x.id_plan },
                        principalTable: "Historial_Academico",
                        principalColumns: new[] { "no_boleta", "id_plan" });
                    table.ForeignKey(
                        name: "Inscripcion_ibfk_2",
                        column: x => x.id_periodo,
                        principalTable: "Periodo_Escolar",
                        principalColumn: "id_periodo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Trayectoria_Alumno",
                columns: table => new
                {
                    per_cursados = table.Column<int>(type: "int", nullable: true, defaultValueSql: "'0'"),
                    per_disponibles = table.Column<int>(type: "int", nullable: true),
                    cred_permitidos = table.Column<float>(type: "float", nullable: true, defaultValueSql: "'0'"),
                    cred_faltantes = table.Column<float>(type: "float", nullable: true),
                    cred_obtenidos = table.Column<float>(type: "float", nullable: true, defaultValueSql: "'0'"),
                    no_boleta = table.Column<long>(type: "bigint", nullable: true),
                    id_plan = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "Trayectoria_Alumno_ibfk_1",
                        columns: x => new { x.no_boleta, x.id_plan },
                        principalTable: "Historial_Academico",
                        principalColumns: new[] { "no_boleta", "id_plan" });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mapa_Curricular",
                columns: table => new
                {
                    abr_carr = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_plan = table.Column<int>(type: "int", nullable: false),
                    semestre = table.Column<int>(type: "int", nullable: false),
                    no_materia = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_materia = table.Column<int>(type: "int", nullable: false),
                    creditos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.id_plan, x.abr_carr, x.semestre, x.no_materia })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
                    table.ForeignKey(
                        name: "Mapa_Curricular_ibfk_1",
                        column: x => x.id_plan,
                        principalTable: "Plan_Estudios",
                        principalColumn: "id_plan");
                    table.ForeignKey(
                        name: "Mapa_Curricular_ibfk_2",
                        column: x => x.id_materia,
                        principalTable: "Materia",
                        principalColumn: "id_materia");
                    table.ForeignKey(
                        name: "Mapa_Curricular_ibfk_3",
                        column: x => x.abr_carr,
                        principalTable: "Carrera",
                        principalColumn: "abr_carr");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estado_General",
                columns: table => new
                {
                    estado = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, defaultValueSql: "'NO CURSADA'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    no_boleta = table.Column<long>(type: "bigint", nullable: true),
                    abr_carr = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    semestre = table.Column<int>(type: "int", nullable: false),
                    id_plan = table.Column<int>(type: "int", nullable: false),
                    no_materia = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "Estado_General_ibfk_1",
                        columns: x => new { x.no_boleta, x.id_plan },
                        principalTable: "Historial_Academico",
                        principalColumns: new[] { "no_boleta", "id_plan" });
                    table.ForeignKey(
                        name: "Estado_General_ibfk_2",
                        columns: x => new { x.id_plan, x.abr_carr, x.semestre, x.no_materia },
                        principalTable: "Mapa_Curricular",
                        principalColumns: new[] { "id_plan", "abr_carr", "semestre", "no_materia" });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ETS",
                columns: table => new
                {
                    abr_carr = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_plan = table.Column<int>(type: "int", nullable: false),
                    turno = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    semestre = table.Column<int>(type: "int", nullable: false),
                    no_materia = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_periodo = table.Column<int>(type: "int", nullable: false),
                    ronda = table.Column<int>(type: "int", nullable: false),
                    rfc = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dia = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hora_i = table.Column<TimeOnly>(type: "time", nullable: true),
                    hora_fin = table.Column<TimeOnly>(type: "time", nullable: true),
                    salon = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.id_periodo, x.abr_carr, x.id_plan, x.ronda, x.semestre, x.turno, x.no_materia })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });
                    table.ForeignKey(
                        name: "ETS_ibfk_1",
                        column: x => x.rfc,
                        principalTable: "Docente",
                        principalColumn: "rfc");
                    table.ForeignKey(
                        name: "ETS_ibfk_2",
                        column: x => x.id_periodo,
                        principalTable: "Periodo_Escolar",
                        principalColumn: "id_periodo");
                    table.ForeignKey(
                        name: "ETS_ibfk_3",
                        columns: x => new { x.id_plan, x.abr_carr, x.semestre, x.no_materia },
                        principalTable: "Mapa_Curricular",
                        principalColumns: new[] { "id_plan", "abr_carr", "semestre", "no_materia" });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Grupo_Horario",
                columns: table => new
                {
                    semestre = table.Column<int>(type: "int", nullable: false),
                    abr_carr = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    turno = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    no_grupo = table.Column<int>(type: "int", nullable: false),
                    id_periodo = table.Column<int>(type: "int", nullable: false),
                    no_materia = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_plan = table.Column<int>(type: "int", nullable: false),
                    cupo = table.Column<int>(type: "int", nullable: true, defaultValueSql: "'40'"),
                    disponibles = table.Column<int>(type: "int", nullable: true, defaultValueSql: "'40'"),
                    sobrecupo = table.Column<int>(type: "int", nullable: true, defaultValueSql: "'0'"),
                    inscritos = table.Column<int>(type: "int", nullable: true, defaultValueSql: "'0'"),
                    lun_i = table.Column<TimeOnly>(type: "time", nullable: true),
                    lun_f = table.Column<TimeOnly>(type: "time", nullable: true),
                    lun_sal = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mar_i = table.Column<TimeOnly>(type: "time", nullable: true),
                    mar_f = table.Column<TimeOnly>(type: "time", nullable: true),
                    mar_sal = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mie_i = table.Column<TimeOnly>(type: "time", nullable: true),
                    mie_f = table.Column<TimeOnly>(type: "time", nullable: true),
                    mie_sal = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jue_i = table.Column<TimeOnly>(type: "time", nullable: true),
                    jue_f = table.Column<TimeOnly>(type: "time", nullable: true),
                    jue_sal = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vie_i = table.Column<TimeOnly>(type: "time", nullable: true),
                    vie_f = table.Column<TimeOnly>(type: "time", nullable: true),
                    vie_sal = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.id_periodo, x.abr_carr, x.id_plan, x.semestre, x.turno, x.no_grupo, x.no_materia })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });
                    table.ForeignKey(
                        name: "Grupo_Horario_ibfk_1",
                        columns: x => new { x.id_periodo, x.abr_carr, x.id_plan, x.semestre, x.turno, x.no_grupo },
                        principalTable: "Grupo",
                        principalColumns: new[] { "id_periodo", "abr_carr", "id_plan", "semestre", "turno", "no_grupo" });
                    table.ForeignKey(
                        name: "Grupo_Horario_ibfk_2",
                        columns: x => new { x.id_plan, x.abr_carr, x.semestre, x.no_materia },
                        principalTable: "Mapa_Curricular",
                        principalColumns: new[] { "id_plan", "abr_carr", "semestre", "no_materia" });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Historial_Detalle",
                columns: table => new
                {
                    no_boleta = table.Column<long>(type: "bigint", nullable: false),
                    id_plan = table.Column<int>(type: "int", nullable: false),
                    semestre = table.Column<int>(type: "int", nullable: false),
                    no_materia = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    calificacion = table.Column<int>(type: "int", nullable: false),
                    forma_eval = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fecha_eval = table.Column<DateOnly>(type: "date", nullable: false),
                    id_periodo = table.Column<int>(type: "int", nullable: false),
                    abr_carr = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.no_boleta, x.id_plan, x.semestre, x.no_materia })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
                    table.ForeignKey(
                        name: "Historial_Detalle_ibfk_1",
                        column: x => x.id_periodo,
                        principalTable: "Periodo_Escolar",
                        principalColumn: "id_periodo");
                    table.ForeignKey(
                        name: "Historial_Detalle_ibfk_2",
                        columns: x => new { x.no_boleta, x.id_plan },
                        principalTable: "Historial_Academico",
                        principalColumns: new[] { "no_boleta", "id_plan" });
                    table.ForeignKey(
                        name: "Historial_Detalle_ibfk_3",
                        columns: x => new { x.id_plan, x.abr_carr, x.semestre, x.no_materia },
                        principalTable: "Mapa_Curricular",
                        principalColumns: new[] { "id_plan", "abr_carr", "semestre", "no_materia" });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Alumno_ETS",
                columns: table => new
                {
                    calificacion = table.Column<int>(type: "int", nullable: true),
                    no_boleta = table.Column<long>(type: "bigint", nullable: true),
                    abr_carr = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_plan = table.Column<int>(type: "int", nullable: true),
                    turno = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    semestre = table.Column<int>(type: "int", nullable: true),
                    no_materia = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_periodo = table.Column<int>(type: "int", nullable: true),
                    ronda = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "Alumno_ETS_ibfk_1",
                        column: x => x.no_boleta,
                        principalTable: "Alumno",
                        principalColumn: "no_boleta");
                    table.ForeignKey(
                        name: "Alumno_ETS_ibfk_2",
                        columns: x => new { x.id_periodo, x.abr_carr, x.id_plan, x.ronda, x.semestre, x.turno, x.no_materia },
                        principalTable: "ETS",
                        principalColumns: new[] { "id_periodo", "abr_carr", "id_plan", "ronda", "semestre", "turno", "no_materia" });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Docente_Horario",
                columns: table => new
                {
                    rfc = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    semestre = table.Column<int>(type: "int", nullable: false),
                    abr_carr = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_plan = table.Column<int>(type: "int", nullable: false),
                    turno = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    no_grupo = table.Column<int>(type: "int", nullable: false),
                    id_periodo = table.Column<int>(type: "int", nullable: false),
                    no_materia = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "Docente_Horario_ibfk_1",
                        column: x => x.rfc,
                        principalTable: "Docente",
                        principalColumn: "rfc");
                    table.ForeignKey(
                        name: "Docente_Horario_ibfk_2",
                        columns: x => new { x.id_periodo, x.abr_carr, x.id_plan, x.semestre, x.turno, x.no_grupo, x.no_materia },
                        principalTable: "Grupo_Horario",
                        principalColumns: new[] { "id_periodo", "abr_carr", "id_plan", "semestre", "turno", "no_grupo", "no_materia" });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inscripcion_Detalle",
                columns: table => new
                {
                    no_boleta = table.Column<long>(type: "bigint", nullable: false),
                    semestre = table.Column<int>(type: "int", nullable: false),
                    abr_carr = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    turno = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    no_grupo = table.Column<int>(type: "int", nullable: false),
                    id_periodo = table.Column<int>(type: "int", nullable: false),
                    no_materia = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_plan = table.Column<int>(type: "int", nullable: false),
                    cal_parcial_1 = table.Column<int>(type: "int", nullable: true),
                    cal_parcial_2 = table.Column<int>(type: "int", nullable: true),
                    cal_parcial_3 = table.Column<int>(type: "int", nullable: true),
                    cal_extra = table.Column<int>(type: "int", nullable: true),
                    cal_final = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.no_boleta, x.id_periodo, x.id_plan, x.abr_carr, x.semestre, x.turno, x.no_grupo, x.no_materia })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });
                    table.ForeignKey(
                        name: "Inscripcion_Detalle_ibfk_1",
                        columns: x => new { x.no_boleta, x.id_periodo, x.id_plan },
                        principalTable: "Inscripcion",
                        principalColumns: new[] { "no_boleta", "id_periodo", "id_plan" });
                    table.ForeignKey(
                        name: "Inscripcion_Detalle_ibfk_2",
                        columns: x => new { x.id_periodo, x.abr_carr, x.id_plan, x.semestre, x.turno, x.no_grupo, x.no_materia },
                        principalTable: "Grupo_Horario",
                        principalColumns: new[] { "id_periodo", "abr_carr", "id_plan", "semestre", "turno", "no_grupo", "no_materia" });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "id_edificio",
                table: "Academia",
                column: "id_edificio");

            migrationBuilder.CreateIndex(
                name: "id_periodo",
                table: "Alumno_ETS",
                columns: new[] { "id_periodo", "abr_carr", "id_plan", "ronda", "semestre", "turno", "no_materia" });

            migrationBuilder.CreateIndex(
                name: "no_boleta",
                table: "Alumno_ETS",
                column: "no_boleta");

            migrationBuilder.CreateIndex(
                name: "id_inst",
                table: "Carrera",
                column: "id_inst");

            migrationBuilder.CreateIndex(
                name: "id_academia",
                table: "Docente",
                column: "id_academia");

            migrationBuilder.CreateIndex(
                name: "id_periodo",
                table: "Docente_Horario",
                columns: new[] { "id_periodo", "abr_carr", "id_plan", "semestre", "turno", "no_grupo", "no_materia" });

            migrationBuilder.CreateIndex(
                name: "rfc",
                table: "Docente_Horario",
                column: "rfc");

            migrationBuilder.CreateIndex(
                name: "id_inst1",
                table: "Edificio",
                column: "id_inst");

            migrationBuilder.CreateIndex(
                name: "id_plan",
                table: "Estado_General",
                columns: new[] { "id_plan", "abr_carr", "semestre", "no_materia" });

            migrationBuilder.CreateIndex(
                name: "no_boleta",
                table: "Estado_General",
                columns: new[] { "no_boleta", "id_plan" });

            migrationBuilder.CreateIndex(
                name: "id_plan",
                table: "ETS",
                columns: new[] { "id_plan", "abr_carr", "semestre", "no_materia" });

            migrationBuilder.CreateIndex(
                name: "rfc",
                table: "ETS",
                column: "rfc");

            migrationBuilder.CreateIndex(
                name: "id_inst",
                table: "Gestion",
                column: "id_inst");

            migrationBuilder.CreateIndex(
                name: "abr_carr",
                table: "Grupo",
                column: "abr_carr");

            migrationBuilder.CreateIndex(
                name: "id_plan1",
                table: "Grupo_Horario",
                columns: new[] { "id_plan", "abr_carr", "semestre", "no_materia" });

            migrationBuilder.CreateIndex(
                name: "id_plan2",
                table: "Historial_Academico",
                column: "id_plan");

            migrationBuilder.CreateIndex(
                name: "id_periodo",
                table: "Historial_Detalle",
                column: "id_periodo");

            migrationBuilder.CreateIndex(
                name: "id_plan3",
                table: "Historial_Detalle",
                columns: new[] { "id_plan", "abr_carr", "semestre", "no_materia" });

            migrationBuilder.CreateIndex(
                name: "id_periodo1",
                table: "Inscripcion",
                column: "id_periodo");

            migrationBuilder.CreateIndex(
                name: "no_boleta",
                table: "Inscripcion",
                columns: new[] { "no_boleta", "id_plan" });

            migrationBuilder.CreateIndex(
                name: "id_periodo2",
                table: "Inscripcion_Detalle",
                columns: new[] { "id_periodo", "abr_carr", "id_plan", "semestre", "turno", "no_grupo", "no_materia" });

            migrationBuilder.CreateIndex(
                name: "abreviatura",
                table: "Institucion",
                column: "abreviatura",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "nom_inst",
                table: "Institucion",
                column: "nom_inst",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "abr_carr1",
                table: "Mapa_Curricular",
                column: "abr_carr");

            migrationBuilder.CreateIndex(
                name: "id_materia",
                table: "Mapa_Curricular",
                column: "id_materia");

            migrationBuilder.CreateIndex(
                name: "id_academia1",
                table: "Materia",
                column: "id_academia");

            migrationBuilder.CreateIndex(
                name: "abr_carr2",
                table: "Plan_Estudios",
                column: "abr_carr");

            migrationBuilder.CreateIndex(
                name: "no_boleta1",
                table: "Tramite",
                column: "no_boleta");

            migrationBuilder.CreateIndex(
                name: "no_boleta",
                table: "Trayectoria_Alumno",
                columns: new[] { "no_boleta", "id_plan" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumno_ETS");

            migrationBuilder.DropTable(
                name: "Docente_Horario");

            migrationBuilder.DropTable(
                name: "Estado_General");

            migrationBuilder.DropTable(
                name: "Gestion");

            migrationBuilder.DropTable(
                name: "Historial_Detalle");

            migrationBuilder.DropTable(
                name: "Inscripcion_Detalle");

            migrationBuilder.DropTable(
                name: "Tramite");

            migrationBuilder.DropTable(
                name: "Trayectoria_Alumno");

            migrationBuilder.DropTable(
                name: "ETS");

            migrationBuilder.DropTable(
                name: "Inscripcion");

            migrationBuilder.DropTable(
                name: "Grupo_Horario");

            migrationBuilder.DropTable(
                name: "Docente");

            migrationBuilder.DropTable(
                name: "Historial_Academico");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "Mapa_Curricular");

            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "Periodo_Escolar");

            migrationBuilder.DropTable(
                name: "Plan_Estudios");

            migrationBuilder.DropTable(
                name: "Materia");

            migrationBuilder.DropTable(
                name: "Carrera");

            migrationBuilder.DropTable(
                name: "Academia");

            migrationBuilder.DropTable(
                name: "Edificio");

            migrationBuilder.DropTable(
                name: "Institucion");
        }
    }
}
