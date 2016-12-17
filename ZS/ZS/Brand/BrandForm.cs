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

namespace ZS.Brand
{
    public partial class BrandForm : Form
    {
        DateClass.MyClass MyClass = new DateClass.MyClass();
        private int BrandID;

        public BrandForm()
        {
            InitializeComponent();
        }

        public BrandForm(int BrandID)
        {
            InitializeComponent();
            this.BrandID = BrandID;
        }

        private void tbAdd_Click(object sender, EventArgs e)
        {
            if (tbDate.Text.ToString().Trim() == "" | tbMoney.Text.ToString().Trim() == "")
            {
                MessageBox.Show("请输入缴费日期或缴费金额");
            }
            else 
            {
                string str = "insert into jiaofei (id, jiaofeiData, jiaofeiMoney,jiaofeiNotes)values(" + BrandID + ",'" + tbDate.Text.ToString() + "','" + tbMoney.Text.ToString() + "','" + textBox1.Text.ToString() + "')";
                DataTable dt = MyClass.getDataTable(str);
                this.dataGridView1.DataSource = dt;
                showall();
                string strr = "update jmmessage set lastbrandDate = '" + tbDate.Text.ToString() + "' where id = " + BrandID;
                MyClass.getcom(strr);
                tbDate.Text = "";
                tbMoney.Text = "";
                textBox1.Text = "";
            }
        }

        private void BrandForm_Load(object sender, EventArgs e)
        {
            showall();
        }

        private void showall()
        {
            string str = "select jiaofeiData, jiaofeiMoney,jiaofeiNotes from jiaofei where id = " + BrandID;
            DataTable dt = MyClass.getDataTable(str);
            this.dataGridView1.DataSource = dt;
        }

        private void tbdelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("你还没选呢");
                return;
            }
            if (MessageBox.Show("确认要删除吗?", "提醒消息", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            int deleteUserId = int.Parse(this.dataGridView1.SelectedRows[0].Cells["jiaofeiData"].Value.ToString());
            MyClass.getsqlcom("Delete jiaofei where jiaofeiData='" + deleteUserId + "'");
            showall();
        }
    }
}
