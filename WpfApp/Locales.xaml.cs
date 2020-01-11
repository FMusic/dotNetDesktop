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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Preconditions Props { get; set; }
        public WindowState Size { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Props = new Preconditions();
            if (Props.GetLang() != null)
            {
                SetLang(Props.GetLang());
                NextForm();
            }
        }

        private async void BtnCroatian_Click(object sender, RoutedEventArgs e)
        {
            string loc = "hr-HR";
            await Props.SaveLanguage(loc);
            SetLang(loc);
            btnCroatian.IsEnabled = false;
        }

        private void NextForm()
        {
            if (cbFullScreen.IsChecked.Value == true)
            {
                Size = WindowState.Maximized;
            }
            else
            {
                Size = WindowState.Normal;
            }
            Match match = new Match(Props, Size);
            this.Hide();
            match.ShowDialog();
            
            this.Close();
        }

        private async void BtnEnglish_Click(object sender, RoutedEventArgs e)
        {
            string loc = "";
            await Props.SaveLanguage(loc);
            SetLang(loc);
            btnEnglish.IsEnabled = false;
        }

        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);
            Props = new Preconditions();
            if (Props.GetLang() != null)
            {
                SetLang(Props.GetLang());
            }
        }

        private void SetLang(string v)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(v);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            NextForm();
        }
    }
}
