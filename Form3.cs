using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace Tap_The_Circles_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private int borderHeight = 100;
        private int finalBorderHeight = 1080;
        private int step = 8;
        private int score = 0;
        Random random = new Random();

        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.Height = borderHeight;
            timer1.Start();
        }

        private void Panel1_Resize(object sender, EventArgs e)
        {
            borderHeight = panel1.Height;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (borderHeight < finalBorderHeight)
            {
                borderHeight += step;
                panel1.Height = borderHeight;
                panel1.Resize += Panel1_Resize;
            }
            else
            {
                timer1.Stop();
            }

            AddBall();
        }

        private void AddBall()
        {
            if (panel1.Top < this.ClientRectangle.Top) return;
            PictureBox ball = new PictureBox();

            ball.Image = Properties.Resources.black_ball;
            ball.SizeMode = PictureBoxSizeMode.Zoom;
            ball.BackColor = Color.Transparent;
            ball.Size = new Size(65, 65);

            int x = random.Next(this.ClientRectangle.Left + ball.Width, this.ClientRectangle.Right - ball.Width);
            int y = random.Next(borderHeight + ball.Height, this.ClientRectangle.Height - ball.Height);
            ball.Location = new Point(x, y);
            ball.Click += Ball_Click;

            this.Controls.Add(ball);
        }

        private void Ball_Click(object sender, EventArgs e)
        {
            score++;
            label1.Text = "Score: " + score.ToString();
            PictureBox ball = (PictureBox)sender;
            this.Controls.Remove(ball);
        }
    }
}
