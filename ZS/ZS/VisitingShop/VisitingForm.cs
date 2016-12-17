using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZS.VisitingShop
{
    public partial class VisitingForm : Form
    {
        DateClass.MyClass MyClass = new DateClass.MyClass();
        private int VisitingId;
        private string str;
        public VisitingForm()
        {
            InitializeComponent();
        }

        public VisitingForm(int VI)
        {
            InitializeComponent();
            this.VisitingId = VI;
            str = "select timer, visitername, visitdate, isviolation, violationsituation, saleV, visitingnotes from visiting where id = " + VI;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisitingShop.VisitingAdd va = new VisitingShop.VisitingAdd(VisitingId);
            va.ShowDialog(this);
            showall();
        }

        private void VisitingForm_Load(object sender, EventArgs e)
        {
            showall();
        }

        private void showall()
        {
            DataTable dt = MyClass.getDataTable(str);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
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
            string DeleteId = this.dataGridView1.SelectedRows[0].Cells["timer"].Value.ToString();
            MyClass.getsqlcom("Delete visiting where timer='" + DeleteId + "'");
            showall();
        }
    }
}
