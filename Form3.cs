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
        private int balance;
        private List<Rectangle> balls = new List<Rectangle>();
        private int finalBorderHeight = 1051;
        private int borderHeight;
        private int score = 0;
        public static Color SelectedColor { get; set; } = Color.Black;
        public static Color SelectedBallColor { get; set; } = Color.Black;

        public Form3(string difficulty, int step, int ballInterval, int balance)
        {
            InitializeComponent();
            this.balance = balance;
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


        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.Height = 70;
            panel1.BackColor = SelectedColor;
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
                Form4 form4 = new Form4(score, balance);
                form4.Show();
                this.Close();
            }
        }

        public void DrawBall()
        {
            // Создаем новый объект Graphics для отрисовки на форме
            Graphics g = this.CreateGraphics();
            Random rnd = new Random();

            if (borderHeight + 65 >= this.ClientSize.Height)
            {
                timer1.Stop();
                timer2.Stop();
                Form4 form4 = new Form4(score, balance);
                form4.Show();
                this.Close();
            }
            else
            {
                int x, y;
                Rectangle ball;
                bool isCollision;

                do
                {
                    isCollision = false;
                    x = rnd.Next(0, this.ClientSize.Width - 65);
                    y = rnd.Next(borderHeight + 65, this.ClientSize.Height);
                    ball = new Rectangle(x, 1051 - y, 65, 65);

                    foreach (Rectangle existingBall in balls)
                    {
                        if (ball.IntersectsWith(existingBall))
                        {
                            isCollision = true;
                            break;
                        }
                    }
                } while (isCollision);

                balls.Add(ball);
                g.FillEllipse(new SolidBrush(SelectedBallColor), ball);
            }

            // Освобождаем объект Graphics
            g.Dispose();
        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Rectangle ball in balls)
            {
                if (ball.Contains(e.Location))
                {
                    balls.Remove(ball);
                    score++;
                    label1.Text = "Score: " + score;
                    Invalidate(ball);
                    break; 
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DrawBall();
        }
    }
}
