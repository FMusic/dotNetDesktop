using FMClassLib.FileUtils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.OOP.NETpraktikum.Model
{
    public class FileModel
    {
        public string Locale { get; set; }
        public string FavouriteNation { get; set; }
        public string[] FavouritePlayers { get; set; }

        public static async Task SaveToFileAsync(FileModel fm, string path)
        {
            await FileHelper<FileModel>.SaveModelToJson(path, fm);
        }

        public static async Task<FileModel> LoadFromFileAsync(string path)
        {
            try
            {
                FileModel fm = await FileHelper<FileModel>.LoadModelFromJson(path);
                return fm;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
