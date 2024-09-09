using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace NFL.Persistence.Migrations
{
    public partial class AddPlayerStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayersStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    GameDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    Completions = table.Column<int>(type: "int", nullable: false),
                    PassingAttempts = table.Column<int>(type: "int", nullable: false),
                    PassingYards = table.Column<int>(type: "int", nullable: false),
                    CompletionPct = table.Column<double>(type: "double", nullable: false),
                    YardsPerPassAttempt = table.Column<double>(type: "double", nullable: false),
                    PassingTouchdowns = table.Column<int>(type: "int", nullable: false),
                    Interceptions = table.Column<int>(type: "int", nullable: false),
                    LongPassing = table.Column<int>(type: "int", nullable: false),
                    Sacks = table.Column<int>(type: "int", nullable: false),
                    QBRating = table.Column<double>(type: "double", nullable: false),
                    AdjQBR = table.Column<double>(type: "double", nullable: false),
                    RushingAttempts = table.Column<int>(type: "int", nullable: false),
                    RushingYards = table.Column<int>(type: "int", nullable: false),
                    YardsPerRushAttempt = table.Column<double>(type: "double", nullable: false),
                    RushingTouchdowns = table.Column<int>(type: "int", nullable: false),
                    LongRushing = table.Column<int>(type: "int", nullable: false),
                    Receptions = table.Column<int>(type: "int", nullable: false),
                    ReceivingTargets = table.Column<int>(type: "int", nullable: false),
                    ReceivingYards = table.Column<int>(type: "int", nullable: false),
                    YardsPerReception = table.Column<double>(type: "double", nullable: false),
                    ReceivingTouchdowns = table.Column<int>(type: "int", nullable: false),
                    LongReception = table.Column<int>(type: "int", nullable: false),
                    Fumbles = table.Column<int>(type: "int", nullable: false),
                    FumblesLost = table.Column<int>(type: "int", nullable: false),
                    FumblesForced = table.Column<int>(type: "int", nullable: false),
                    KicksBlocked = table.Column<int>(type: "int", nullable: false),
                    TotalTackles = table.Column<int>(type: "int", nullable: false),
                    SoloTackles = table.Column<int>(type: "int", nullable: false),
                    AssistTackles = table.Column<int>(type: "int", nullable: false),
                    Stuffs = table.Column<int>(type: "int", nullable: false),
                    StuffYards = table.Column<int>(type: "int", nullable: false),
                    FumblesRecovered = table.Column<int>(type: "int", nullable: false),
                    InterceptionYards = table.Column<int>(type: "int", nullable: false),
                    AvgInterceptionYards = table.Column<double>(type: "double", nullable: false),
                    InterceptionTouchdowns = table.Column<int>(type: "int", nullable: false),
                    LongInterception = table.Column<int>(type: "int", nullable: false),
                    PassesDefended = table.Column<int>(type: "int", nullable: false),
                    FieldGoalPct = table.Column<double>(type: "double", nullable: false),
                    FieldGoalsMade_FieldGoalAttempts = table.Column<string>(type: "longtext", nullable: false),
                    ExtraPointsMade_ExtraPointAttempts = table.Column<string>(type: "longtext", nullable: false),
                    TotalKickingPoints = table.Column<int>(type: "int", nullable: false),
                    IsHomeGame = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    OpposingTeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayersStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayersStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersStats_PlayerId",
                table: "PlayersStats",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayersStats");
        }
    }
}
