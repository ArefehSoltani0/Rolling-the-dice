using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mog
{
    public partial class Form1 : Form
    {
        Random dd = new Random();
        int x;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = dd.Next(1, 7);
            label1.Text = x.ToString();
            if (x == 6)
            {
                pictureBox1.Image = Properties.Resources._6;
                MessageBox.Show("هوراااااااااااا؛؛");
            }
            if (x == 1)
            {
                pictureBox1.Image = Properties.Resources._1;
            }
            if (x == 2)
            {
                pictureBox1.Image = Properties.Resources._2;
            }
            if (x == 3)
            {
                pictureBox1.Image = Properties.Resources._3;
            }
            if (x == 4)
            {
                pictureBox1.Image = Properties.Resources._4;
            }
            if (x == 5)
            {
                pictureBox1.Image = Properties.Resources._5;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
