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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi= textBox1.Text;
            string sifre= textBox2.Text;
            if (kullaniciadi == "enessulak42")
            {
                if (sifre == "enes4242")
                {

                    Form7 yeniform = new Form7();
                    yeniform.Show();
                }
                else
                {
                    label1.Text = "Şifren Yanlış!";
                }

            }
            else {
                label1.Text = " Kullanıcı Adın Yanlış!";
            }



          
        }
    }
}
