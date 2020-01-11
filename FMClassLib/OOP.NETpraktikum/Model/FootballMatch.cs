using FMClassLib;
using FMClassLib.OOP.NETpraktikum.Model;
using System;

public class Rootobject
{
    public FootballMatch[] matches { get; set; }
}

public class FootballMatch
{
    public string venue { get; set; }
    public string location { get; set; }
    public string status { get; set; }
    public string time { get; set; }
    public string fifa_id { get; set; }
    public Weather weather { get; set; }
    public string attendance { get; set; }
    public string[] officials { get; set; }
    public string stage_name { get; set; }
    public string home_team_country { get; set; }
    public string away_team_country { get; set; }
    public DateTime datetime { get; set; }
    public string winner { get; set; }
    public string winner_code { get; set; }
    public Team Home_team { get; set; }
    public Team Away_team { get; set; }
    public Team_Event[] home_team_events { get; set; }
    public Team_Event[] away_team_events { get; set; }
    public TeamStatistics home_team_statistics { get; set; }
    public TeamStatistics away_team_statistics { get; set; }
    public DateTime last_event_update_at { get; set; }
    public DateTime last_score_update_at { get; set; }
    public int attendanceInt { get; set; }

    public override string ToString()
    {
        return $"{home_team_country} vs {away_team_country} with {attendanceInt}";
    }
}
