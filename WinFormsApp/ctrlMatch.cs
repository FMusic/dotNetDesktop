using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class ctrlMatch : UserControl
    {
        public ctrlMatch()
        {
            InitializeComponent();
        }

        public ctrlMatch(string location, int visitors, string homeTeam, string awayTeam)
        {
            InitializeComponent();
            lblLocation.Text = location;
            lblNumberOfVisitors.Text = visitors.ToString();
            lblHome.Text = homeTeam;
            lblAway.Text = awayTeam;
        }

        public void SetTeams(string home, string away)
        {
            lblHome.Text = home;
            lblAway.Text = away;
        }
    }
}
