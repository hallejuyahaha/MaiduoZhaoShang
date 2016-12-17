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
    public partial class VisitingAdd : Form
    {
        DateClass.MyClass MyClass = new DateClass.MyClass();
        private int VisitingId;
        public VisitingAdd()
        {
            InitializeComponent();
        }

        public VisitingAdd(int VisitingId)
        {
            InitializeComponent();
            this.VisitingId = VisitingId;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tbTimer.Text.ToString().Trim() == "" || tbVisiterName.Text.ToString().Trim() == "" || tbSaleV.Text.ToString().Trim() == "")
            {
                MessageBox.Show("巡店次数和巡店员不能为空");
            }
            else 
            { 
                string timer = tbTimer.Text.ToString();
                string visitername = tbVisiterName.Text.ToString();
                string visitdate = tbVisitDate.Text.ToString();
                string isviolation = cbIsViolation.Text.ToString();
                string violationsituation = tbViolationSituation.Text.ToString();
                float saleV = float.Parse(tbSaleV.Text);
                string visitingnotes = tbVisitingNotes.Text.ToString();
                string str = "insert into visiting (id, timer, visitername, visitdate, isviolation, violationsituation, saleV, visitingnotes) values("+
                      VisitingId +",'" +timer+ "','" + visitername + "','" + visitdate + "','" + isviolation + "','" + violationsituation + "','" +
                      saleV+"','"+visitingnotes+"')";
                MyClass.getsqlcom(str);
                if(saleV != 0)
                {
                   string strSV = "update jmmessage set saleVolume = "+saleV+"where id = "+VisitingId;
                   MyClass.getsqlcom(strSV);
                }
                this.Close();
            }
        }
    }
}
