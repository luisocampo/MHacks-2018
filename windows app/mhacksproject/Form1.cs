using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mhacksproject
{
    public partial class mHacksProject : Form
    {
        public mHacksProject()
        {
            InitializeComponent();
            comboBox1.Items.Add("1111048625");
            comboBox1.Items.Add("1247100041");
        }
     

        private void mHacksProject_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("1247100041"))
            {
                label6.Text = "Apple Cider";
                dateTimePicker2.Enabled = false;
                dateTimePicker1.Enabled = true;
                pictureBox1.Visible = false;
            }
            else
            {
                label6.Text = "Apple";
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = true;
                pictureBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("1247100041"))
            {
                pictureBox1.Image = mhacksproject.Properties.Resources.apple_cider_qr;
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Image = mhacksproject.Properties.Resources.appleqr;
                pictureBox1.Visible = true;
            }
        }
    }
}
