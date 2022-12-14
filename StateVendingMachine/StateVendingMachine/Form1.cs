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
        Machine machine;
        Bitmap coin5 = new Bitmap(Properties.Resources.coin5);
        Bitmap coin5_outline = new Bitmap(Properties.Resources.coin5_outline);
        Bitmap coin10 = new Bitmap(Properties.Resources.coin10);
        Bitmap coin10_outline = new Bitmap(Properties.Resources.coin10_outline);
        Bitmap coin15 = new Bitmap(Properties.Resources.coin15);
        Bitmap coin15_outline = new Bitmap(Properties.Resources.coin15_outline);
        Bitmap coin5_pressed = new Bitmap(Properties.Resources.coin5_pressed);
        Bitmap coin10_pressed = new Bitmap(Properties.Resources.coin10_pressed);
        Bitmap coin15_pressed = new Bitmap(Properties.Resources.coin15_pressed);
        public Form1()
        {
            InitializeComponent();
            machine = new Machine(lblCredit, lblChange, lblDrink);
        }

        private void btn5c_Click(object sender, EventArgs e)
        {
            machine.Added5c();
        }

        private void btn10c_Click(object sender, EventArgs e)
        {
            machine.Added10c();
        }

        private void btn15c_Click(object sender, EventArgs e)
        {
            machine.Added15c();
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
                    pcbCoin15.Image = coin15_outline;
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
                    pcbCoin15.Image = coin15;
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
                    pcbCoin15.Image = coin15_pressed;
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
                    pcbCoin15.Image = coin15_outline;
                    machine.Added15c();
                    break;
                default:
                    break;
            }
        }
    }
}
