using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticky_tick
{
    public partial class Form1 : Form
    {
        int vx = 5;
        int vy = 0;

        int vx1 = 5;
        int vy1 = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            int x1 = pictureBox1.Location.X;
            int y1 = pictureBox1.Location.Y;

            
            if (x >= 200)
            {
                vx = 0;
                vy = 5;
            }
            if (y >= 150)
            {
                vx = -5;
                vy = 0;
            }
            if (y >= 150 && x <= 0)
            {
                vx = 0;
                vy = -5;
            }
            if (y <= 0 && x <= 150)
            {
                vx = 5;
                vy = 0;
            }
            pictureBox1.Location = new Point((x + vx), (y+vy));


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
