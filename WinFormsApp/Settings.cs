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
    public partial class Settings : Form
    {
        public Preconditions Precs { get; set; }
        public Settings()
        {
            InitializeComponent();
            Precs = new Preconditions();
        }

        private async void btnCroatian_ClickAsync(object sender, EventArgs e)
        {
            btnCroatian.BackColor = Color.Green;
            btnEnglish.BackColor = Color.Gray;
            SetLang("HR-hr");
            await Precs.SaveLanguage("HR-hr");
        }

        private async void btnEnglish_Click(object sender, EventArgs e)
        {
            btnEnglish.BackColor = Color.Green;
            btnCroatian.BackColor = Color.Gray;
            SetLang("");
            await Precs.SaveLanguage("");
        }

        private void SetLang(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo(lang);
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(lang);
        }
    }
}
