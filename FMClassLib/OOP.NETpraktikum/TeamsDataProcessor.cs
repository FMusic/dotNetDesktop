using FMClassLib.OOP.NETpraktikum;
using FMClassLib.OOP.NETpraktikum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib
{
    public class TeamsDataProcessor
    {
        //public const string url = @"http://worldcup.sfg.io/teams/results";
        public const string urlMatches = @"https://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        public const string urlTeams = @"https://world-cup-json-2018.herokuapp.com/teams/results";

        public static async Task<IList<Team>> PopulateTeamsAsync()
        {
            var Teams = await ApiDataProcessor<IList<Team>>.Load(urlTeams);
            return Teams;
        }

        public static async Task<IList<FootballMatch>> PopulateGamesAsync(string countryFifaCode)
        {
            var Games = await ApiDataProcessor<IList<FootballMatch>>.Load(urlMatches + countryFifaCode);
            return Games;
        }
        public static async Task<IList<Player>> GetPlayersAsync(string code)
        {
            var teams = await PopulateTeamsAsync();
            IList<Player> players = new List<Player>();

            foreach (var team in teams)
            {
                if (team.Code == code)
                {
                    var games = await PopulateGamesAsync(team.Code);
                    var game = games.First<FootballMatch>();
                    players = GetPlayersFromGame(game, team.Code);
                }
            }
            if (players != null)
            {
                return players;
            }
            else
            {
                throw new Exception("NoPlayers");
            }
        }
        public static IList<Player> GetPlayersFromGame(FootballMatch game, string code)
        {
            IList<Player> players = new List<Player>();
            TeamStatistics ts;
            if (game.Away_team.Code == code)
            {
                ts = game.away_team_statistics;
            }
            else
            {
                ts = game.home_team_statistics;
            }
            foreach (var player in ts.starting_eleven)
            {
                players.Add(player);
            }
            foreach (var player in ts.substitutes)
            {
                players.Add(player);
            }
            return players;
        }

        public static async Task<Team> GetTeamFromCountryCodeAsync(string countryCode)
        {
            IList<Team> Teams = await PopulateTeamsAsync();
            Team team = (
                from steam in Teams
                where steam.Code == countryCode
                select steam).Single();
            return team;
        }
        public static async Task<Team> GetTeamFromCountryNameAsync(string countryName)
        {
            IList<Team> Teams = await PopulateTeamsAsync();
            Team team = (
               from steam in Teams
               where steam.Country == countryName
               select steam
               ).Single();
            return team;
        }

        public static async Task<WpfData> GetDataForWpf(string countryName)
        {
            Team team = await GetTeamFromCountryNameAsync(countryName);
            IList<FootballMatch> Matches = await PopulateGamesAsync(team.Code);
            WpfData data = new WpfData
            {
                HomePlayers = Matches[0].home_team_statistics
                                        .starting_eleven
                                        .ToList(),
                HomeTeam = team,
                AwayTeams = new List<AwayTeam>()
            };

            foreach (var match in Matches)
            {
                IList<Player> players;
                var at = new AwayTeam();
                if (match.Away_team.Country != countryName)
                {
                    players = match.away_team_statistics.starting_eleven.ToList();
                    at.Fifa_Code = match.Away_team.Code;
                    at.Name = match.Away_team.Country;
                    at.Players = match.away_team_statistics.starting_eleven;
                    at.AwayGoalsInGame = match.Away_team.Goals;
                    at.HomeGoalsInGame = match.Home_team.Goals;
                    at.Players = OrderedListsPlayers.AddEventsToPlayers(match.away_team_events,
                        players);
                }
                else
                {
                    players = match.home_team_statistics.starting_eleven.ToList();
                    at.Fifa_Code = match.Home_team.Code;
                    at.Name = match.Home_team.Country;
                    at.Players = OrderedListsPlayers.AddEventsToPlayers(match.home_team_events, players);
                    at.AwayGoalsInGame = match.Home_team.Goals;
                    at.HomeGoalsInGame = match.Away_team.Goals;
                }
                data.AwayTeams.Add(at);
            }
            return data;
        }
    }
}
