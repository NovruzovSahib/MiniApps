namespace Parametrli_ve_dongusuz_Metod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Mynewnumber(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            //changemyname(textBox1.Text,Convert.ToInt32(textBox2.Text));

            //trapesiyasahe(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox3.Text));
            //defaultdeyer();
            //defauldeyer2("Sahib", 26);

        }

        public void Mynewnumber(int x, int y)
        {
            int z = x + y;
            label1.Text=z.ToString();

        }

        public void changemyname(string name,int age)
        {

            label1.Text = name + " " + age.ToString();
            listBox1.Items.Add(name + " " + age.ToString());
        }

        public void trapesiyasahe(double a, double b, double c,double d)
        {

            double S = ((a + b) / 2) * Math.Sqrt((c * c) - ((((a - b) * (a - b)) + (c * c) - (d * d)) / (2 * (a - b))) * ((((a - b) * (a - b)) + (c * c) - (d * d)) / (2 * (a - b))));
            label2.Text=(S.ToString("0.00")); 
        }
        public void defaultdeyer(string name="Sahib",int age1=26, char course='2')
        {
            name = textBox1.Text;
            age1=Convert.ToInt32(textBox2.Text);
            course = Convert.ToChar(textBox3.Text);

            listBox1.Items.Add(name+" "+age1+" " + course);
        }

        public void defauldeyer2(string name,int age)
        {
            listBox1.Items.Add(name + age);

        }


    }
}