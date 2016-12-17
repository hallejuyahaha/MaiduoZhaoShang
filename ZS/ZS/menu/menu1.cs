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

namespace ZS.menu
{
    public partial class menu1 : Form
    {
        DateClass.MyClass MyClass = new DateClass.MyClass();
        public menu1()
        {
            InitializeComponent();
            string str1 = "select id, name, address, jiamengDate, lastbrandDate, jieyueDate from jmmessage";
            DataTable dt = new DataTable();
           //创建JJ 让未交费的人名单放入
            DataTable jj = new DataTable();
            DataColumn jjid = new DataColumn("id", typeof(int));
            DataColumn jjname = new DataColumn("name", typeof(string));
            DataColumn jjaddress = new DataColumn("address", typeof(string));
            DataColumn jjjiamengDate = new DataColumn("jiamengDate", typeof(string));
            DataColumn jjlastbrandDate = new DataColumn("lastbrandDate", typeof(string));
            DataColumn jjjieyueDate = new DataColumn("jieyueDate", typeof(string));
            jj.Columns.AddRange(new DataColumn[] { jjid, jjname, jjaddress, jjjiamengDate, jjlastbrandDate, jjjieyueDate });
            dt = MyClass.getDataTable(str1);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[5].ToString().Trim() != "")  //证明有解约
                {

                }
                else
                {
                    if (dr[4].ToString().Trim() != "") //证明没有解约，有交商标费
                    {
                        int t = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));   //现在时间的int型
                        int j = Convert.ToInt32(dr[4]);                            //上次缴费时间的int型
                        if (t - j >= 10000)
                        {
                            Console.WriteLine(dr[4]);
                            jj.Rows.Add(dr.ItemArray);

                            continue;
                        }
                    }
                    else
                    {
                        if (dr[3].ToString().Trim() != "")
                        {
                            int t = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));   //现在时间的int型
                            int j = Convert.ToInt32(dr[3]);                            //加盟时间的int型
                            if (t - j >= 10000)
                            {
                                jj.Rows.Add(dr.ItemArray);       //把数据加进表中
                                continue;
                            }
                        }
                        else
                        {
                            MessageBox.Show("有某个加盟商，你既没有输入加盟日期，也没输入上次缴费日期，还没输入解约日期");
                            break;
                        }
                    }
                }
            }
            this.dataGridView1.DataSource = jj;
            label3.Text = jj.Rows.Count.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
