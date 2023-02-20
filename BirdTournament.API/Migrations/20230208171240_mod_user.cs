using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdTournament.API.Migrations
{
    public partial class mod_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Moderators",
                newName: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Moderators_UserId",
                table: "Moderators",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Moderators_Users_UserId",
                table: "Moderators",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moderators_Users_UserId",
                table: "Moderators");

            migrationBuilder.DropIndex(
                name: "IX_Moderators_UserId",
                table: "Moderators");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Moderators",
                newName: "MyProperty");
        }
    }
}
