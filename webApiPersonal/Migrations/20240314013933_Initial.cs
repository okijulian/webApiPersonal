using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webApiPersonal.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Legajo = table.Column<long>(type: "bigint", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<long>(type: "bigint", nullable: false),
                    Cuil = table.Column<long>(type: "bigint", nullable: false),
                    Telefono = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObraSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fkReloj = table.Column<int>(type: "int", nullable: false),
                    fkTipoHorario = table.Column<int>(type: "int", nullable: false),
                    fkGrupo = table.Column<int>(type: "int", nullable: false),
                    fkArea = table.Column<int>(type: "int", nullable: false),
                    fkCategoria = table.Column<int>(type: "int", nullable: false),
                    noche = table.Column<bool>(type: "bit", nullable: false),
                    extras = table.Column<bool>(type: "bit", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    baja = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
