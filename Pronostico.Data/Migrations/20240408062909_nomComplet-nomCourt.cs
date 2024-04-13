using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pronostico.Data.Migrations
{
    /// <inheritdoc />
    public partial class nomCompletnomCourt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Equipes",
                newName: "NomCourt");

            migrationBuilder.AddColumn<string>(
                name: "NomComplet",
                table: "Equipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomComplet",
                table: "Equipes");

            migrationBuilder.RenameColumn(
                name: "NomCourt",
                table: "Equipes",
                newName: "Nom");
        }
    }
}
