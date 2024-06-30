using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthCite.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoriaMedico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Antecedentes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enfermedad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicacionesActuales = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaMedico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctores_Citas_CitasId",
                        column: x => x.CitasId,
                        principalTable: "Citas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EstadosCitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitaIDId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosCitas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstadosCitas_Citas_CitaIDId",
                        column: x => x.CitaIDId,
                        principalTable: "Citas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HistorialMedicoIDId = table.Column<int>(type: "int", nullable: true),
                    CitasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_Citas_CitasId",
                        column: x => x.CitasId,
                        principalTable: "Citas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pacientes_HistoriaMedico_HistorialMedicoIDId",
                        column: x => x.HistorialMedicoIDId,
                        principalTable: "HistoriaMedico",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuariosIDId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Usuarios_UsuariosIDId",
                        column: x => x.UsuariosIDId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Consultorios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctoresId = table.Column<int>(type: "int", nullable: true),
                    CitasIDId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultorios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultorios_Citas_CitasIDId",
                        column: x => x.CitasIDId,
                        principalTable: "Citas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Consultorios_Doctores_DoctoresId",
                        column: x => x.DoctoresId,
                        principalTable: "Doctores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsultorioIDId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Especialidades_Consultorios_ConsultorioIDId",
                        column: x => x.ConsultorioIDId,
                        principalTable: "Consultorios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consultorios_CitasIDId",
                table: "Consultorios",
                column: "CitasIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultorios_DoctoresId",
                table: "Consultorios",
                column: "DoctoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctores_CitasId",
                table: "Doctores",
                column: "CitasId");

            migrationBuilder.CreateIndex(
                name: "IX_Especialidades_ConsultorioIDId",
                table: "Especialidades",
                column: "ConsultorioIDId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadosCitas_CitaIDId",
                table: "EstadosCitas",
                column: "CitaIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_CitasId",
                table: "Pacientes",
                column: "CitasId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_HistorialMedicoIDId",
                table: "Pacientes",
                column: "HistorialMedicoIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UsuariosIDId",
                table: "Roles",
                column: "UsuariosIDId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "EstadosCitas");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Consultorios");

            migrationBuilder.DropTable(
                name: "HistoriaMedico");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Doctores");

            migrationBuilder.DropTable(
                name: "Citas");
        }
    }
}
