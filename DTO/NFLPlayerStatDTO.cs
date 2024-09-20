using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFL.Persistence.Models;

namespace NFL.Persistence.DTO
{
    public class NFLPlayerStatDTO
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public DateTime GameDate { get; set; }
        public int PlayerId { get; set; }
        public int Completions { get; set; } = 0;
        public int PassingAttempts { get; set; } = 0;
        public int PassingYards { get; set; } = 0;
        public double CompletionPct { get; set; } = 0.0;
        public double YardsPerPassAttempt { get; set; } = 0.0;
        public int PassingTouchdowns { get; set; } = 0;
        public int Interceptions { get; set; } = 0;
        public int LongPassing { get; set; } = 0;
        public int Sacks { get; set; } = 0;
        public double QBRating { get; set; } = 0.0;
        public double AdjQBR { get; set; } = 0.0;
        public int RushingAttempts { get; set; } = 0;
        public int RushingYards { get; set; } = 0;
        public double YardsPerRushAttempt { get; set; } = 0.0;
        public int RushingTouchdowns { get; set; } = 0;
        public int LongRushing { get; set; } = 0;
        public int Receptions { get; set; } = 0;
        public int ReceivingTargets { get; set; } = 0;
        public int ReceivingYards { get; set; } = 0;
        public double YardsPerReception { get; set; } = 0.0;
        public int ReceivingTouchdowns { get; set; } = 0;
        public int LongReception { get; set; } = 0;
        public int Fumbles { get; set; } = 0;
        public int FumblesLost { get; set; } = 0;
        public int FumblesForced { get; set; } = 0;
        public int KicksBlocked { get; set; } = 0;
        public double RushingShare { get; set; } = 0.0;
        public double ReceivingShare { get; set; } = 0.0;

        // Defensive Stats
        public int TotalTackles { get; set; } = 0;

        public int SoloTackles { get; set; } = 0;
        public int AssistTackles { get; set; } = 0;
        public int Stuffs { get; set; } = 0;
        public int StuffYards { get; set; } = 0;
        public int FumblesRecovered { get; set; } = 0;
        public int InterceptionYards { get; set; } = 0;
        public double AvgInterceptionYards { get; set; } = 0.0;
        public int InterceptionTouchdowns { get; set; } = 0;
        public int LongInterception { get; set; } = 0;
        public int PassesDefended { get; set; } = 0;

        // Kicking Stats
        public double FieldGoalPct { get; set; } = 0.0;

        public string FieldGoalsMade_FieldGoalAttempts { get; set; } = string.Empty;
        public string ExtraPointsMade_ExtraPointAttempts { get; set; } = string.Empty;
        public int TotalKickingPoints { get; set; } = 0;
        public bool IsHomeGame { get; set; }
        public bool IsWin { get; set; }
        public int OpposingTeamId { get; set; }
        public string OpposingTeamCode { get; set; }
        public string OpposingTeamName { get; set; }
        public string PlayersParticipated { get; set; }
    }
}