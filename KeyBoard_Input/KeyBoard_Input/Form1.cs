using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Keyboard_Input
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Interaction.InputBox("Enter your text here");
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            Random Randomarino = new Random();
            int x = Randomarino.Next(0, 500);

            Random rrr = new Random();
            int y = rrr.Next(0, 500);

            if (e.KeyCode == Keys.A)
            {
                MessageBox.Show("You have pressed the A key");
            }
            if (e.KeyCode == Keys.C)
            {
                label1.ForeColor = Color.Red;
            }
            if (e.KeyCode == Keys.T)
            {
                label1.Text = Interaction.InputBox("Input text");
            }
            if (e.KeyCode == Keys.D)
            {
                label1.ForeColor = Color.Black;
                label1.Text = "Label1";
            }
            if (e.KeyCode == Keys.L)
            {
                label1.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.R)
            {
                //95 121
                label1.Location = new Point(95, 121);
                label1.ForeColor = (Color.Black);
                label1.Text = "label1";
            }
            if (e.KeyCode == Keys.S)
            {
                timer1.Start();
            }
            if (e.KeyCode == Keys.Up)
            {
                int x1 = button1.Location.X;
                int y1 = button1.Location.Y;
                button1.Location = new Point(x1 , y1-1);
            }
            if (e.KeyCode == Keys.Right)
            {
                int x2 = button1.Location.X;
                int y2 = button1.Location.Y;
                button1.Location = new Point(x2 + 1, y2);
            }
            if (e.KeyCode == Keys.Left)
            {
                int x3 = button1.Location.X;
                int y3 = button1.Location.Y;
                button1.Location = new Point(x3 - 1, y3);
            }
            if (e.KeyCode == Keys.Down)
            {
                int x4 = button1.Location.X;
                int y4 = button1.Location.Y;
                button1.Location = new Point(x4  , y4 +1);
            }

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                timer1.Enabled = false;


            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
     
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = button1.Location.X;
            int y = button1.Location.Y;
            button1.Location = new Point(x - 1, y);


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void button2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

    }
}
    