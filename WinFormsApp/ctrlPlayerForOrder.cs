using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Properties;

namespace WinFormsApp
{
    public enum TypeOfList
    {
        Cards,
        Goals
    }
    public partial class ctrlPlayerForOrder : UserControl
    {
        public ctrlPlayerForOrder()
        {
            InitializeComponent();
            pictureBox1.Image = FMClassLib.OOPpraktikum.PlayerDefault;
        }

        public void SetNameAndNumber(string name, int number)
        {
            lblName.Text = name;
            lblNumber.Text = number.ToString();
        }
        public void SetTypeAndNumber(TypeOfList type, int number)
        {
            lblOccurences.Text = number.ToString();
            switch (type)
            {
                case TypeOfList.Cards:
                    lblListType.Text = "Number of cards:";
                    break;
                case TypeOfList.Goals:
                    lblListType.Text = "Number of goals";
                    break;
                default:
                    break;
            }
        }
        public void SetPicture(string path)
        {
            pictureBox1.ImageLocation = path;
            
        }
    }
}
