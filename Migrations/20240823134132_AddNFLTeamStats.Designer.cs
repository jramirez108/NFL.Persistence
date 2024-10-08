﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NFL.Persistence;

#nullable disable

namespace NFL.Persistence.Migrations
{
    [DbContext(typeof(NFLDbContext))]
    [Migration("20240823134132_AddNFLTeamStats")]
    partial class AddNFLTeamStats
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NFL.Persistence.Models.NFLGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("GameDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("GameOverOdds")
                        .HasColumnType("longtext");

                    b.Property<float?>("GameRunLine")
                        .HasColumnType("float");

                    b.Property<string>("GameUnderOdds")
                        .HasColumnType("longtext");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<string>("HomeTeamOdds")
                        .HasColumnType("longtext");

                    b.Property<string>("HomeTeamSpreadLine")
                        .HasColumnType("longtext");

                    b.Property<string>("HomeTeamSpreadOdds")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PlayersParticipating")
                        .HasColumnType("longtext");

                    b.Property<int>("VisitorTeamId")
                        .HasColumnType("int");

                    b.Property<string>("VisitorTeamOdds")
                        .HasColumnType("longtext");

                    b.Property<string>("VisitorTeamSpreadLine")
                        .HasColumnType("longtext");

                    b.Property<string>("VisitorTeamSpreadOdds")
                        .HasColumnType("longtext");

                    b.Property<int>("WeekId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("VisitorTeamId");

                    b.HasIndex("WeekId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("NFL.Persistence.Models.NFLPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("JerseyNumber")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PositionAbbreviation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PositionGroup")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("NFL.Persistence.Models.NFLPlayerOdds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Line")
                        .HasColumnType("double");

                    b.Property<string>("Over")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Under")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayerOdds");
                });

            modelBuilder.Entity("NFL.Persistence.Models.NFLPlayerStat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("AdjQBR")
                        .HasColumnType("double");

                    b.Property<int>("AssistTackles")
                        .HasColumnType("int");

                    b.Property<double>("AvgInterceptionYards")
                        .HasColumnType("double");

                    b.Property<double>("CompletionPct")
                        .HasColumnType("double");

                    b.Property<int>("Completions")
                        .HasColumnType("int");

                    b.Property<string>("ExtraPointsMade_ExtraPointAttempts")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("FieldGoalPct")
                        .HasColumnType("double");

                    b.Property<string>("FieldGoalsMade_FieldGoalAttempts")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Fumbles")
                        .HasColumnType("int");

                    b.Property<int>("FumblesForced")
                        .HasColumnType("int");

                    b.Property<int>("FumblesLost")
                        .HasColumnType("int");

                    b.Property<int>("FumblesRecovered")
                        .HasColumnType("int");

                    b.Property<DateTime>("GameDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("InterceptionTouchdowns")
                        .HasColumnType("int");

                    b.Property<int>("InterceptionYards")
                        .HasColumnType("int");

                    b.Property<int>("Interceptions")
                        .HasColumnType("int");

                    b.Property<bool>("IsHomeGame")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsWin")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("KicksBlocked")
                        .HasColumnType("int");

                    b.Property<int>("LongInterception")
                        .HasColumnType("int");

                    b.Property<int>("LongPassing")
                        .HasColumnType("int");

                    b.Property<int>("LongReception")
                        .HasColumnType("int");

                    b.Property<int>("LongRushing")
                        .HasColumnType("int");

                    b.Property<int>("OpposingTeamId")
                        .HasColumnType("int");

                    b.Property<int>("PassesDefended")
                        .HasColumnType("int");

                    b.Property<int>("PassingAttempts")
                        .HasColumnType("int");

                    b.Property<int>("PassingTouchdowns")
                        .HasColumnType("int");

                    b.Property<int>("PassingYards")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<double>("QBRating")
                        .HasColumnType("double");

                    b.Property<int>("ReceivingTargets")
                        .HasColumnType("int");

                    b.Property<int>("ReceivingTouchdowns")
                        .HasColumnType("int");

                    b.Property<int>("ReceivingYards")
                        .HasColumnType("int");

                    b.Property<int>("Receptions")
                        .HasColumnType("int");

                    b.Property<int>("RushingAttempts")
                        .HasColumnType("int");

                    b.Property<int>("RushingTouchdowns")
                        .HasColumnType("int");

                    b.Property<int>("RushingYards")
                        .HasColumnType("int");

                    b.Property<int>("Sacks")
                        .HasColumnType("int");

                    b.Property<int>("SoloTackles")
                        .HasColumnType("int");

                    b.Property<int>("StuffYards")
                        .HasColumnType("int");

                    b.Property<int>("Stuffs")
                        .HasColumnType("int");

                    b.Property<int>("TotalKickingPoints")
                        .HasColumnType("int");

                    b.Property<int>("TotalTackles")
                        .HasColumnType("int");

                    b.Property<double>("YardsPerPassAttempt")
                        .HasColumnType("double");

                    b.Property<double>("YardsPerReception")
                        .HasColumnType("double");

                    b.Property<double>("YardsPerRushAttempt")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayersStats");
                });

            modelBuilder.Entity("NFL.Persistence.Models.NFLTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClubName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ConferenceId")
                        .HasColumnType("int");

                    b.Property<string>("ConferenceName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("DivisionId")
                        .HasColumnType("int");

                    b.Property<string>("DivisionName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("NFL.Persistence.Models.NFLTeamStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("PerGameValue")
                        .HasColumnType("float");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamStats");
                });

            modelBuilder.Entity("NFL.Persistence.Models.Week", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("WeekNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Weeks");
                });

            modelBuilder.Entity("NFL.Persistence.Models.NFLGame", b =>
                {
                    b.HasOne("NFL.Persistence.Models.NFLTeam", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NFL.Persistence.Models.NFLTeam", "VisitorTeam")
                        .WithMany()
                        .HasForeignKey("VisitorTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NFL.Persistence.Models.Week", "Week")
                        .WithMany()
                        .HasForeignKey("WeekId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("HomeTeam");

                    b.Navigation("VisitorTeam");

                    b.Navigation("Week");
                });

            modelBuilder.Entity("NFL.Persistence.Models.NFLPlayer", b =>
                {
                    b.HasOne("NFL.Persistence.Models.NFLTeam", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("NFL.Persistence.Models.NFLPlayerOdds", b =>
                {
                    b.HasOne("NFL.Persistence.Models.NFLPlayer", null)
                        .WithMany("Odds")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("NFL.Persistence.Models.NFLPlayerStat", b =>
                {
                    b.HasOne("NFL.Persistence.Models.NFLPlayer", "Player")
                        .WithMany("Stats")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("NFL.Persistence.Models.NFLTeamStats", b =>
                {
                    b.HasOne("NFL.Persistence.Models.NFLTeam", null)
                        .WithMany("Stats")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("NFL.Persistence.Models.NFLPlayer", b =>
                {
                    b.Navigation("Odds");

                    b.Navigation("Stats");
                });

            modelBuilder.Entity("NFL.Persistence.Models.NFLTeam", b =>
                {
                    b.Navigation("Stats");
                });
#pragma warning restore 612, 618
        }
    }
}
