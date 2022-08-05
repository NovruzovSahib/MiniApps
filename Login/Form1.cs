namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            string i;
            s = textBox1.Text;
            i = maskedTextBox1.Text;

            while (true)
            {
                int count = 3;

                if (s == "Sahib" && i == "12345678")
                {
                    MessageBox.Show("You're wellcome");
                    break;
                }
                else
                {
                    if (count>0)
                    {

                        count--;

                        MessageBox.Show("Try again");
                        MessageBox.Show($"{count} haqqiniz qaldi");
                        break;


                    }
                    if (count==0)
                    {
                        MessageBox.Show("You have to login tomorrow");
                        break;
                    }
                  
                }
            }
                   
                }
              
                
                
                
                


            }

        }
    

