namespace MiniAtm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 1000;
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salam, Zəhmət olmasa birini secin");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = 0; 
            try
            {
               b = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                label4.Text=a.ToString();
                
            }
            if (b>=1000)
            {
                MessageBox.Show("Asagi deyer daxil edin");
            }
            else
            {
                label4.Text = (a + b).ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            int c = 0;
            try
            {
                c = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                label4.Text = a.ToString();

            }
            if (c>a)
            {
                MessageBox.Show("Asagi deyer daxil edin");
            }
            else
            {
                    label4.Text = (a - c).ToString();

            }
        }
    }
}