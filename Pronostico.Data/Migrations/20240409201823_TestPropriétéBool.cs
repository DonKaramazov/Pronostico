using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pronostico.Data.Migrations
{
    /// <inheritdoc />
    public partial class TestPropriétéBool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMatch2Pts",
                table: "Match",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMatch2Pts",
                table: "Match");
        }
    }
}
