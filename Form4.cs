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
    public partial class Form4 : Form
    {
        private int balance;
        private int score;
        private int total;

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(int score, int balance)
        {
            InitializeComponent();
            this.score = score;
            this.balance = balance;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "Score: " + score.ToString();
            total += score;
            balance += total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1(balance);
            newForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(balance);
            newForm.Show();
            Hide();
        }
    }
}
