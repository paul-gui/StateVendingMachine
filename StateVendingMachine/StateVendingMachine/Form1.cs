using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateVendingMachine
{
    public partial class Form1 : Form
    {
        readonly Machine machine;
        readonly Bitmap coin5 = new Bitmap(Properties.Resources.coin5);
        readonly Bitmap coin5_outline = new Bitmap(Properties.Resources.coin5_outline);
        readonly Bitmap coin5_pressed = new Bitmap(Properties.Resources.coin5_pressed);
        readonly Bitmap coin10 = new Bitmap(Properties.Resources.coin10);
        readonly Bitmap coin10_outline = new Bitmap(Properties.Resources.coin10_outline);
        readonly Bitmap coin10_pressed = new Bitmap(Properties.Resources.coin10_pressed);
        readonly Bitmap coin20 = new Bitmap(Properties.Resources.coin20);
        readonly Bitmap coin20_outline = new Bitmap(Properties.Resources.coin20_outline);
        readonly Bitmap coin20_pressed = new Bitmap(Properties.Resources.coin20_pressed);
        public Form1()
        {
            InitializeComponent();
            machine = new Machine(lblCredit, lblChange, lblDrink);
        }

        private void pcbCoin_MouseEnter(object sender, EventArgs e)
        {
            switch (int.Parse((sender as PictureBox).Tag.ToString()))
            {
                case 5:
                    pcbCoin5.Image = coin5_outline;
                    break;
                case 10:
                    pcbCoin10.Image = coin10_outline;
                    break;
                case 15:
                    pcbCoin15.Image = coin20_outline;
                    break;
                default:
                    break;
            }
        }

        private void pcbCoin_MouseLeave(object sender, EventArgs e)
        {
            switch (int.Parse((sender as PictureBox).Tag.ToString()))
            {
                case 5:
                    pcbCoin5.Image = coin5;
                    break;
                case 10:
                    pcbCoin10.Image = coin10;
                    break;
                case 15:
                    pcbCoin15.Image = coin20;
                    break;
                default:
                    break;
            }
        }

        private void pcbCoin_MouseDown(object sender, MouseEventArgs e)
        {
            switch (int.Parse((sender as PictureBox).Tag.ToString()))
            {
                case 5:
                    pcbCoin5.Image = coin5_pressed;
                    break;
                case 10:
                    pcbCoin10.Image = coin10_pressed;
                    break;
                case 15:
                    pcbCoin15.Image = coin20_pressed;
                    break;
                default:
                    break;
            }
        }

        private void pcbCoin_MouseUp(object sender, MouseEventArgs e)
        {
            switch (int.Parse((sender as PictureBox).Tag.ToString()))
            {
                case 5:
                    pcbCoin5.Image = coin5_outline;
                    machine.Added5c();
                    break;
                case 10:
                    pcbCoin10.Image = coin10_outline;
                    machine.Added10c();
                    break;
                case 15:
                    pcbCoin15.Image = coin20_outline;
                    machine.Added15c();
                    break;
                default:
                    break;
            }
        }
    }
}
