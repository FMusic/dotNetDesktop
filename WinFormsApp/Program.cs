using FMClassLib;
using FMClassLib.OOP.NETpraktikum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new Localization());
            //Application.Run(new FavouriteNation());
            //Application.Run(new PickPlayers());
            //Application.Run(new RangLists());
        }

       
    }
}
