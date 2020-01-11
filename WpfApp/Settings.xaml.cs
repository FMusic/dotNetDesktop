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
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Preconditions Precs { get; set; }
        public Settings()
        {
            InitializeComponent();
            Precs = new Preconditions();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Zelite li spremiti postavke", null, MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                Close();
            }
            else
            {
                btnCroatian.IsEnabled = true;
                btnEnglish.IsEnabled = true;
            }
        }

        private async void BtnCroatian_Click(object sender, RoutedEventArgs e)
        {
            string loc = "hr-HR";
            await Precs.SaveLanguage(loc);
            SetLang(loc);
            btnCroatian.IsEnabled = false;
        }

        private async void BtnEnglish_Click(object sender, RoutedEventArgs e)
        {
            string loc = "";
            await Precs.SaveLanguage(loc);
            SetLang(loc);
            btnEnglish.IsEnabled = false;
        }

        private void SetLang(string v)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(v);
        }
    }
}
