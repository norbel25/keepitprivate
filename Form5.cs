using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restotestng
{
    public partial class Form5 : Form
    {
        int X, Y;
        private string type;
        public Form5(string type, string message)
        {
            InitializeComponent();
            label1.Text = message;
            this.type = type;
            switch (type)
            {
                case "success":
                    panel1.BackColor = Color.FromArgb(57, 155, 53);
                    pictureBox1.Image = Properties.Resources.check;
                    break;
                case "failed":
                    panel1.BackColor = Color.FromArgb(203, 53, 42);
                    pictureBox1.Image= Properties.Resources.x;
                    break;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Y -= 30;
            this.Location = new Point(X, Y);
            if (Y <= 940)
            {
                timer1.Stop();
                hide.Start();
            }
        }
        int yy = 100;
        private void hide_Tick(object sender, EventArgs e)
        {
            yy--;
            if (yy <= 0 )
            {
                Y += 1;
                this.Location = new Point (X, Y);
                if (Y > 800)
                {
                    hide.Stop();
                    yy = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        {
            int screenwidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenheight = Screen.PrimaryScreen.WorkingArea.Height;

            X = screenwidth - this.Width;
            Y = screenheight - this.Height;
            this.Location = new Point(X, Y);
        }
    }
}
