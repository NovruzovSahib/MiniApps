namespace Tekcemboyukkicikeded
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            if (a % 2 == 0)
            {
                label5.Text = "Ədəd cütdür";
                if (a > b)
                {
                    label6.Text = "b-dən böyükdür";
                }
                else if (a < b)
                {
                    label6.Text = "b-dən kiçikdir";
                }
                else
                {
                    label6.Text = "b-ə bərabərdir";

                }
            }
            else if (a % 2 != 0)
            {
                label5.Text = "Ədəd təkdir";
                if (a > b)
                {
                    label6.Text = "b-dən böyükdür";
                }
                else if (a < b)
                {
                    label6.Text = "b-dən kiçikdir";
                }
                else
                {
                    label6.Text = "b-ə bərabərdir";

                }
            }
            if (b % 2 == 0)
            {
                label7.Text = "Ədəd cütdür";
                if (b > a)
                {
                    label8.Text = "a-dan böyükdür";
                }
                else if (a < b)
                {
                    label8.Text = "a-dan kiçikdir";
                }
                else
                {
                    label8.Text = "a-ya bərabərdir";

                }
            }
            else if (b % 2 != 0)
            {
                label7.Text = "Ədəd təkdir";
                if (b > a)
                {
                    label8.Text = "a-dan böyükdür";
                }
                else if (b < a)
                {
                    label8.Text = "a-dan kiçikdir";
                }
                else
                {
                    label8.Text = "a-ya bərabərdir";
                }

            }
        }
    }
}