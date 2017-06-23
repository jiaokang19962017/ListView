using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewCODE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //设置listview的视图类型为列表显示
            listViewitem.View = View.Details;
            //设置关联listview的imagelist
            listViewitem.LargeImageList = this.IMGDT;//大图标
            listViewitem.SmallImageList = this.IMGSML;//小图标
            //设置listview列的标题
            listViewitem.Columns.Add("名称");
            listViewitem.Columns.Add("类型");
            listViewitem.Columns.Add("总大小");
            listViewitem.Columns.Add("可用空间");

            //向项中添加子项
            ListViewItem item = new ListViewItem("c盘",0);
            item.SubItems.Add("本地磁盘");
            item.SubItems.Add("40g");
            item.SubItems.Add("17g");
            //将添加的子项添加到listview中
            listViewitem.Items.Add(item);

        }

        private void btnsml_Click(object sender, EventArgs e)
        {
            this.listViewitem.View = View.SmallIcon;
        }

        private void btnbig_Click(object sender, EventArgs e)
        {
            this.listViewitem.View = View.LargeIcon;
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            this.listViewitem.View = View.Details;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cms_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listViewitem.View = View.LargeIcon;
        }
    }
}
