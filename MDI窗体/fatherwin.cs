using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI窗体
{
    public partial class fatherwin : Form
    {
        public fatherwin()
        {
            InitializeComponent();
        }

        private void tsmopen_Click(object sender, EventArgs e)
        {
            //实例化一个子窗体
            chilwin cw = new chilwin();
            cw.MdiParent = this;
            cw.Show();
        }

        private void tsmmax_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void tsmmin_Click(object sender, EventArgs e)
        {
            //遍历当前父窗体的所有子窗体
            foreach (Form frm in this.MdiChildren)
            {
                //最小化子窗体
                frm.WindowState = FormWindowState.Minimized;
            }
        }

        private void tsmcloseall_Click(object sender, EventArgs e)
        {
            //遍历当前父窗体下的所有子窗体
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void tsmduidie_Click(object sender, EventArgs e)
        {
            //子窗体堆叠
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmshuiping_Click(object sender, EventArgs e)
        {
            //子窗体水平
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmchuizi_Click(object sender, EventArgs e)
        {
            //子窗体锤子
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
