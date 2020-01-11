using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FMClassLib
{
    class ApiDataProcessor<T>
    {
        public static async Task<T> Load(string url)
        {
            ApiHelper.InitializeClient();
            HttpResponseMessage msg;
            while (true)
            {
                using (msg = await ApiHelper.Client.GetAsync(url))
                {
                    if (msg.IsSuccessStatusCode)
                    {
                        var instance = await msg.Content.ReadAsAsync<T>();

                        return instance;
                    }
                }
            }
        }

    }
}
