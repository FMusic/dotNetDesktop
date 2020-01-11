using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.OOP.NETpraktikum.Model
{
    public class TeamStatistics
    {
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string country { get; set; }
        //[JsonProperty("attempts_on_goal", NullValueHandling = NullValueHandling.Ignore)]
        //public int attempts_on_goal { get; set; }
        //[JsonProperty("on_target", NullValueHandling = NullValueHandling.Ignore)]
        //public int on_target { get; set; }
        //[JsonProperty("off_target", NullValueHandling = NullValueHandling.Ignore)]
        //public int off_target { get; set; }
        //[JsonProperty("blocked", NullValueHandling = NullValueHandling.Ignore)]
        //public int blocked { get; set; }
        //[JsonProperty("woodwork", NullValueHandling = NullValueHandling.Ignore)]
        //public int woodwork { get; set; }
        //[JsonProperty("corners", NullValueHandling = NullValueHandling.Ignore)]
        //public int corners { get; set; }
        //[JsonProperty("offsides", NullValueHandling = NullValueHandling.Ignore)]
        //public int offsides { get; set; }
        //[JsonProperty("ball_possession", NullValueHandling = NullValueHandling.Ignore)]
        //public int ball_possession { get; set; }
        //[JsonProperty("pass_accuracy", NullValueHandling = NullValueHandling.Ignore)]
        //public int pass_accuracy { get; set; }
        //[JsonProperty("num_passes", NullValueHandling = NullValueHandling.Ignore)]
        //public int num_passes { get; set; }
        //[JsonProperty("passes_completed", NullValueHandling = NullValueHandling.Ignore)]
        //public int passes_completed { get; set; }
        //[JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        //public int distance_covered { get; set; }
        //[JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        //public int balls_recovered { get; set; }
        //[JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        //public int tackles { get; set; }
        //[JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        //public int clearances { get; set; }
        //[JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        //public int yellow_cards { get; set; }
        //[JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        //public int red_cards { get; set; }
        //[JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        //public int fouls_committed { get; set; }
        //[JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        //public string tactics { get; set; }
        [JsonProperty("starting_eleven", NullValueHandling = NullValueHandling.Ignore)]
        public Player[] starting_eleven { get; set; }
        [JsonProperty("substitutes", NullValueHandling = NullValueHandling.Ignore)]
        public Player[] substitutes { get; set; }
    }
}
