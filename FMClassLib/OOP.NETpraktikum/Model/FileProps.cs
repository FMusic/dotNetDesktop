using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.OOP.NETpraktikum.Model
{
    public class FileProps
    {
        [JsonProperty("Locale")]
        public string Locale { get; set; }

        [JsonProperty("FavouriteNation")]
        public string FavouriteNation { get; set; }

        [JsonProperty("FavouritePlayers")]
        public string[] FavouritePlayers { get; set; }
    }
}
