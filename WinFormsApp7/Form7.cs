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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkış yapmak istediğine emin misin?", "UYARI!", MessageBoxButtons.OKCancel);
            if (sonuc == DialogResult.OK)
            {
                Form5.ActiveForm.Close();
            }
        }
    }
}
