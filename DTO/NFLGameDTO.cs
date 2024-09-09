using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFL.Persistence.Models;

namespace NFL.Persistence.DTO
{
    public class NFLGameDTO
    {
        public int Id { get; set; }
        public NFLTeam HomeTeam { get; set; }
        public NFLTeam VisitorTeam { get; set; }
        public Week Week { get; set; }
        public string? PlayersParticipating { get; set; }
        public List<NFLPlayerDTO> HomePlayers { get; set; }
        public List<NFLPlayerDTO> VisitorPlayers { get; set; }
        public DateTime GameDate { get; set; }
    }
}