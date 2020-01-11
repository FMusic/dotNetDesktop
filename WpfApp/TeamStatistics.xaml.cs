using FMClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for TeamStatistics.xaml
    /// </summary>
    public partial class TeamStatistics : Window
    {
        public Team Team { get; set; }
        public TeamStatistics()
        {
            InitializeComponent();
        }

        public TeamStatistics(Team team)
        {
            InitializeComponent();
            Team = team;
            lblCountry.Content = team.ToString();
            lblMatchesNum.Content = team.GamesPlayed.ToString();
            lblWins.Content = team.Wins.ToString();
            lblDraws.Content = team.Draws.ToString();
            lblScored.Content = team.GoalsFor.ToString();
            lblReceived.Content = team.GoalsAgainst.ToString();
            lblDiff.Content = team.GoalDifferential.ToString();

        }

        public TeamStatistics(string country, string matchesNum, string wins, string draws, string loses,
                                string scored, string received, string diff)
        {
            InitializeComponent();

            lblCountry.Content = country;
            lblMatchesNum.Content = matchesNum;
            lblWins.Content = wins;
            lblDraws.Content = draws;
            lblLoses.Content = loses;
            lblScored.Content = scored;
            lblReceived.Content = received;
            lblDiff.Content = diff;
        }
    }
}
