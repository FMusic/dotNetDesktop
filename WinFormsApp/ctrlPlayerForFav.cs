using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using FMClassLib.OOP.NETpraktikum;

namespace WinFormsApp
{
    public partial class ctrlPlayerForFav : UserControl
    {
        public static int NumberOfSelectedPlayers { get; set; }
        public bool Selected { get; set; }
        public PlayerPics Pics { get; set; }
        public ctrlPlayerForFav(PlayerPics pics)
        {
            InitializeComponent();
            pbPicture.Image = FMClassLib.OOPpraktikum.PlayerDefault;
            Pics = pics;
        }
        public void SetName(string name)
        {
            lblName.Text = name;
        }
        public string GetName()
        {
            return lblName.Text;
        }
        public void SetNumber(string number)
        {
            lblNumber.Text = number;
        }
        public void SetPicture(string path)
        {
            if (path!= null)
            {
                pbPicture.ImageLocation = path;
            }
            else
            {
                pbPicture.Image = null;
            }
        }
        public void SetPosition(string position)
        {
            lblPosition.Text = position;
        }
        public void SetCaptain(bool captain)
        {
            if (captain == false)
            {
                lblCaptain.Hide();
            }
        }
        public void SetFavourite(bool favourite)
        {
            if (favourite == false)
            {
                pbFavourite.Hide();
            }
            else
            {
                pbFavourite.Show();
            }
        }
        private void Player_Click(object sender, EventArgs e)
        {
            if(this.BackColor == Color.Cornsilk)
            {
                this.BackColor = Color.Aqua;
                this.Focus();
                NumberOfSelectedPlayers++;
                Selected = true;
            }
            else
            {
                this.BackColor = Color.Cornsilk;
                this.Focus();
                NumberOfSelectedPlayers--;
                Selected = false;
            }
        }
        public void Unselect()
        {
            this.BackColor = Color.Cornsilk;
            this.Focus();
            NumberOfSelectedPlayers--;
            Selected = false;
        }

        private void ctrlPlayerForFav_MouseDown(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            c.DoDragDrop(this, DragDropEffects.Move);
        }

        private async void pbPicture_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.ShowDialog();
            if (ofg.FileName != null || ofg.FileName != "")
            {
                await Pics.SavePlayerPictureAsync(this.Name, ofg.FileName);
                SetPicture(Pics.GetPlayerPic(Name));
            }
            else
            {
                MessageBox.Show("You haven't choose a picture");
            }
        }
    }
}
