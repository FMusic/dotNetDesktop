using FMClassLib;
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
    public partial class FavouriteNation : Form
    {
        public FavouriteNation()
        {
            InitializeComponent();
        }
        public IList<Team> Nations { get; set; }
        public string CountryCode { get; set; }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CheckForFavouriteNation();
            await PopulateComboBoxWithNations();
        }

        private void CheckForFavouriteNation()
        {
            Preconditions p = new Preconditions();
            if (p.GetNation() != null)
            {
                NextForm(p.GetNation());
            }
            
        }

        private void NextForm(string country)
        {
            PickPlayers f = new PickPlayers(country);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private async Task PopulateComboBoxWithNations()
        {
            Nations = await TeamsDataProcessor.PopulateTeamsAsync();
            foreach (var nation in Nations)
            {
                cbNations.Items.Add(nation);
            }
        }

        private void cbNations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            string country = cbNations.Text.Substring(cbNations.Text.IndexOf("(")+1, 3);
            Preconditions p = new Preconditions();
            await p.SaveNation(country);
            NextForm(country);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.ShowDialog();
            this.Hide();
        }
    }
}
