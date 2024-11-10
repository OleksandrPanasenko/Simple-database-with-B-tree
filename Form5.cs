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
    public partial class Form5 : Form
    {
        public static Form5 Instance;
        public Form5()
        {
            InitializeComponent();
            Instance = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Instance.Hide();
            Form1.Instance.Show();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.Instance.Close();
            Form2.Instance.Close();
            Form3.Instance.Close();
            Form4.Instance.Close();
            Form6.Instance.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Node.FileAccesses = 0;
                Form1.database.DeleteRecord(textBox1.Text);
                label6.Text = Node.FileAccesses.ToString();
                MessageBox.Show("Deleted succesfully!");
            } catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
