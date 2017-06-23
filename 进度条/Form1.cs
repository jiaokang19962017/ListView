using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 进度条
{
    public partial class Form1 : Form
    {
        //定义时间为5s
        public int s = 5;
        public Form1()
        {
            InitializeComponent();
            //打开定时器
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;//时间递减
            //显式时间变化
            label1.Text = s.ToString();
            //按增加的增加显示进度条
            progressBar1.PerformStep();
            if (s == 0)
            {
                timer1.Stop();//关闭定时器
                //显式主界面
                Form2 f2 = new Form2();
                f2.Show();//显式新窗体
                this.Hide();//隐藏本窗体
            }
        }
    }
}
