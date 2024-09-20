using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NFL.Persistence.Migrations
{
    public partial class AddShareValueToStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 2023);

            migrationBuilder.AddColumn<double>(
                name: "ReceivingShare",
                table: "PlayersStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "RushingShare",
                table: "PlayersStats",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "ReceivingShare",
                table: "PlayersStats");

            migrationBuilder.DropColumn(
                name: "RushingShare",
                table: "PlayersStats");
        }
    }
}