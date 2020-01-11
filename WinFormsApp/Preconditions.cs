﻿using FMClassLib.OOP.NETpraktikum;
using FMClassLib.OOP.NETpraktikum.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Properties;

namespace WinFormsApp
{
    public class Preconditions
    {

        public string filePath = @"C:\Users\FraneMušić\Desktop\FraneMusicOOP.NETpraktikum\WinFormsApp\Resources\AppSetting.txt";
        public string Locale { get; set; }
        public string FavouriteNation { get; set; }
        public string[] FavouritePlayers { get; set; }
        public FileManager FileManager { get; set; }
        public FileProps FileProps { get; set; }
        public Dictionary<string,string> PlayerPics { get; set; }

        public async Task SaveLanguage(string locale)
        {
            FileProps.Locale = locale;
            await FileManager.SaveProperties(filePath, FileProps);
        }
        public async Task SaveNation(string nation)
        {
            FileProps.FavouriteNation = nation;
            await FileManager.SaveProperties(filePath, FileProps);
        }

        public async Task SavePlayers(string[] players)
        {
            FileProps.FavouritePlayers = players;
            await FileManager.SaveProperties(filePath, FileProps);
        }
        public string GetLang()
        {
            return FileProps.Locale;
        }
        public string[] GetPlayers()
        {
            return FileProps.FavouritePlayers;
        }
        public string GetNation()
        {
            return FileProps.FavouriteNation;
        }
        public Preconditions()
        {
            FileManager = new FileManager(filePath);
            LoadFileProps();
        }

        private void LoadFileProps()
        {
            FileProps = FileManager.LoadProperites(filePath).Result;
            if (FileProps == null)
            {
                FileProps = new FileProps();
            }
        }
    }
}
