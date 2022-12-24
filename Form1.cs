namespace insertion_sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Arr_S = textBox1.Text.Split(' ');
            int[] Arr_Int = new int[Arr_S.Length];
            for (int i = 0; i < Arr_S.Length; i++)
            {
                Arr_Int[i] = int.Parse(Arr_S[i]);
            }
            for (int i = 1; i < Arr_Int.Length; i++)
            {
                int j = i - 1;
                int tmp = Arr_Int[i];
                while (j >= 0 && Arr_Int[j] > tmp)
                {
                    Arr_Int[j + 1] = Arr_Int[j];
                    j--;
                }
                Arr_Int[j + 1] = tmp;
            }
            string SortedNum = string.Join(" ", Arr_Int);
            textBox2.Text = SortedNum;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}