using FMClassLib;
using FMClassLib.OOP.NETpraktikum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Match.xaml
    /// </summary>
    public partial class Match : Window
    {
        public WpfData Data { get; set; }
        public string CountryName { get; private set; }
        public Preconditions Props { get; set; }
        public IList<Team> Teams { get; set; }
        public Team Home_Team { get; set; }
        public Match()
        {
            //ctor za probu
            InitializeComponent();
            Props = new Preconditions();
            CountryName = "CRO";
        }
        public Match(Preconditions preconditions, WindowState size)
        {
            InitializeComponent();
            Props = preconditions;
            CountryName = Props.GetNation();
            this.WindowState = size;
        }
        protected override async void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);
            ClearAwayStackPanels();
            ClearHomeStackPanels();
            Teams = await TeamsDataProcessor.PopulateTeamsAsync();
            cbCountries.ItemsSource = Teams;
            if (CountryName != null && CountryName != "")
            {
                Home_Team = await TeamsDataProcessor.GetTeamFromCountryCodeAsync(CountryName);
                await PrepareDataFromTeamForCb(Home_Team);
                LoadHomeStackPanel();
            }
        }
        private void LoadHomeStackPanel()
        {
            foreach (var player in Data.HomePlayers)
            {
                Player ctrlPlayer = SetPlayerControl(player);
                switch (player.Position)
                {
                    case Position.Defender:
                        spDefendHome.Children.Add(ctrlPlayer);
                        break;
                    case Position.Forward:
                        spAttackHome.Children.Add(ctrlPlayer);
                        break;
                    case Position.Goalie:
                        spGoalHome.Children.Add(ctrlPlayer);
                        break;
                    case Position.Midfield:
                        spMiddleHome.Children.Add(ctrlPlayer);
                        break;
                    default:
                        break;
                }
            }
        }
        private void LoadAwayStackPanel(AwayTeam team)
        {
            ClearAwayStackPanels();
            foreach (var player in team.Players)
            {
                var pl = SetPlayerControl(player);
                switch (player.Position)
                {
                    case Position.Defender:
                        spDefendAway.Children.Add(pl);
                        break;
                    case Position.Forward:
                        spAttackAway.Children.Add(pl);
                        break;
                    case Position.Goalie:
                        spGoalAway.Children.Add(pl);
                        break;
                    case Position.Midfield:
                        spMiddleAway.Children.Add(pl);
                        break;
                    default:
                        break;
                }
            }
        }
        private void ClearAwayStackPanels()
        {
            spDefendAway.Children.Clear();
            spGoalAway.Children.Clear();
            spAttackAway.Children.Clear();
            spMiddleAway.Children.Clear();
        }
        private void ClearHomeStackPanels()
        {
            spDefendHome.Children.Clear();
            spAttackHome.Children.Clear();
            spMiddleHome.Children.Clear();
            spGoalHome.Children.Clear();
        }
        private static Player SetPlayerControl(FMClassLib.OOP.NETpraktikum.Model.Player player)
        {
            var ctrlPlayer = new Player(player);
            ctrlPlayer.SetName(player.Name);
            ctrlPlayer.SetShirtNum(player.ShirtNumber.ToString());
            //ctrlPlayer.SetPicPath(path);
            return ctrlPlayer;
        }
        private async void CbCountriesAway_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            ClearAwayStackPanels();
            string chosenOne = GetCountryCodeFromComboBoxChoice(sender);
            if (chosenOne != null)
            {
                var team = (
                    from tea in Data.AwayTeams
                    where tea.Fifa_Code == chosenOne
                    select tea
                    ).FirstOrDefault();
                var team2 = await TeamsDataProcessor.GetTeamFromCountryNameAsync(team.Name);
                PopUpStats(team2);
                LoadAwayStackPanel(team);
                SetResultLabels(team);
            }
        }

        private void SetResultLabels(AwayTeam team)
        {
            lblResultAway.Content = team.AwayGoalsInGame.ToString();
            lblResultHome.Content = team.HomeGoalsInGame.ToString();
        }

        private static string GetCountryCodeFromComboBoxChoice(object sender)
        {
            ComboBox comboBox = sender as ComboBox;
            string chosenOne = null;
            string value;
            if (comboBox.SelectedValue != null)
            {
                value = comboBox.SelectedValue.ToString();
                chosenOne = value.Substring(value.Length - 4, 3);
            }
            return chosenOne;
        }
        private async void CbCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClearResultLabels();
            string chosenOne = GetCountryCodeFromComboBoxChoice(sender);
            await Props.SaveNation(chosenOne);
            Home_Team = await TeamsDataProcessor.GetTeamFromCountryCodeAsync(chosenOne);
            await Props.SaveNation(Home_Team.Code);
            ClearAwayStackPanels();
            ClearHomeStackPanels();
            await PrepareDataFromTeamForCb(Home_Team);
            PopUpStats(Home_Team);
            LoadHomeStackPanel();
        }

        private void ClearResultLabels()
        {
            lblResultAway.Content = "0";
            lblResultHome.Content = "0";
        }

        private void PopUpStats(Team team)
        {
            TeamStatistics ts = new TeamStatistics(
                    team.ToString(),
                    team.GamesPlayed.ToString(),
                    team.Wins.ToString(),
                    team.Draws.ToString(),
                    team.Losses == null ? (Home_Team.Wins - Home_Team.Draws).ToString() : Home_Team.Losses.ToString(),
                    team.GoalsFor.ToString(),
                    team.GoalsAgainst.ToString(),
                    team.GoalDifferential.ToString()
            );
            ts.Show();
        }
        private async Task PrepareDataFromTeamForCb(Team team)
        {
            cbCountriesAway.ItemsSource = null;
            Data = await TeamsDataProcessor.GetDataForWpf(team.Country);
            CountryName = Data.HomeTeam.Country;
            cbCountries.SelectedItem = Data.HomeTeam;
            cbCountriesAway.ItemsSource = Data.AwayTeams;
        }

        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            Hide();
            settings.ShowDialog();
            Show();
        }
    }
}
