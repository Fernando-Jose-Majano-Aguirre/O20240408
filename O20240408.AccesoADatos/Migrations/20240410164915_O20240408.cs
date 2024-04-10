using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace O20240408.AccesoADatos.Migrations
{
    public partial class O20240408 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personasO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApellidoO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SueldoO = table.Column<double>(type: "float", nullable: false),
                    status = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ComentarioO = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personasO", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personasO");
        }
    }
}
