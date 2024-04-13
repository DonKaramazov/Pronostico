using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pronostico.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjoutDesMatchsAuContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Equipes_EquipeDomId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Equipes_EquipeExtId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Journee_JourneeId",
                table: "Match");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Match",
                table: "Match");

            migrationBuilder.RenameTable(
                name: "Match",
                newName: "Matchs");

            migrationBuilder.RenameIndex(
                name: "IX_Match_JourneeId",
                table: "Matchs",
                newName: "IX_Matchs_JourneeId");

            migrationBuilder.RenameIndex(
                name: "IX_Match_EquipeExtId",
                table: "Matchs",
                newName: "IX_Matchs_EquipeExtId");

            migrationBuilder.RenameIndex(
                name: "IX_Match_EquipeDomId",
                table: "Matchs",
                newName: "IX_Matchs_EquipeDomId");

            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Matchs",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matchs",
                table: "Matchs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Matchs_MatchId",
                table: "Matchs",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matchs_Equipes_EquipeDomId",
                table: "Matchs",
                column: "EquipeDomId",
                principalTable: "Equipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Matchs_Equipes_EquipeExtId",
                table: "Matchs",
                column: "EquipeExtId",
                principalTable: "Equipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Matchs_Journee_JourneeId",
                table: "Matchs",
                column: "JourneeId",
                principalTable: "Journee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Matchs_Matchs_MatchId",
                table: "Matchs",
                column: "MatchId",
                principalTable: "Matchs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matchs_Equipes_EquipeDomId",
                table: "Matchs");

            migrationBuilder.DropForeignKey(
                name: "FK_Matchs_Equipes_EquipeExtId",
                table: "Matchs");

            migrationBuilder.DropForeignKey(
                name: "FK_Matchs_Journee_JourneeId",
                table: "Matchs");

            migrationBuilder.DropForeignKey(
                name: "FK_Matchs_Matchs_MatchId",
                table: "Matchs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matchs",
                table: "Matchs");

            migrationBuilder.DropIndex(
                name: "IX_Matchs_MatchId",
                table: "Matchs");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Matchs");

            migrationBuilder.RenameTable(
                name: "Matchs",
                newName: "Match");

            migrationBuilder.RenameIndex(
                name: "IX_Matchs_JourneeId",
                table: "Match",
                newName: "IX_Match_JourneeId");

            migrationBuilder.RenameIndex(
                name: "IX_Matchs_EquipeExtId",
                table: "Match",
                newName: "IX_Match_EquipeExtId");

            migrationBuilder.RenameIndex(
                name: "IX_Matchs_EquipeDomId",
                table: "Match",
                newName: "IX_Match_EquipeDomId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Match",
                table: "Match",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Equipes_EquipeDomId",
                table: "Match",
                column: "EquipeDomId",
                principalTable: "Equipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Equipes_EquipeExtId",
                table: "Match",
                column: "EquipeExtId",
                principalTable: "Equipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Journee_JourneeId",
                table: "Match",
                column: "JourneeId",
                principalTable: "Journee",
                principalColumn: "Id");
        }
    }
}
