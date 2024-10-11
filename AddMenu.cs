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
    }
}
