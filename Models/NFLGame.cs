using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL.Persistence.Models
{
    public class NFLGame
    {
        public int Id { get; set; }
        public int WeekId { get; set; }
        public virtual Week Week { get; set; }
        public int HomeTeamId { get; set; }
        public int VisitorTeamId { get; set; }
        public DateTime GameDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public string? HomeTeamOdds { get; set; }
        public string? VisitorTeamOdds { get; set; }
        public string? HomeTeamSpreadLine { get; set; }
        public string? HomeTeamSpreadOdds { get; set; }
        public string? VisitorTeamSpreadLine { get; set; }
        public string? VisitorTeamSpreadOdds { get; set; }
        public string? GameOverOdds { get; set; }
        public string? GameUnderOdds { get; set; }
        public float? GameRunLine { get; set; }
        public virtual NFLTeam HomeTeam { get; set; }
        public virtual NFLTeam VisitorTeam { get; set; }
    }
}