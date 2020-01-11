using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.Utils
{
    static class EnumUtils<T>
    {
        public static T ParseEnum(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
