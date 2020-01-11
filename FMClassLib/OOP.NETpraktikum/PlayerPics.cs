using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.OOP.NETpraktikum
{
    public class PlayerPics
    {
        public Dictionary<string,string> PlayerPicsDictionary { get; set; }
        public string Nation { get; set; }
        private string FilesPathDir;
        private string DicPath;
        public IList<string> Players{ get; set; }
        public string defaultPlayerPicPath = FileManager.DIR + @"player.png";

        public PlayerPics(string nation, IList<string> players)
        {
            Nation = nation;
            Players = players;
            SetFilesPath();
            LoadDictionary();
        }

        private void SetFilesPath()
        {
            FilesPathDir = FileManager.DIR + $"{Nation}\\";
            DicPath = FilesPathDir + "info.txt";
        }

        private void LoadDictionary()
        {
            if (!File.Exists(DicPath))
            {
                Directory.CreateDirectory(FilesPathDir);
                File.Create(DicPath).Close();
                PlayerPicsDictionary = new Dictionary<string, string>();
                foreach (var player in Players)
                {
                    PlayerPicsDictionary.Add(player, defaultPlayerPicPath);
                }
                FileUtils.FileHelper<Dictionary<string, string>>.SaveModelToJsonFile(DicPath, PlayerPicsDictionary);
            }
            else
            {
                PlayerPicsDictionary = FileUtils.FileHelper<Dictionary<string, string>>.LoadModelFromJsonFileAsync(DicPath).Result;
            }
        }

        public async Task SavePlayerPictureAsync(string name, string path)
        {
            string filepath = FilesPathDir + name;
            File.Copy(path, filepath);
            PlayerPicsDictionary.Remove(name);
            PlayerPicsDictionary.Add(name, filepath);
            await FileUtils.FileHelper<Dictionary<string, string>>.SaveModelToJsonFile(DicPath, PlayerPicsDictionary);
        }

        public string GetPlayerPic(string name)
        {
            string playerPicPath;
            bool check = PlayerPicsDictionary.TryGetValue(name, out playerPicPath);
            if (check == true)
                return playerPicPath;
            else
                return defaultPlayerPicPath;
        }
    }
}
