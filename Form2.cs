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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string difficulty = "Easy";
            int step = 8;
            int ballInterval = 1000;
            Form3 form3 = new Form3 (difficulty, step, ballInterval);
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string difficulty = "Medium";
            int step = 16;
            int ballInterval = 500;
            Form3 form3 = new Form3 (difficulty, step, ballInterval);
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string difficulty = "Hard";
            int step = 22;
            int ballInterval = 500;
            Form3 form3 = new Form3 (difficulty, step, ballInterval);
            form3.Show();
        }
    }
}
