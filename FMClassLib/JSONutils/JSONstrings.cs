using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.JSONutils
{
    class JSONstrings<T>
    {
        public static T LoadModelFromJson(string content)
        {
            T t = default(T);
            try
            {
                if (content != "")
                {
                    t = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(content);
                }
                return t;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static string ModelToJson(T t)
        {
            string a = Newtonsoft.Json.JsonConvert.SerializeObject(t);
            return a;
        }
    }
}
