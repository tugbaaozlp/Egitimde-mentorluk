namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yeniform = new Form2();
            yeniform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 yeniform = new Form3();
            yeniform.Show();
        }
    }
}
