using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FMClassLib.OOP.NETpraktikum.Model;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Player.xaml
    /// </summary>
    public partial class Player : UserControl
    { 
        private FMClassLib.OOP.NETpraktikum.Model.Player player;

        public Player()
        {
            InitializeComponent();
        }

        public Player(FMClassLib.OOP.NETpraktikum.Model.Player player)
        {
            InitializeComponent();
            this.player = player;
            SetName(player.Name);
            SetShirtNum(player.ShirtNumber.ToString());

        }

        public string PlayerName { get; set; }
        public string ShirtNumber { get; set; }
        public string picPath { get; set; }

        public void SetName(string name)
        {
            PlayerName = name;
            lblName.Content = name;
        }

        public void SetShirtNum(string num)
        {
            ShirtNumber = num;
            lblNumber.Content = num;
        }
        public void SetPicPath(string path)
        {
            picPath = path;
            imgPlayer.Source = new BitmapImage(new Uri(path, UriKind.Relative));
        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PlayerStatistics ps = new PlayerStatistics();
            ps.SetGoalsAndCardsNumber(player.Goals.ToString(), player.YellowCards.ToString());
            ps.SetName(player.Name);
            ps.SetCaptain(player.Captain);
            ps.Show();
            //ps.SetPic(picPath);
        }
    }
}
