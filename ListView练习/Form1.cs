using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView.View = View.Details;//默认样式
            listView.SmallImageList = this.imgsml;
            listView.LargeImageList = this.imgbig;
            ListViewItem item = new ListViewItem("头像", 0);
            listView.Items.Add(item);
        }

        private void btnbig_Click(object sender, EventArgs e)
        {
            this.listView.View = View.LargeIcon;
        }

        private void btnsml_Click(object sender, EventArgs e)
        {
            this.listView.View = View.SmallIcon;
        }

        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnsml_Click(null, null) ;
        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnbig_Click(null, null);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
