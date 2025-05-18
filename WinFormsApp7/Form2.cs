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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 yeniform = new Form4();
            yeniform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 yeniform = new Form8();
            yeniform.Show();
        }
    }
}
