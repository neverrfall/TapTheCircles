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
        public Form4()
        {
            InitializeComponent();
        }

        private int score;

        public Form4(int score)
        {
            InitializeComponent();
            this.score = score;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "Score: " + score.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            Hide();
        }
    }
}
