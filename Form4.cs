﻿using System;
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

        private int borderHeight = 100;
        private int finalBorderHeight = 1080;
        private int step = 16;

        private void Form4_Load(object sender, EventArgs e)
        {
            panel1.Height = borderHeight;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (borderHeight < finalBorderHeight)
            {
                borderHeight += step;
                panel1.Height = borderHeight;
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
