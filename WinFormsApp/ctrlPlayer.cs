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

namespace WinFormsApp
{
    public partial class ctrlPlayer : UserControl
    {
        public static int NumberOfSelectedPlayers { get; set; }
        public bool Selected { get; set; }
        public ctrlPlayer()
        {
            InitializeComponent();
        }
        public void SetName(string name)
        {
            lblName.Text = name;
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
    }
}
