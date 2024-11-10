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
    public partial class Form6 : Form
    {
        public static Form6 Instance;
        public Form6()
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
            if (checkBox1.Checked)
            {

            }
            Node.FileAccesses = 0;
            button1.Enabled = false;
            if (radioButton1.Checked)
                {
                    Form1.database.FillDatabase((int)numericUpDown1.Value);
                }
            else if (radioButton2.Checked)
            {
                Form1.database.FillDatabaseBrainrot((int)numericUpDown1.Value);
            }
            else
            {
                MessageBox.Show("Select radiobutton!");
            }
            label6.Text = Node.FileAccesses.ToString();
            button1.Enabled = true;
            
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.Instance.Close();
            Form2.Instance.Close();
            Form3.Instance.Close();
            Form4.Instance.Close();
            Form5.Instance.Close();
        }
    }
}
