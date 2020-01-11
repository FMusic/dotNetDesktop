using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.OOP.NETpraktikum.Model
{
    public class Player
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public long ShirtNumber { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        public int Goals { get; set; }
        public int OwnGoals { get; set; }
        public int GoalPenalites { get; set; }
        public int SubstitutionsIn { get; set; }
        public int SubstitutionsOut { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }

        public bool Favourite { get; set; }
    }
}