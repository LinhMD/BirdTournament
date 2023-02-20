using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdTournament.API.Migrations
{
    public partial class fix_type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Birds_BirdOwers_OwnerId",
                table: "Birds");

            migrationBuilder.DropForeignKey(
                name: "FK_Competitions_Tournaments_TournamentId",
                table: "Competitions");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_BirdOwers_BirdOwerId",
                table: "FeedBack");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_Competitions_CompetitionId",
                table: "FeedBack");

            migrationBuilder.DropForeignKey(
                name: "FK_Participant_BirdOwers_BirdOwerId",
                table: "Participant");

            migrationBuilder.DropForeignKey(
                name: "FK_VipAccounts_BirdOwers_BirdOwerId",
                table: "VipAccounts");

            migrationBuilder.DropTable(
                name: "BirdOwers");

            migrationBuilder.DropTable(
                name: "BirdTournament");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropIndex(
                name: "IX_VipAccounts_BirdOwerId",
                table: "VipAccounts");

            migrationBuilder.DropIndex(
                name: "IX_Participant_BirdOwerId",
                table: "Participant");

            migrationBuilder.DropIndex(
                name: "IX_Competitions_TournamentId",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "TournamentId",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Birds");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Places",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "BirdOwerId",
                table: "Participant",
                newName: "BirhOwnerId");

            migrationBuilder.RenameColumn(
                name: "CompetitionId",
                table: "FeedBack",
                newName: "CompetitionID");

            migrationBuilder.RenameColumn(
                name: "BirdOwerId",
                table: "FeedBack",
                newName: "BirdOwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBack_CompetitionId",
                table: "FeedBack",
                newName: "IX_FeedBack_CompetitionID");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBack_BirdOwerId",
                table: "FeedBack",
                newName: "IX_FeedBack_BirdOwnerId");

            migrationBuilder.AddColumn<int>(
                name: "BirdOwnerId",
                table: "Participant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BirdOwners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    VipAccountId = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirdOwners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BirdOwners_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BirdOwners_VipAccounts_VipAccountId",
                        column: x => x.VipAccountId,
                        principalTable: "VipAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Places_LocationId",
                table: "Places",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Participant_BirdOwnerId",
                table: "Participant",
                column: "BirdOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BirdOwners_UserId",
                table: "BirdOwners",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BirdOwners_VipAccountId",
                table: "BirdOwners",
                column: "VipAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Birds_BirdOwners_OwnerId",
                table: "Birds",
                column: "OwnerId",
                principalTable: "BirdOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_BirdOwners_BirdOwnerId",
                table: "FeedBack",
                column: "BirdOwnerId",
                principalTable: "BirdOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_Competitions_CompetitionID",
                table: "FeedBack",
                column: "CompetitionID",
                principalTable: "Competitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participant_BirdOwners_BirdOwnerId",
                table: "Participant",
                column: "BirdOwnerId",
                principalTable: "BirdOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Region_LocationId",
                table: "Places",
                column: "LocationId",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Birds_BirdOwners_OwnerId",
                table: "Birds");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_BirdOwners_BirdOwnerId",
                table: "FeedBack");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_Competitions_CompetitionID",
                table: "FeedBack");

            migrationBuilder.DropForeignKey(
                name: "FK_Participant_BirdOwners_BirdOwnerId",
                table: "Participant");

            migrationBuilder.DropForeignKey(
                name: "FK_Places_Region_LocationId",
                table: "Places");

            migrationBuilder.DropTable(
                name: "BirdOwners");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropIndex(
                name: "IX_Places_LocationId",
                table: "Places");

            migrationBuilder.DropIndex(
                name: "IX_Participant_BirdOwnerId",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "BirdOwnerId",
                table: "Participant");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Places",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "BirhOwnerId",
                table: "Participant",
                newName: "BirdOwerId");

            migrationBuilder.RenameColumn(
                name: "CompetitionID",
                table: "FeedBack",
                newName: "CompetitionId");

            migrationBuilder.RenameColumn(
                name: "BirdOwnerId",
                table: "FeedBack",
                newName: "BirdOwerId");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBack_CompetitionID",
                table: "FeedBack",
                newName: "IX_FeedBack_CompetitionId");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBack_BirdOwnerId",
                table: "FeedBack",
                newName: "IX_FeedBack_BirdOwerId");

            migrationBuilder.AddColumn<int>(
                name: "TournamentId",
                table: "Competitions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Birds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BirdOwers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirdOwers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BirdOwers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TournamentEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TournamentStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BirdTournament",
                columns: table => new
                {
                    ParticipationBirdsId = table.Column<int>(type: "int", nullable: false),
                    TournamentJoinsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirdTournament", x => new { x.ParticipationBirdsId, x.TournamentJoinsId });
                    table.ForeignKey(
                        name: "FK_BirdTournament_Birds_ParticipationBirdsId",
                        column: x => x.ParticipationBirdsId,
                        principalTable: "Birds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BirdTournament_Tournaments_TournamentJoinsId",
                        column: x => x.TournamentJoinsId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VipAccounts_BirdOwerId",
                table: "VipAccounts",
                column: "BirdOwerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Participant_BirdOwerId",
                table: "Participant",
                column: "BirdOwerId");

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_TournamentId",
                table: "Competitions",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_BirdOwers_UserId",
                table: "BirdOwers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BirdTournament_TournamentJoinsId",
                table: "BirdTournament",
                column: "TournamentJoinsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Birds_BirdOwers_OwnerId",
                table: "Birds",
                column: "OwnerId",
                principalTable: "BirdOwers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Competitions_Tournaments_TournamentId",
                table: "Competitions",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_BirdOwers_BirdOwerId",
                table: "FeedBack",
                column: "BirdOwerId",
                principalTable: "BirdOwers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_Competitions_CompetitionId",
                table: "FeedBack",
                column: "CompetitionId",
                principalTable: "Competitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participant_BirdOwers_BirdOwerId",
                table: "Participant",
                column: "BirdOwerId",
                principalTable: "BirdOwers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VipAccounts_BirdOwers_BirdOwerId",
                table: "VipAccounts",
                column: "BirdOwerId",
                principalTable: "BirdOwers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
