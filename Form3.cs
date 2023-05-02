using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        private int finalBorderHeight = 1051;
        private int borderHeight;
        private int score = 0;
        private int timer1ticks = 0;
        private int timer2ticks = 0;

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
                timer2.Stop();
                Form4 form4 = new Form4(score);
                form4.Show();
                this.Close();
            }
            timer1ticks += 1;
        }

        private void DrawBall()
        {
            // Создаем новый объект Graphics для отрисовки на форме
            Graphics g = this.CreateGraphics();
            Random rnd = new Random();

            if (borderHeight + 65 >= this.ClientSize.Height)
            {
                timer1.Stop();
                timer2.Stop();
                Form4 form4 = new Form4(score);
                form4.Show();
                this.Close();
            }
            else
            {
                int x = rnd.Next(0, this.ClientSize.Width - 65);
                int y = rnd.Next(borderHeight + 65, this.ClientSize.Height);
                g.FillEllipse(Brushes.Black, x, 1051-y, 65, 65);
            }

            // Освобождаем объект Graphics
            g.Dispose();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DrawBall();
            timer2ticks += 1;
        }
    }
}
