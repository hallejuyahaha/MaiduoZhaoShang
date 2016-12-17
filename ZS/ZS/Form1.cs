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
namespace ZS
{
    public partial class Form1 : Form
    {
        DateClass.MyClass MyDataClass = new ZS.DateClass.MyClass();
        public static int UpdataId;//修改的ID
        public static string AllSql = "select id, name, phone,  prov, city, address,jiamengDate, kaiyeDate, jieyueDate, baozhengjinReturnData, isBaozhengjinReturn, kaiyePeople, constractNumber, saleVolume, peixianSituation, zuodianSituation, lastbrandDate,jiamengMoney, baozhengjinMoney, brandMoney,notes  from jmmessage";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showall();
            //dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Red;
        }

        public void showall()
        {
           
            DataTable dt = MyDataClass.getDataTable(AllSql);
            dataGridView1.DataSource = dt;
        }

        #region 添加键
        private void btAdd_Click(object sender, EventArgs e)
        {
            InfoAddFrm.Address ia = new ZS.InfoAddFrm.Address();
            ia.Text = "添加加盟商信息";
            ia.Tag = 1;
            ia.ShowDialog(this);
            showall();
        } 
        #endregion

        #region 修改键
        private void btUpdata_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("你还没选呢");
                return;
            }
            else if (this.dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("一次只能选一个");
                return;
            }
            int UpdataId = int.Parse(this.dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
            InfoAddFrm.Address ib = new ZS.InfoAddFrm.Address(UpdataId);
            ib.Tag = 2;
            ib.Text = "修改加盟信息";
            ib.ShowDialog(this);
            showall();
        } 
        #endregion

        #region 删除键
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("你还没选呢");
                return;
            }
            else if (MessageBox.Show("确认要删除吗?", "提醒消息", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            else if (this.dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("数据很重要，一次请只删一个");
                return;
            }
            int deleteUserId = int.Parse(this.dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
            MyDataClass.getsqlcom("Delete jmmessage where ID='" + deleteUserId + "'");
            MyDataClass.getsqlcom("Delete visiting where id ='" + deleteUserId + "'");
            MyDataClass.getsqlcom("Delete jiaofei where id ='" + deleteUserId + "'");
            showall();

            // string connStr ="";
            MessageBox.Show("删除成功");
        } 
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            selectForm sf = new selectForm();
            sf.Text = "查询信息";
            sf.ShowDialog(this);
            showall();
        }

        #region 巡店键
        private void btVisiting_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("你还没选呢");
                return;
            }
            else if (this.dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("一次只能选一个");
                return;
            }
            int VisitingId = int.Parse(this.dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
            VisitingShop.VisitingForm vf = new VisitingShop.VisitingForm(VisitingId);
            vf.ShowDialog(this);
        } 
        #endregion

        private void btBrand_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("你还没选呢");
                return;
            }
            else if (this.dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("一次只能选一个");
                return;
            }
            int BrandID = int.Parse(this.dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
            Brand.BrandForm bf = new Brand.BrandForm(BrandID);
            bf.ShowDialog(this);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void 记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showall();
        }

        private void 谁的商标使用费没交ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu.menu1 mu = new menu.menu1();
            mu.ShowDialog(this);
        }
    }
}
