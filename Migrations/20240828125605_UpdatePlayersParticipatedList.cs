using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NFL.Persistence.Migrations
{
    public partial class UpdatePlayersParticipatedList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "PlayersParticipating",
            //    table: "Games");

            //migrationBuilder.AddColumn<string>(
            //    name: "PlayersParticipated",
            //    table: "PlayersStats",
            //    type: "longtext",
            //    nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayersParticipated",
                table: "PlayersStats");

            migrationBuilder.AddColumn<string>(
                name: "PlayersParticipating",
                table: "Games",
                type: "longtext",
                nullable: true);
        }
    }
}