using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.OOP.NETpraktikum.Model
{
    public class AwayTeam
    {
        public string Name { get; set; }
        public string Fifa_Code { get; set; }
        public IList<Player> Players { get; set; }

        public int HomeGoalsInGame { get; set; }
        public int AwayGoalsInGame { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Fifa_Code})";
        }
    }
}
