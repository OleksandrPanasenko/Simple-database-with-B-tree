using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_B_tree
{
    public partial class Form3 : Form
    {
        public static Form3 Instance;
        public Form3()
        {
            InitializeComponent();
            Instance = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Instance.Hide();
            Form1.Instance.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Node.FileAccesses = 0;
            try
            {
                RecordDatabase record = Form1.database.GetRecord((int)numericUpDown1.Value);
                textBox2.Text = record.Index;
                textBox3.Text = record.Text;
                label6.Text = Node.FileAccesses.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.Instance.Close();
            Form2.Instance.Close();
            Form4.Instance.Close();
            Form5.Instance.Close();
            Form6.Instance.Close();
        }
    }
}
