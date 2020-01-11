using FMClassLib;
using FMClassLib.FileUtils;
using FMClassLib.OOP.NETpraktikum;
using FMClassLib.OOP.NETpraktikum.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Properties;

namespace WinFormsApp
{
    public partial class PickPlayers : Form
    {
        public string[] FavouritePlayers { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        private int FAVOURITE_PLAYERS_MAX = 3;
        private PlayerPics pics;

        public PickPlayers()
        {
            InitializeComponent();
            CountryCode = "CRO";
        }
        public PickPlayers(string countryCode)
        {
            InitializeComponent();
            CountryCode = countryCode;
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await CheckForPlayersAsync();
            SetArrowImages();
            await FillPlayersAll(CountryCode);
        }
        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            await SaveFavouritePlayersAsync();
        }
        private async Task CheckForPlayersAsync()
        {
            Preconditions p = await Task.Run(()=>new Preconditions());
            FavouritePlayers = p.GetPlayers();
        }
        private void NextForm()
        {
            RangLists f = new RangLists(CountryCode);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        private async Task SaveFavouritePlayersAsync()
        {
            IList<string> players = new List<string>();
            Preconditions p = new Preconditions();
            foreach (var player in panelFavourites.Controls)
            {
                var pl = (ctrlPlayerForFav)player;
                string name = pl.GetName();
                players.Add(name);
            }
            string[] playas = players.ToArray();
            await p.SavePlayers(playas);
        }
        private async Task FillPlayersAll(string countryCode)
        {
            var AllPlayers = await TeamsDataProcessor.GetPlayersAsync(countryCode);
            IList<string> playerNames;
            playerNames = (
                from players in AllPlayers
                select players.Name
                ).ToList();

            pics = new PlayerPics(countryCode, playerNames);
            foreach (var player in AllPlayers)
            {
                SetFavourite(player);
                ctrlPlayerForFav playa = SetControl(player,pics);
                playa.SetPicture(pics.GetPlayerPic(player.Name));
                playa.MouseDoubleClick += Playa_DoubleClickAsync;
                if (player.Favourite == true)
                {
                    playa.SetFavourite(true);
                    panelFavourites.Controls.Add(playa);
                }
                else
                {
                    panelNonFavourites.Controls.Add(playa);
                }
            }
        }

        protected async void Playa_DoubleClickAsync(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.ShowDialog();
            var player = sender as ctrlPlayerForFav;
            await pics.SavePlayerPictureAsync(player.Name, ofg.FileName);
            player.SetPicture(pics.GetPlayerPic(player.Name));
        }

        private static ctrlPlayerForFav SetControl(Player player, PlayerPics pics)
        {
            ctrlPlayerForFav playa = new ctrlPlayerForFav(pics);
            playa.SetCaptain(player.Captain);
            if (player.Name == "Luka MODRIC")
            {
                playa.SetName("NE SJECAM SE");
            }
            else
            {
                playa.SetName(player.Name);
            }
            playa.SetNumber(player.ShirtNumber.ToString());
            playa.SetPosition(player.Position.ToString());
            playa.SetFavourite(false);
            return playa;
        }
        private void SetFavourite(Player player)
        {
            if (FavouritePlayers != null)
            {
                foreach (var favName in FavouritePlayers)
                {
                    if (player.Name == favName)
                    {
                        player.Favourite = true;
                        return;
                    }
                }
            }
            player.Favourite = false;
            return;
        }

        private void SetArrowImages()
        {
            var picUp = FMClassLib.OOPpraktikum.ArrowUP;
            var picDown = FMClassLib.OOPpraktikum.ArrowDOWN;

            btnToAll.BackgroundImageLayout = ImageLayout.Zoom;
            btnToFavourite.BackgroundImageLayout = ImageLayout.Zoom;

            btnToAll.BackgroundImage = picUp;
            btnToFavourite.BackgroundImage = picDown;
        }

        private void btnToFavourite_Click(object sender, EventArgs e)
        {
            try
            {
                bool favourites = true;
                IList<ctrlPlayerForFav> listToMove = GetSelectedPlayersFromPanel(panelNonFavourites);
                CheckNumberOfFavourites(listToMove);
                SetFavouritesIcon(listToMove, favourites);
                MovePlayers(listToMove, panelNonFavourites, panelFavourites);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CheckNumberOfFavourites(IList<ctrlPlayerForFav> listToMove)
        {
            if(panelFavourites.Controls.Count + listToMove.Count > FAVOURITE_PLAYERS_MAX)
            {
                throw new Exception("Too much players");
            }
        }

        public static void MovePlayers(IList<ctrlPlayerForFav> players, FlowLayoutPanel from, FlowLayoutPanel to)
        {
            foreach (var ctrl in players)
            {
                if (ctrl.Selected == true)
                    ctrl.Unselect();
                from.Controls.Remove(ctrl);
                to.Controls.Add(ctrl);
            }
        }

        private void SetFavouritesIcon(IList<ctrlPlayerForFav> listToMove, bool favourite)
        {
            foreach (var ctrl in listToMove)
            {
                var pl = ctrl as ctrlPlayerForFav;
                pl.SetFavourite(favourite);
            }
        }

        private void btnToAll_Click(object sender, EventArgs e)
        {
            bool favourite = false;
            IList<ctrlPlayerForFav> listToMove = GetSelectedPlayersFromPanel(panelFavourites);
            SetFavouritesIcon(listToMove, favourite);
            MovePlayers(listToMove, panelFavourites, panelNonFavourites);
        }

        private IList<ctrlPlayerForFav> GetSelectedPlayersFromPanel(Panel panel)
        {
            IList<ctrlPlayerForFav> list = new List<ctrlPlayerForFav>();
            foreach (var item in panel.Controls)
            {
                var pl = item as ctrlPlayerForFav;
                if (pl.Selected == true)
                {
                    list.Add(pl);
                }
            }
            return list;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            NextForm();
            await SaveFavouritePlayersAsync();
        }

        private void panelNonFavourites_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void panelNonFavourites_DragDrop(object sender, DragEventArgs e)
        {
            ctrlPlayerForFav ctrl = (ctrlPlayerForFav)e.Data.GetData(typeof(ctrlPlayerForFav));
            IList<ctrlPlayerForFav> listToMove = GetSelectedPlayersFromPanel(panelFavourites);
            bool toFavourites = true;
            listToMove.Add(ctrl);
            SetFavouritesIcon(listToMove, toFavourites);
            MovePlayers(listToMove, panelFavourites, panelNonFavourites);
        }

        private void panelFavourites_DragDrop(object sender, DragEventArgs e)
        {
            IList<ctrlPlayerForFav> listToMove = GetSelectedPlayersFromPanel(panelFavourites);
            ctrlPlayerForFav ctrl = (ctrlPlayerForFav)e.Data.GetData(typeof(ctrlPlayerForFav));
            bool toFavourites = true;
            try
            {
                listToMove.Add(ctrl);
                CheckNumberOfFavourites(listToMove);
                SetFavouritesIcon(listToMove, toFavourites);
                MovePlayers(listToMove, panelNonFavourites, panelFavourites);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.ShowDialog();
            this.Hide();
        }
    }
}
