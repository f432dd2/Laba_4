namespace Laba_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("������");
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("����");
        }
    }
}