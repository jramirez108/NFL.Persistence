using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL.Persistence.Models
{
    public class NFLTeam
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Location { get; set; }
        public int ConferenceId { get; set; }
        public string ConferenceName { get; set; }
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string ClubName { get; set; }
        public virtual List<NFLTeamStats> Stats { get; set; }
    }
}