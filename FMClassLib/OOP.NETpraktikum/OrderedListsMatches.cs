using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.OOP.NETpraktikum
{
    public static class OrderedListsMatches
    {
        public static async Task<IList<FootballMatch>> GetSortedMatches(string country)
        {
            var matches = await GetMatches(country);
            var attendedMatches = await Task.Run(()=>PutAttendanceToInt(matches));
            var sortedMatches = await SortMatches(attendedMatches);
            return sortedMatches;
        }
        public static async Task<IList<FootballMatch>> GetMatches(string country)
        {
            var team = await TeamsDataProcessor.GetTeamFromCountryNameAsync(country);
            var matches = await TeamsDataProcessor.PopulateGamesAsync(team.Code);
            List<FootballMatch> lista = new List<FootballMatch>();
            return matches;
        }

        public static async Task<IList<FootballMatch>> SortMatches(IList<FootballMatch> matches)
        {
            var sortedMatches = await Task.Run(()=> matches.OrderByDescending(x => x.attendanceInt));
            return sortedMatches.ToList();
        }

        public static IList<FootballMatch> PutAttendanceToInt(IList<FootballMatch> matches)
        {
            foreach (var match in matches)
            {
                try
                {
                    match.attendanceInt = Int32.Parse(match.attendance);
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
            return matches;
        }
    }
}
