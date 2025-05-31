namespace Hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int sonuc = sayi1 + sayi2;
            label5.Text =Convert.ToString(sonuc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int sonuc = sayi1 - sayi2;
            label5.Text = Convert.ToString(sonuc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int sonuc = sayi1 * sayi2;
            label5.Text = Convert.ToString(sonuc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            if (sayi1 ==0)
            {
                MessageBox.Show(" bu bolme isleminin sonucu tanimsizdir");
            }
            else
            {
                int sonuc = sayi1 * sayi2;
                label5.Text = Convert.ToString(sonuc);
            }
        }
    }
}
 