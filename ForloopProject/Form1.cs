namespace ForloopProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //void Sumofnumbers()
        //{
        //    int n1 = 0, n2 = 1, n3, i, number;
        //    //Console.Write("Enter the number of elements: ");
        //    number = int.Parse(Console.ReadLine());
        //    Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
        //    for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
        //    {
        //        n3 = n1 + n2;
        //        Console.Write(n3 + " ");
        //        n1 = n2;
        //        n2 = n3;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            int tek = 0;
            int cut = 0;
            int eded = Convert.ToInt32(textBox1.Text);

                if (eded % 2 == 0)
                {
                    listBox2.Items.Add(eded);

                    cut++;

                    label7.Text = cut.ToString();
                }
                else if (eded != 0)
                {
                    listBox1.Items.Add(eded);
                    tek++;
                    label5.Text = tek.ToString();

                }
         

           








        }
    }
}