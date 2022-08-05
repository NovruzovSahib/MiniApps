using System.Collections;
namespace Parametrsiz_ve_dongusuz_Metod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // UpperWord();
            //countmynum();
            //changebackground();
            //Addlistbox();
            //Sumandminus();
            //randomlist();
            //randomoperation();
            //changelabelname();
        }

       public void UpperWord()
        {
            string s;
            s = textBox1.Text;
            label1.Text = s.ToUpper();

        }

        public void countmynum()
        {
            string s;
            s = textBox1.Text;
            label1.Text = s.Count().ToString();
        }

        public void changebackground()
        {
            BackColor = Color.Red;

        }

        public void Addlistbox()
        {
            string s;
            s = textBox1.Text;
            listBox1.Items.Add(s);

        }

        public void Sumandminus()
        {
            int x;
            int y;
            int z;
            int t;
            x = Convert.ToInt32(textBox1.Text);
            y= Convert.ToInt32(textBox2.Text);
            z = x + y;
            t = Math.Abs(x-y);

            label1.Text=z.ToString();
            label2.Text=t.ToString();

        }
        public void randomlist()
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                int x = r.Next(20);
                listBox1.Items.Add(x);
            }
        }
        public void randomoperation()
        {
            Random r1 = new Random();

            for (int i = 0; i < 5; i++)
            {
                int x = r1.Next(10);
                listBox1.Items.Add(x);
                listBox2.Items.Add(x - 1);
               
            }


        }
        public void changelabelname()
        {
            label1.Text = "Sahib";
        }


    }
}