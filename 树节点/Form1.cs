using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 树节点
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //定义一个根节点
            TreeNode tn = new TreeNode("慧与实训");
            //定义子节点
            TreeNode t1 = new TreeNode("众阳定制版");
            TreeNode t2 = new TreeNode("开发一班");
            TreeNode t3 = new TreeNode("开发二班");
            //添加三个班级
            tn.Nodes.Add(t1);
            tn.Nodes.Add(t2);
            tn.Nodes.Add(t3);
            //添加到treeview控件上
            treeView1.Nodes.Add(tn);

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //清除原有信息
            listBox1.Items.Clear();
            treeView2.Nodes.Clear();
            TreeNode tr = null;
            TreeNode a1 = null;
            TreeNode a2 = null;
            TreeNode a3 = null;
            switch (e.Node.Text)
            {
                case "众阳定制版":
                    tr = new TreeNode("c#开发基础");
                    a1 = new TreeNode("c#基础");
                    a2 = new TreeNode("sqlsever");
                    a3 = new TreeNode("c#");
                    tr.Nodes.Add(a1);
                    tr.Nodes.Add(a2);
                    tr.Nodes.Add(a3);
                    treeView2.Nodes.Add(tr);
                    //添加学生
                    listBox1.Items.Add("张三");
                    listBox1.Items.Add("李四");
                    listBox1.Items.Add("王五");
                    break;
                case "开发二班":
                    tr = new TreeNode("java开发基础");
                    a1 = new TreeNode("java基础");
                    a2 = new TreeNode("mysql");
                    a3 = new TreeNode("java");
                    tr.Nodes.Add(a1);
                    tr.Nodes.Add(a2);
                    tr.Nodes.Add(a3);
                    treeView2.Nodes.Add(tr);
                    //添加学生
                    listBox1.Items.Add("张三");
                    listBox1.Items.Add("李四");
                    listBox1.Items.Add("王五");
                    break;
            }
        }
    }
}
