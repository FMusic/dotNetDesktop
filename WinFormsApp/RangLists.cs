using FMClassLib;
using FMClassLib.OOP.NETpraktikum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class RangLists : Form
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }

        public RangLists()
        {
            InitializeComponent();
        }
        public RangLists(string countryCode)
        {
            InitializeComponent();
            CountryCode = countryCode;
            
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var Team = await TeamsDataProcessor.GetTeamFromCountryCodeAsync(CountryCode);
            Country = Team.Country;
            await PopulateListOfPlayersByGoals();
            await PopulateListOfPlayersByCards();
            await PopulateListOfMatchesByVisitorsAsync();
        }

        private async Task PopulateListOfMatchesByVisitorsAsync()
        {
            var matches = await OrderedListsMatches.GetSortedMatches(Country);
            foreach (var match in matches)
            {
                ctrlMatch ctrl = new ctrlMatch(match.location, 
                    match.attendanceInt, 
                    match.home_team_country, 
                    match.away_team_country
                    );
                flpMatchesByVisitors.Controls.Add(ctrl);
            }
        }

        private async Task PopulateListOfPlayersByCards()
        {
            var players = await OrderedListsPlayers.OrderPlayersByCards(Country);
            foreach(var player in players)
            {
                ctrlPlayerForOrder ctrl = new ctrlPlayerForOrder();
                ctrl.SetNameAndNumber(player.Name, (int)player.ShirtNumber);
                ctrl.SetTypeAndNumber(TypeOfList.Cards, player.YellowCards);
                flpPlayersByCards.Controls.Add(ctrl);
            }
        }

        private async Task PopulateListOfPlayersByGoals()
        {
            var players = await OrderedListsPlayers.GetOrderedPlayersByGoalsAsync(Country);
            foreach (var player in players)
            {
                ctrlPlayerForOrder ctrl = new ctrlPlayerForOrder();
                ctrl.SetNameAndNumber(player.Name, (int)player.ShirtNumber );
                ctrl.SetTypeAndNumber(TypeOfList.Goals, player.Goals);
                flpPlayersByGoals.Controls.Add(ctrl);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Print
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage;
            PrintDialog dlgSettings = new PrintDialog
            {
                Document = doc
            };
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float newX = x + flpPlayersByGoals.Width;
            float newY = y + flpPlayersByGoals.Height;
            Bitmap bmp = new Bitmap(flpPlayersByGoals.Width, flpPlayersByGoals.Height);
            flpPlayersByGoals.DrawToBitmap(bmp, new Rectangle(0, 0, flpPlayersByGoals.Width, flpPlayersByGoals.Height));
            Bitmap bmp2 = new Bitmap(flpMatchesByVisitors.Width, flpMatchesByVisitors.Height);
            flpMatchesByVisitors.DrawToBitmap(bmp2, new Rectangle(0, 0, flpMatchesByVisitors.Width, flpMatchesByVisitors.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
            e.Graphics.DrawImage((Image)bmp2, newX, y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.ShowDialog();
            this.Hide();
        }
    }
}