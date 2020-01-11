using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.OOP.NETpraktikum.Model
{
    public class WpfData
    {
        public Team HomeTeam { get; set; }
        public IList<AwayTeam> AwayTeams { get; set; }
        public IList<Player> HomePlayers { get; set; }
        
    }
}
