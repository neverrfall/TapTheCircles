using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tap_The_Circles_
{
    public partial class Form6 : Form
    {
        private int balance;
        public static bool IsRedThemeUnlocked { get; set; } = false;
        public static bool IsPinkThemeUnlocked { get; set; } = false;
        public static bool IsGreenThemeUnlocked { get; set; } = false;

        public Form6(int balance)
        {
            InitializeComponent();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            this.balance = balance;
            label1.Text = "You have " + balance + " Circ-coins";
        }

        private void button2_Click(object sender, EventArgs e) // Покупка розового
        {
            if (IsPinkThemeUnlocked == false)
            {
                if (balance >= 0) ;
                {
                    balance -= 900;
                    IsPinkThemeUnlocked = true;
                    Form3.SelectedColor = Color.FromArgb(255, 0, 245);
                    Form3.SelectedBallColor = Color.FromArgb(116, 0, 111);
                    label1.Text = "You have " + balance + " Circ-coins";
                }
            }
            else
            {
                Form3.SelectedColor = Color.FromArgb(255, 0, 245);
                Form3.SelectedBallColor = Color.FromArgb(116, 0, 111);
            }
        }

        private void button1_Click(object sender, EventArgs e) // Покупка красного
        {
            if (IsRedThemeUnlocked == false)
            {
                if (balance >= 0) ;
                {
                    balance -= 450;
                    IsRedThemeUnlocked = true;
                    Form3.SelectedColor = Color.FromArgb(255, 0, 0);
                    Form3.SelectedBallColor = Color.FromArgb(160, 0, 0);
                    label1.Text = "You have " + balance + " Circ-coins";
                }
            }
            else
            {
                Form3.SelectedColor = Color.FromArgb(255, 0, 0);
                Form3.SelectedBallColor = Color.FromArgb(160, 0, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e) // Покупка зеленого
        {
            if (IsGreenThemeUnlocked == false)
            {
                if (balance >= 0) ;
                {
                    balance -= 500;
                    IsGreenThemeUnlocked = true;
                    Form3.SelectedColor = Color.FromArgb(20, 255, 0);
                    Form3.SelectedBallColor = Color.FromArgb(115, 186, 89);
                    label1.Text = "You have " + balance + " Circ-coins";
                }
            }
            else
            {
                Form3.SelectedColor = Color.FromArgb(20, 255, 0);
                Form3.SelectedBallColor = Color.FromArgb(115, 186, 89);
            }
        }

        private void button7_Click(object sender, EventArgs e) // Выход в меню
        {
            Form1 newForm = new Form1(balance);
            newForm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e) // Просмотр красного
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e) // Конец просмотра красного
        {
            pictureBox2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e) // Просмотр розового
        {
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e) // Конец просмотра розового
        {
            pictureBox3.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e) // Просмотр зеленого
        {
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e) // Конец просмотра зеленого
        {
            pictureBox4.Visible = false;
        }
    }
}
