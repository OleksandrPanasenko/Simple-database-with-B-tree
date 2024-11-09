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
            Instance.Close();
            Form1.Instance.Show();
        }
    }
}
