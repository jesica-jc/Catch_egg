using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
        Random r = new Random();
        int c = 0;
        int m = 0;
        private void fall(PictureBox egg, int speed)
        {
            if(egg.Top <= this.Height)
            {
                egg.Top += speed;
            }
            else if(egg.Top > this.Height)
            {
                egg.Location = new Point((r.Next(100, 700)), 0);
                m++;
                label4.Text = m.ToString();
            }
            if(egg.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                egg.Location = new Point((r.Next(100, 700)), 0);
                c++;
                label2.Text = c.ToString();

            }
           
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Left += -3;
            }
            if(e.KeyCode == Keys.Right)
            {
                pictureBox1.Left += 3;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fall(egg1, 4);
            fall(egg2, 7);
            fall(egg3, 3);

        }
    }
}
