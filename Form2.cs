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
    public partial class Form2 : Form
    {
        private int balance;

        public Form2(int balance)
        {
            InitializeComponent();
            this.balance = balance;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1(balance);
            newForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string difficulty = "Easy";
            int step = 8;
            int ballInterval = 1000;
            Form3 form3 = new Form3 (difficulty, step, ballInterval, balance);
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string difficulty = "Medium";
            int step = 16;
            int ballInterval = 500;
            Form3 form3 = new Form3 (difficulty, step, ballInterval, balance);
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string difficulty = "Hard";
            int step = 22;
            int ballInterval = 500;
            Form3 form3 = new Form3 (difficulty, step, ballInterval, balance);
            form3.Show();
            this.Hide();
        }
    }
}
