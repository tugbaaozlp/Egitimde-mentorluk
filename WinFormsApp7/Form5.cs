﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 yeniform = new Form6();
            yeniform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 yeniform = new Form7();
            yeniform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 yeniform = new Form4();
            yeniform.Show();
        }
    }
}
