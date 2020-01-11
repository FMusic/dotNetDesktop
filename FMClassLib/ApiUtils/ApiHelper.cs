using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib
{
    static class ApiHelper
    {
        public static HttpClient Client { get; set; }
        public static bool Initialized { get; set; }

        public static void InitializeClient()
        {
            if (Initialized == false)
            {
                Client = new HttpClient();
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                Initialized = true;
            }

        }
    }
}
