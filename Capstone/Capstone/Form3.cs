using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone
{
    public partial class Form3 : Form
    {
        public Form3(string name, string jType, string job, string bank)
        {
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text = jType;
            textBox3.Text = job;
            textBox4.Text = bank;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
