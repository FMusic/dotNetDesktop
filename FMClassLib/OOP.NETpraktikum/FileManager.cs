using FMClassLib.FileUtils;
using FMClassLib.OOP.NETpraktikum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMClassLib.OOP.NETpraktikum
{
    public class FileManager
    {
        public string Path { get; set; }

        public const string DIR = @"C:\Users\FraneMušić\Desktop\FraneMusicOOP.NETpraktikum\FMClassLib\res\";
        
        public FileProps Props {
            get
            {
                return FileHelper<FileProps>.LoadModelFromJsonFileAsync(Path).Result;
            }
            set
            {
                Props = value;
                FileHelper<FileProps>.SaveModelToJsonFile(Path, value);
            }
        }
        public FileManager(string path)
        {
            Path = path;
        }
        public static async Task SaveLang(string locale)
        {
            throw new NotImplementedException();
        }

        public static async Task SaveNation(string nation)
        {
            throw new NotImplementedException();
        }

        public static async Task SavePlayers(string[] players)
        {
            throw new NotImplementedException();
        }

        public async Task<FileProps> LoadProperites(string path)
        {
            FileProps props = await FileHelper<FileProps>.LoadModelFromJsonFileAsync(path);
            return props;
        }

        public async Task SaveProperties(string path, FileProps props)
        {
            await FileHelper<FileProps>.SaveModelToJsonFile(path, props);
        }
    }
}
