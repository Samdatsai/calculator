namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "-";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num=0;
            if (label2.Text == "+") { num = double.Parse(textBox2.Text) + double.Parse(textBox1.Text); }
            if (label2.Text == "-") { num = double.Parse(textBox1.Text) - double.Parse(textBox2.Text); }
            if (label2.Text == "*") { num = double.Parse(textBox1.Text) * double.Parse(textBox2.Text); }
            if (label2.Text == "/") { num = double.Parse(textBox1.Text) / double.Parse(textBox2.Text); }
            textBox3.Text = num.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "+";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "*";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "/";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}