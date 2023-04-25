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
        private int step;
        private int ballInterval;

        public Form3(string difficulty, int step, int ballInterval)
        {
            InitializeComponent();
            this.step = step;
            this.ballInterval = ballInterval;

            switch (difficulty)
            {
                case "Easy":
                    // Уровень Easy
                    this.timer1.Interval = 1000;
                    this.timer2.Interval = 1000;
                    break;
                case "Medium":
                    // Уровень Medium
                    this.timer1.Interval = 1000;
                    this.timer2.Interval = 500;
                    break;
                case "Hard":
                    // Уровень Hard
                    this.timer1.Interval = 1000;
                    this.timer2.Interval = 500;
                    break;
            }
        }

        private int finalBorderHeight = 1080;
        private int borderHeight;
        private int score = 0;

        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.Height = 70;
            timer2.Interval = ballInterval;
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (borderHeight < finalBorderHeight)
            {
                panel1.Height += step;
                borderHeight = panel1.Height;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void DrawBall()
        {
            // Создаем новый объект Graphics для отрисовки на форме
            Graphics g = this.CreateGraphics();

            Random rnd = new Random();

            int x = rnd.Next(0, this.ClientSize.Width - 75);
            int y = rnd.Next(this.panel1.Height + 75, this.ClientSize.Height);

            g.FillEllipse(Brushes.Black, x, y, 65, 65);

            // Освобождаем объект Graphics
            g.Dispose();
        }


        private void Ball_Click(object sender, EventArgs e)
        {
            score++;
            label1.Text = "Score: " + score.ToString();
            PictureBox ball = (PictureBox)sender;
            this.Controls.Remove(ball);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DrawBall();
        }
    }
}
