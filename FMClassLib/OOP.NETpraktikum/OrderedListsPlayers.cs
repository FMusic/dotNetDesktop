using FMClassLib.OOP.NETpraktikum.Model;
using FMClassLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.OOP.NETpraktikum
{
    public static class OrderedListsPlayers
    {
        public static async Task<IList<Player>> GetOrderedPlayersByGoalsAsync(string country)
        {
            IList<Player> players = await PrepareDataForSorting(country);
            IList<Player> sortedList =
                (
                    from p in players
                    orderby p.Goals descending
                    select p
                ).ToList();
            return sortedList;
        }

        public static async Task<IList<Player>> OrderPlayersByGoalsAndCards(string country)
        {
            IList<Player> players = await PrepareDataForSorting(country);
            players.OrderBy(x => x.Goals).ThenByDescending(x => x.YellowCards);
            return players;
        }

        public static async Task<IList<Player>> OrderPlayersByCards(string country)
        {
            IList<Player> players = await PrepareDataForSorting(country);
            return (
                from p in players
                orderby p.YellowCards descending
                select p
                ).ToList();
        }

        private static async Task<IList<Player>> PrepareDataForSorting(string country)
        {
            var countryFull = await TeamsDataProcessor.GetTeamFromCountryNameAsync(country);
            string code = countryFull.Code;
            IList<FootballMatch> matches = await TeamsDataProcessor.PopulateGamesAsync(code);
            IList<Player> players = new List<Player>();
            var AllPlayers = await TeamsDataProcessor.GetPlayersAsync(countryFull.Code);
            IList<Team_Event> events = GetTeamEvents(country, matches);
            IList<Player> eventfulPlayers = AddEventsToPlayers(events, AllPlayers);
            return eventfulPlayers;
        }

        public static IList<Player> AddEventsToPlayers(IList<Team_Event> events, IList<Player> players)
        {
            foreach (var tEvent in events)
            {
                Player playa = (
                    from player in players
                    where player.Name == tEvent.player
                    select player).FirstOrDefault();
                if (playa != null)
                {
                    players.Remove(playa);
                    switch (tEvent.type_of_event)
                    {
                        case "yellow-card":
                            playa.YellowCards++;
                            break;
                        case "substitution-in":
                            playa.SubstitutionsIn++;
                            break;
                        case "substitution-out":
                            playa.SubstitutionsOut++;
                            break;
                        case "goal-penalty":
                            playa.GoalPenalites++;
                            break;
                        case "goal-own":
                            playa.OwnGoals++;
                            break;
                        case "goal":
                            playa.Goals++;
                            break;
                        default:
                            break;
                    }
                    players.Add(playa);
                }
            }
            return players;
        }

        private static IList<Team_Event> GetTeamEvents(string country, IList<FootballMatch> matches)
        {
            Team_Event[] teamEvents;
            IList<Team_Event> eventi = new List<Team_Event>();
            foreach (var match in matches)
            {
                if (match.away_team_country == country)
                {
                    teamEvents = match.away_team_events;
                }
                else
                {
                    teamEvents = match.home_team_events;
                }
                foreach (var tevent in teamEvents)
                {
                    eventi.Add(tevent);
                }
            }
            
            return eventi;
        }
    }
}
