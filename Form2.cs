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
    public partial class Form2 : Form
    {
        public static Form2 Instance;
        public Form2()
        {
            InitializeComponent();
            Instance = this;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Instance.Hide();
            Form1.Instance.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string index = textBox1.Text;
            RecordDatabase record = Form1.database.GetRecord(index);
            if (record != null)
            {
                label5.Text = record.place.ToString();
                //label6.Text = record.place.ToString();
                textBox2.Text = record.Index;
                textBox3.Text = record.Text;
            }
            else
            {
                MessageBox.Show("Record wasn't found!");
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.Instance.Close();
            Form3.Instance.Close();
            Form4.Instance.Close();
            Form5.Instance.Close();
            Form6.Instance.Close();
        }
    }
}
