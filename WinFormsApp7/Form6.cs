using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 yeniform = new Form7();
            yeniform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 yeniform = new Form5();
            yeniform.Show();
        }
    }
}
