using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace O20240408.AccesoADatos.Migrations
{
    public partial class O202404081 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_personasO",
                table: "personasO");

            migrationBuilder.RenameTable(
                name: "personasO",
                newName: "Personas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "personasO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personasO",
                table: "personasO",
                column: "Id");
        }
    }
}
