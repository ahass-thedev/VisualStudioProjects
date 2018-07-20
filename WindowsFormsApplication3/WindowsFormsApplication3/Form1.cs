using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int x = 50 ;
        int y = 165;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer = textBox1.Text;
            answer = textBox1.Text.ToLower();
            if (answer == "chair")
            {
                MessageBox.Show("You are correct");
            }
            else
            {
                MessageBox.Show("I don't know about that one");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                MessageBox.Show("You are correct");
            }//end if
            else
            {
                MessageBox.Show("That is scary");
            }//end else

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.Location = new Point(0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked & checkBox2.Checked == true & checkBox3.Checked == false)
            {
                MessageBox.Show("that is right");
            }
            else if (checkBox1.Checked & checkBox2.Checked == true & checkBox3.Checked == true)
            {
                MessageBox.Show("wrong");
            }
            else if (checkBox1.Checked & checkBox3.Checked == true)
            {
                MessageBox.Show("Wrong");
            }
            else if (checkBox2.Checked & checkBox3.Checked == true)
            {
                MessageBox.Show("Wrong"); 
            }
            else if (checkBox1.Checked == true)
            {
                MessageBox.Show("I said choose 2");
            }
            else if (checkBox2.Checked == true)
            {
                MessageBox.Show("I said choose 2");
            }
            else if (checkBox3.Checked == true)
            {
                MessageBox.Show("I said choose 2");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
                {
                y--;
                pictureBox1.Location = new Point(50,y);
                }
            if (radioButton5.Checked == true)
            {
                y++;
                pictureBox1.Location = new Point(50, y);
            }
            if (radioButton6.Checked == true)
            {
                x--;
                pictureBox1.Location = new Point(x, 165);
            }
            if (radioButton7.Checked == true)
            {
                x++;
                pictureBox1.Location = new Point(x, 165); 
            }
        }
    }
}
