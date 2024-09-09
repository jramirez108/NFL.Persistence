using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NFL.Persistence.Migrations
{
    public partial class ModifyNFLTeamStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "TeamStats",
                type: "longtext",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "TeamStats");
        }
    }
}
