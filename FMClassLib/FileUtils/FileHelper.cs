using FMClassLib.OOP.NETpraktikum.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.FileUtils
{
    public static class FileHelper<T>
    {
        public static async Task SaveModelToJsonFile(string path, T model)
        {
            var str = JSONutils.JSONstrings<T>.ModelToJson(model);
            WriteToFile(str, path);
        }

        private static  void WriteToFile(string stringToSave, string path)
        {
            //FileStream fs = new FileStream(path, FileMode.Append);
            //fs.
            File.WriteAllText(path, stringToSave);
        }

        private static void CreateNewFileAndOverwrite(string path)
        {
            throw new NotImplementedException();
        }

        private static string ReadFromFile(string path)
        {
            string s;
            if (File.Exists(path))
            {
                s = File.ReadAllText(path);
            }
            else
                s = "";
            return s;
        }

        public static async Task<T> LoadModelFromJsonFileAsync(string path)
        {
            string content = ReadFromFile(path);
            var t = JSONutils.JSONstrings<T>.LoadModelFromJson(content);
            return t;
        }
    }
}