using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_03_03_Пироговський.Old_Forms
{
    public partial class Login : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        public Login()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            guna2CustomGradientPanel1.MouseDown += Login_MouseDown;
            guna2CustomGradientPanel1.MouseMove += Login_MouseMove;
            guna2CustomGradientPanel1.MouseUp += Login_MouseUp;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = Point.Subtract(Cursor.Position, new Size(lastCursor));
                this.Location = Point.Add(lastForm, new Size(delta));
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
