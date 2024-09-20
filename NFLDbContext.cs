using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NFL.Persistence.Models;

namespace NFL.Persistence
{
    public class NFLDbContext : DbContext
    {
        public NFLDbContext(DbContextOptions<NFLDbContext> options) : base(options)
        {
        }

        public DbSet<NFLTeam> Teams { get; set; }
        public DbSet<NFLPlayer> Players { get; set; }
        public DbSet<NFLPlayerStat> PlayersStats { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<NFLGame> Games { get; set; }
        public DbSet<NFLPlayerOdds> PlayerOdds { get; set; }
        public DbSet<NFLTeamStats> TeamStats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //NFL Team
            modelBuilder.Entity<NFLTeam>().HasKey(x => x.Id);
            modelBuilder.Entity<NFLTeam>().HasMany(x => x.Stats)
                .WithOne()
                .HasForeignKey(x => x.TeamId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<NFLTeam>().Navigation(x => x.Stats).AutoInclude();
            //NFL Player
            modelBuilder.Entity<NFLPlayer>().HasKey(x => x.Id);
            modelBuilder.Entity<NFLPlayer>().HasOne(x => x.Team)
                .WithMany()
                .HasForeignKey(x => x.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<NFLPlayer>().HasMany(x => x.Stats)
                .WithOne(x => x.Player)
                .HasForeignKey(x => x.PlayerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<NFLPlayer>().HasMany(x => x.Odds)
                .WithOne()
                .HasForeignKey(x => x.PlayerId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<NFLPlayer>().Navigation(x => x.Stats).AutoInclude();
            modelBuilder.Entity<NFLPlayer>().Navigation(x => x.Odds).AutoInclude();

            //NFL Game
            modelBuilder.Entity<NFLGame>().HasKey(x => x.Id);
            modelBuilder.Entity<NFLGame>().HasOne(x => x.HomeTeam)
                .WithMany()
                .HasForeignKey(x => x.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<NFLGame>().HasOne(x => x.VisitorTeam)
                .WithMany()
                .HasForeignKey(x => x.VisitorTeamId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<NFLGame>().HasOne(x => x.Week)
                .WithMany()
                .HasForeignKey(x => x.WeekId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<NFLGame>().Navigation(x => x.HomeTeam).AutoInclude();
            modelBuilder.Entity<NFLGame>().Navigation(x => x.VisitorTeam).AutoInclude();
            modelBuilder.Entity<NFLGame>().Navigation(x => x.Week).AutoInclude();

            //Others
            modelBuilder.Entity<NFLPlayerStat>().HasKey(x => x.Id);
            modelBuilder.Entity<NFLPlayerStat>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<NFLPlayerStat>().HasOne(x => x.OpposingTeam)
                .WithMany()
                .HasForeignKey(x => x.OpposingTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Week>().HasKey(x => x.Id);
            modelBuilder.Entity<NFLTeamStats>().HasKey(x => x.Id);
            modelBuilder.Entity<NFLPlayerOdds>().HasKey(x => x.Id);
            modelBuilder.Entity<NFLPlayerStat>().Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}