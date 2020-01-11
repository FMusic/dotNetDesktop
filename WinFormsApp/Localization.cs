using FMClassLib.OOP.NETpraktikum.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Localization : Form
    {
        Preconditions p;
        public Localization()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CheckLanguage();
        }
        private void CheckLanguage()
        {
            p = new Preconditions();
            string lang=p.GetLang();
            if (lang != null){
                SetLang(lang);
                NextForm();
            }
        }

        private void SetLang(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo(lang);
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(lang);
        }

        private async void btnCroatian_ClickAsync(object sender, EventArgs e)
        {
            Preconditions p = new Preconditions();
            SetLang("HR-hr");
            await p.SaveLanguage("HR-hr");
            NextForm();
        }

        private void NextForm()
        {
            FavouriteNation f = new FavouriteNation();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private async void btnEnglish_ClickAsync(object sender, EventArgs e)
        {
            Preconditions p = new Preconditions();
            SetLang("");
            await p.SaveLanguage("");
            NextForm();
        }
    }
}
