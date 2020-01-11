using FMClassLib;
using FMClassLib.OOP.NETpraktikum;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //await PopulateTextBox();
            //await PopulateTextBox2();
            //await PopulateListBox();
            await PopulatePlayersListBox();
            await PopulateTeamsListBox();
            await PopulateMatchesListBox();
        }

        private async Task PopulateMatchesListBox()
        {
            var matches = await OrderedListsMatches.GetSortedMatches("Croatia");
            foreach (var match in matches)
            {
                lbGames.Items.Add(match);
            }
        }

        private async Task PopulatePlayersListBox()
        {
            var players = await OrderedListsPlayers.GetOrderedPlayersByGoalsAsync("Croatia");
            foreach (var player in players)
            {
                lbPlayers.Items.Add(player.Name);
            }
        }

        private async Task PopulateTeamsListBox()
        {
            var Teams = await TeamsDataProcessor.PopulateTeamsAsync();
            foreach (var team in Teams)
            {
                lbTeams.Items.Add(team);
            }
        }
    }
}
