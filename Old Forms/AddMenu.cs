using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_03_03_Пироговський
{
    public partial class AddMenu : Form
    {
        public static int Type1 = 1;
        public AddMenu()
        {
            InitializeComponent();
            pictureBox2.Parent = pictureBox1;
            pictureBox3.Parent = pictureBox1;
            pictureBox4.Parent = pictureBox1;
            pictureBox5.Parent = pictureBox1;
            pictureBox6.Parent = pictureBox1;
            pictureBox7.Parent = pictureBox1;
        }
        private void Funk1()
        {
            Add add = new Add();
            this.Hide();
            add.Show();
        }
        private void ShowCoins_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Type1 = 1;
            Funk1();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Type1 = 2;
            Funk1();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Type1 = 3;
            Funk1();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Type1 = 4;
            Funk1();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Type1 = 5;
            Funk1();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Type1 = 6;
            Funk1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu.MainList.add(new CryptoCurrency("BTC", "Bitcoin", 62000, -1.31, 3100000, 20000));
            MainMenu.MainList.add(new ShitCoin("HMSTR", "Hamster Combat Coin", 0.003, -69.96, 141, 12, 0, 0));
            MainMenu.MainList.add(new Blockchain("SOL", "Solana", 145, -3.21, 1352, 1221, "Solana Blockchain", 4));
            MainMenu.MainList.add(new MemeCoin("PEPE", "Pepe Frog Coin", 0.00011, -0.21, 135, 121, "Solana Blockchain", 40, "PEPE lovers", 1239324));
            MainMenu.MainList.add(new Coins("NOT", "Notcoin", 0.009, 1.21, 991, 124, "The Open Network", 120, "Clicker in Telegram"));
            MainMenu.MainList.RefreshDataGrid();
        }
    }
}
