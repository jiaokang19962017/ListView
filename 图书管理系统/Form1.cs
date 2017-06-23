using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 图书管理系统
{
    public partial class Form1 : Form
    {
        SqlConnection sqlconn = null;
        string strconn = "Data Source=HP201-1;Initial Catalog=Book;Integrated Security=True";
        //定义一个变量表示选中节点s
        string category;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //将listview改为列表显式
            listView2.View = View.Details;
            BookList();
        }
        private void BookList()
        {
            //先清空listview中的内容
            listView2.Items.Clear();
            sqlconn = new SqlConnection(strconn);
            try
            {
                sqlconn.Open();
                string sql = string.Format("select BNo,BName,Author,Press,Price from Books where Category like '%{0}%' ",category);
                SqlCommand cmd = new SqlCommand(sql,sqlconn);
                SqlDataReader dr = cmd.ExecuteReader();
                //遍历dr
                while (dr.Read())
                {
                    //获取查询的数据
                    string bookno = dr["BNo"].ToString();
                    string bookname = dr["BName"].ToString();
                    string bookauthor = dr["Author"].ToString();
                    string bookpress = dr["Press"].ToString();
                    double price = Convert.ToDouble(dr["Price"]);
                    //创建listviewitems
                    ListViewItem item = new ListViewItem(bookno);
                    //添加子项
                    item.SubItems.Add(bookname);
                    item.SubItems.Add(bookname);
                    item.SubItems.Add(bookpress);
                    item.SubItems.Add(Convert.ToString(price));

                    listView2.Items.Add(item);
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Level == 1)
            {
                category = treeView1.SelectedNode.Text;
            }
            else
            {
                category = null;
            }
            BookList();
        }
    }
}
