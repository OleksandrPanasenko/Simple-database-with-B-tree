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
    public partial class Form4 : Form
    {
        public static Form4 Instance;
        public Form4()
        {
            InitializeComponent();
            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                RecordDatabase record = new RecordDatabase(textBox2.Text, textBox3.Text);
                try
                {
                    Form1.database.AddRecord(record);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fill both boxes!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Instance.Hide();
            Form1.Instance.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = Form1.database.RandomString(20);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Form1.database.RandomString(100);
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Instance.Close();
            Form2.Instance.Close();
            Form3.Instance.Close();
            Form5.Instance.Close();
            Form6.Instance.Close();
        }
    }
}
