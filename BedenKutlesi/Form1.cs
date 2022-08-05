namespace BedenKutlesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            float ceki, boy, cem;

            ceki= Convert.ToSingle(textBox1.Text); 
            boy= Convert.ToSingle(textBox2.Text);
            cem = ceki / (boy * boy);
            label4.Text= cem.ToString();

            if (cem>25)
            {
                MessageBox.Show("Artıq çəkidən əziyyət çəkirsiniz");
            }
            else if (cem>18 && cem<25)
            {
                MessageBox.Show("Çəkiniz normaldır");
            }
            else if (cem<18)
            {
                MessageBox.Show("Zəifsiniz");
            }
        }
    }
}