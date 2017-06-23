using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 选项卡
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbp1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbp1.SelectedIndex = 2;
            textBox3.Text = "学生姓名"+textBox1.Text.Trim();
            textBox3.Text += "学生年龄" + textBox2.Text.Trim();
            textBox3.Text += "学生出生日期" + dateTimePicker1.Text.Trim();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
