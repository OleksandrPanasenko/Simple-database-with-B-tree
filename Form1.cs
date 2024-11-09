namespace Database_B_tree
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public static Database database;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            Form2.Instance = new Form2();
            Form3.Instance = new Form3();
            Form4.Instance = new Form4();
            Form5.Instance = new Form5();
            Form6.Instance = new Form6();
            database = new Database("Info.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Instance.Hide();
            Form4.Instance.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instance.Hide();
            Form2.Instance.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Instance.Hide();
            Form3.Instance.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Instance.Hide();
            Form5.Instance.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Instance.Hide();
            Form6.Instance.Show();
        }
    }
}
