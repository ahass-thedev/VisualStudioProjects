using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random myGenerator = new Random();
            int x = myGenerator.Next(0, 11);
            label1.Text = "" +x;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Random gen = new Random();
            int y = gen.Next(10, 21);
            label1.Text = "" + y;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random dice = new Random();
            int d = dice.Next(1, 7);
            label1.Text = "" + d;
            if (d == 1)
            {
                MessageBox.Show("You won with 1");
            }
            if (d == 6)
            {
                MessageBox.Show("You won with 6");
            }
        }
    }
}
