using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for PlayerStatistics.xaml
    /// </summary>
    public partial class PlayerStatistics : Window
    {
        public string Cards { get; set; }
        public string Goals { get; set; }
        public string Name { get; set; }
        public Uri picPath { get; set; }
        public PlayerStatistics()
        {
            InitializeComponent();
        }

        public void SetGoalsAndCardsNumber(string goals, string cards)
        {
            lblCardsNum.Content = $"{cards}";
            lblGoalsNum.Content = $"{goals}";
            Cards = cards;
            Goals = goals;
        }
        public void SetName(string name)
        {
            lblName.Content = name;
            Name = name;

        }

        public void SetPic(string path)
        {
            picPath = new Uri(path, UriKind.Absolute);
            picPlayer.Source = new BitmapImage(picPath);
        }

        private void BtnPicture_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                SetPic(ofd.FileName);
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void SetCaptain(bool captain)
        {
            if(captain)
            lblCaptain.Visibility = Visibility.Visible;
            else
            {
                lblCaptain.Visibility = Visibility.Hidden;
            }
        }
    }
}
