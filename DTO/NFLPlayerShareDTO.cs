using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL.Persistence.DTO
{
    public class NFLPlayerShareDTO
    {
        public int PlayerId { get; set; }
        public double Share { get; set; }
        public string Type { get; set; }
        public int GameId { get; set; }
    }
}