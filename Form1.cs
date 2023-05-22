using System;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;
using Timer = System.Windows.Forms.Timer;

namespace Tap_The_Circles_
{
    public partial class Form1 : Form
    {
        private int balance;

        public Form1(int balance)
        {
            InitializeComponent();
            this.balance = balance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(balance);
            Form3 form3 = new Form3("",0,0, balance);
            Form4 form4 = new Form4();
            Form5 form5 = new Form5();
            form2.Hide();
            form3.Hide();
            form4.Hide();
            form5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(balance);
            newForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6(balance);
            newForm.Show();
            Hide();
        }
    }
}