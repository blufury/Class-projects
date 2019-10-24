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
    public partial class Form2 : Form
    {
        int hour = 8;
        int min = 0;
        int sec = 0;
        Timer timer = new Timer();
        Label label = new Label();
        int counter = 1;
        public Form2()
        {
            InitializeComponent();


            timer.Tick += new EventHandler(timer1_Tick); // Everytime timer ticks, timer_Tick will be called
            timer.Interval = (1000) * (1);              // Timer will tick evert second
            timer.Enabled = false;                       // Enable the timer

            label.Location = new Point(100, 100);
            label.AutoSize = true;
            label.Text = String.Empty;

            this.Controls.Add(label);


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            sec -= 1;
            if (sec < 0)
            {
                min -= 1;
                sec = 59;
                if (min < 0)
                {
                    hour -= 1;
                    min = 59;
                 
                }
            }
            hourLabel.Text = hour.ToString();
            minLabel.Text = min.ToString();
            secondLabel.Text = sec.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            hour = 8;
            min = 0;
            sec = 0;
            hourLabel.Text = hour.ToString();
            minLabel.Text = min.ToString();
            secondLabel.Text = sec.ToString();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Form1();
            login.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter == 2)
            {
                name2.Visible = true;
                type2.Visible = true;
                job2.Visible = true;
                bank2.Visible = true;
                checkBox2.Visible = true;
            }
            else if (counter == 3)
            {
                name3.Visible = true;
                type3.Visible = true;
                job3.Visible = true;
                bank3.Visible = true;
                checkBox3.Visible = true;
            }
            else if (counter == 4)
            {
                name4.Visible = true;
                type4.Visible = true;
                job4.Visible = true;
                bank4.Visible = true;
                checkBox4.Visible = true;
            }
            else if (counter == 5)
            {
                name5.Visible = true;
                type5.Visible = true;
                job5.Visible = true;
                bank5.Visible = true;
                checkBox5.Visible = true;
            }
            else if (counter == 6)
            {
                name6.Visible = true;
                type6.Visible = true;
                job6.Visible = true;
                bank6.Visible = true;
                checkBox6.Visible = true;
            }
            else if (counter == 7)
            {
                name7.Visible = true;
                type7.Visible = true;
                job7.Visible = true;
                bank7.Visible = true;
                checkBox7.Visible = true;
            }
            else if (counter == 8)
            {
                name8.Visible = true;
                type8.Visible = true;
                job8.Visible = true;
                bank8.Visible = true;
                checkBox8.Visible = true;
            }
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter--;
            if (counter == 2)
            {
                name2.Visible = false;
                type2.Visible = false;
                job2.Visible = false;
                bank2.Visible = false;
                checkBox2.Visible = false;
            }
            else if (counter == 3)
            {
                name3.Visible = false;
                type3.Visible = false;
                job3.Visible = false;
                bank3.Visible = false;
                checkBox3.Visible = false;
            }
            else if (counter == 4)
            {
                name4.Visible = false;
                type4.Visible = false;
                job4.Visible = false;
                bank4.Visible = false;
                checkBox4.Visible = false;
            }
            else if (counter == 5)
            {
                name5.Visible = false;
                type5.Visible = false;
                job5.Visible = false;
                bank5.Visible = false;
                checkBox5.Visible = false;
            }
            else if (counter == 6)
            {
                name6.Visible = false;
                type6.Visible = false;
                job6.Visible = false;
                bank6.Visible = false;
                checkBox6.Visible = false;
            }
            else if (counter == 7)
            {
                name7.Visible = false;
                type7.Visible = false;
                job7.Visible = false;
                bank7.Visible = false;
                checkBox7.Visible = false;
            }
            else if (counter == 8)
            {
                name8.Visible = false;
                type8.Visible = false;
                job8.Visible = false;
                bank8.Visible = false;
                checkBox8.Visible = false;
            }
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sName = null;
            string jType = null;
            string job = null;
            string bank = null;
            if (checkBox1.Checked == true)
            {
                sName = name1.Text;
                jType = type1.Text;
                job = job1.Text;
                bank = bank1.Text;
            }
            var edit = new Form3(sName, jType, job, bank);
            edit.Show();
        }
    }
}
