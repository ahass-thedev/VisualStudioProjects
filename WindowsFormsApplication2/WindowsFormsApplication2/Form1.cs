using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int x = 8;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Wingdings", 40);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "The text has changed";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label1.Text = "label1";
            label1.ForeColor = Color.Black;
            label1.Font = new Font("Microsoft Sans Serif", 8);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x++;
            label1.Font = new Font("Microsoft Sans Serif", x);

        }
    }
}
