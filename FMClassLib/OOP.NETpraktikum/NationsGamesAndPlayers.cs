using FMClassLib.OOP.NETpraktikum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.OOP.NETpraktikum
{
    public class NationsGamesAndPlayers
    {
        public IList<Player> Players { get; set; }
        public IList<FootballMatch> Matches { get; set; }
        public IList<Team> Nations { get; set; }

        public NationsGamesAndPlayers(string countryCode)
        {
            Nations = TeamsDataProcessor.PopulateTeamsAsync().Result;
        }


    }
}
