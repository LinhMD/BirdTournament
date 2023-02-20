using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirdTournament.API.Migrations
{
    public partial class base_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "VipFeatures",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "VipFeatures",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "VipFeatures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "VipFeatures",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "VipAccounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "VipAccounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "VipAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "VipAccounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Tournaments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "Tournaments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Tournaments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Tournaments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Ranks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "Ranks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Ranks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Ranks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Places",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "Places",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Places",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Places",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Participant",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "Participant",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Participant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Participant",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Moderators",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "Moderators",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Moderators",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Moderators",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "FeedBack",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "FeedBack",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "FeedBack",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "FeedBack",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Competitions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "Competitions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Competitions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Competitions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Comments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "Comments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Comments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "BirdType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "BirdType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "BirdType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "BirdType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Birds",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "Birds",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Birds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Birds",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "BirdOwers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "BirdOwers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "BirdOwers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "BirdOwers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Articles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "Articles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Articles",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "VipFeatures");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "VipFeatures");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "VipFeatures");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "VipFeatures");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "VipAccounts");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "VipAccounts");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "VipAccounts");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "VipAccounts");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Ranks");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "Ranks");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Ranks");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Ranks");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Moderators");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "Moderators");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Moderators");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Moderators");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "FeedBack");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "FeedBack");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "FeedBack");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "FeedBack");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "BirdType");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "BirdType");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "BirdType");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "BirdType");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Birds");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "Birds");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Birds");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Birds");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "BirdOwers");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "BirdOwers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "BirdOwers");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "BirdOwers");

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Articles");
        }
    }
}
