using FMClassLib.OOP.NETpraktikum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.OOP.NETpraktikum
{
    public class TeamsContent
    {
        public TeamsContent(string countryName)
        {
            CountryName = countryName;
        }

        public async Task InitContentAsync()
        {
            HomeTeam = await TeamsDataProcessor.GetTeamFromCountryNameAsync(CountryName);
            await PopulatePossibleAwayTeamsAsync();
        }

        public void InitContent()
        {
            HomeTeam = TeamsDataProcessor.GetTeamFromCountryNameAsync(CountryName).Result;
            Matches = TeamsDataProcessor.PopulateGamesAsync(HomeTeam.Code).Result;
            GetTeamsFromMatches(Matches);
        }

        private async Task PopulatePossibleAwayTeamsAsync()
        {
            Matches = await TeamsDataProcessor.PopulateGamesAsync(HomeTeam.Code);
            GetTeamsFromMatches(Matches);
        }

        private void GetTeamsFromMatches(IList<FootballMatch> matches)
        {
            AwayTeams = new List<AwayTeam>(); 
            foreach (var match in matches)
            {
                AwayTeam at = new AwayTeam
                {
                    Name = match.away_team_country,
                    Players = match.away_team_statistics.starting_eleven
                };
                AwayTeams.Add(at);
            }
        }

        public Team HomeTeam { get; set; }
        public IList<Team> Teams { get; set; }
        public IList<Team> PossibleAwayTeams { get; set; }
        public IList<Player> HomePLayers { get; set; }
        public IList<Player> AwayPlayers { get; set; }
        public string CountryName { get; set; }
        public IList<FootballMatch> Matches { get; set; }
        public IList<AwayTeam> AwayTeams { get; set; }

        public class AwayTeam
        {
            public Player[] Players { get; set; }
            public string Name { get; set; }
        }
    }
}
