using System;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;
using Timer = System.Windows.Forms.Timer;

namespace Tap_The_Circles_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 newForm = new Form2();
            newForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            Hide();
        }
    }
}