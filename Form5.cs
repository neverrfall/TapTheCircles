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
    public partial class Form5 : Form
    {
        private int balance;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(balance);
            Form2 form2 = new Form2(balance);
            Form3 form3 = new Form3("", 0, 0, balance);
            Form4 form4 = new Form4();
            form1.Close();
            form2.Close();
            form3.Close();
            form4.Close();
            this.Close();
        }
    }
}
