using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZS
{
    public partial class selectForm : Form
    {
        DateClass.MyClass MyDataClass = new ZS.DateClass.MyClass();
        
        public selectForm()
        {
            InitializeComponent();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {

            if (cbSelectWay.Text == "id")
            {
                string selectCon = "select id, name, phone, prov, city, address, jiamengDate, kaiyeDate, jieyueDate, baozhengjinReturnData, isBaozhengjinReturn, kaiyePeople,constractNumber, saleVolume, peixianSituation, zuodianSituation,lastbrandDate, jiamengMoney, baozhengjinMoney,brandMoney, notes from jmmessage where id = " + tbcontent.Text;
                DataTable dt = MyDataClass.getDataTable(selectCon);
                this.dataGridView1.DataSource = dt;
                label9.Text = dt.Rows.Count.ToString();
            }
            else if (cbSelectWay.Text == "名字")
            {
                string selectCon = "select id, name, phone, prov, city, address, jiamengDate, kaiyeDate, jieyueDate, baozhengjinReturnData, isBaozhengjinReturn, kaiyePeople, constractNumber, saleVolume, peixianSituation, zuodianSituation,lastbrandDate, jiamengMoney, baozhengjinMoney, brandMoney, notes from jmmessage where name like '" + tbcontent.Text.ToString() + "%'";
                DataTable dt = MyDataClass.getDataTable(selectCon);
                this.dataGridView1.DataSource = dt;
                label9.Text = dt.Rows.Count.ToString();
            }
            else if (cbSelectWay.Text == "省市")
            {
                string selectCon = "select id, name, phone, prov, city, address, jiamengDate, kaiyeDate, jieyueDate, baozhengjinReturnData, isBaozhengjinReturn, kaiyePeople, constractNumber, saleVolume, peixianSituation, zuodianSituation,lastbrandDate, jiamengMoney, baozhengjinMoney,brandMoney , notes from jmmessage where prov = '" + cbProv.Text.ToString() + "' and city = '" + cbCity.Text.ToString() + "'";
                DataTable dt = MyDataClass.getDataTable(selectCon);
                this.dataGridView1.DataSource = dt;
                label9.Text = dt.Rows.Count.ToString();
            }
            else if (cbSelectWay.Text == "加盟日期")
            {
                string selectCon = "select id, name, phone, prov, city, address, jiamengDate, kaiyeDate, jieyueDate, baozhengjinReturnData, isBaozhengjinReturn, kaiyePeople, constractNumber, saleVolume, peixianSituation, zuodianSituation,lastbrandDate, jiamengMoney, baozhengjinMoney,brandMoney, notes from jmmessage where jiamengDate  between " + int.Parse(tbStartDate.Text.ToString()) + " and " + int.Parse(tbEndDate.Text.ToString());
                DataTable dt = MyDataClass.getDataTable(selectCon);
                this.dataGridView1.DataSource = dt;
                label9.Text = dt.Rows.Count.ToString();
            }
            else if (cbSelectWay.Text == "某月商标费到期人员")
            {
                string selectCon = "select id, name, phone, prov, city, address, jiamengDate, lastbrandDate, brandMoney, jieyueDate from jmmessage";
                DataTable dt = new DataTable();
                dt = MyDataClass.getDataTable(selectCon);
                //创建JJ 让未交费的人名单放入
                DataTable jj = new DataTable();
                DataColumn jj0 = new DataColumn("id", typeof(int));
                DataColumn jj1 = new DataColumn("name", typeof(string));
                DataColumn jj2 = new DataColumn("phone", typeof(string));
                DataColumn jj3 = new DataColumn("prov", typeof(string));
                DataColumn jj4 = new DataColumn("city", typeof(string));
                DataColumn jj5 = new DataColumn("address", typeof(string));
                DataColumn jj6 = new DataColumn("jiamengDate", typeof(string));
                DataColumn jj7 = new DataColumn("lastbrandDate", typeof(string));
                DataColumn jj8 = new DataColumn("brandMoney", typeof(string));
                DataColumn jj9 = new DataColumn("jieyueDate", typeof(string));
                jj.Columns.AddRange(new DataColumn[] { jj0, jj1, jj2, jj3, jj4, jj5, jj6, jj7, jj8, jj9 });



                #region 把没有解约的放入 jj
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[9].ToString().Trim() != "")  //证明有解约
                    {

                    }
                    else
                    {
                        jj.Rows.Add(dr.ItemArray);
                    }
                } 
                #endregion


                DataTable gg = new DataTable();
                DataColumn gg0 = new DataColumn("id", typeof(int));
                DataColumn gg1 = new DataColumn("name", typeof(string));
                DataColumn gg2 = new DataColumn("phone", typeof(string));
                DataColumn gg3 = new DataColumn("prov", typeof(string));
                DataColumn gg4 = new DataColumn("city", typeof(string));
                DataColumn gg5 = new DataColumn("address", typeof(string));
                DataColumn gg6 = new DataColumn("jiamengDate", typeof(string));
                DataColumn gg7 = new DataColumn("lastbrandDate", typeof(string));
                DataColumn gg8 = new DataColumn("brandMoney", typeof(string));
                DataColumn gg9 = new DataColumn("jieyueDate", typeof(string));
                gg.Columns.AddRange(new DataColumn[] { gg0, gg1, gg2, gg3, gg4, gg5, gg6, gg7, gg8, gg9 });


                #region 筛选出加盟日期符合选择的人  gg
                foreach (DataRow dr in jj.Rows)
                {
                    string strdr = dr[6].ToString();
                    if (strdr.Substring(4, 2) == cbMonth.Text.ToString())
                    {
                        gg.Rows.Add(dr.ItemArray);
                    }
                }
                this.dataGridView2.DataSource = gg;
                label9.Text = gg.Rows.Count.ToString();

                #endregion
                int t = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));   //现在时间的int型
                int yijiao = 0;
                int weijiao = 0;

                for (int i = 0; i < gg.Rows.Count; i++)
                {
                    if (gg.Rows[i]["lastbrandDate"].ToString() == "")
                    {
                        if (t - Convert.ToInt32(gg.Rows[i]["jiamengDate"]) > 10000)
                        {
                            this.dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            weijiao++;
                        }
                        else
                        {
                            this.dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            yijiao++;
                        }
                    }
                    else 
                    {
                        if (t - Convert.ToInt32(gg.Rows[i]["lastbrandDate"]) > 10000)
                        {
                            this.dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            weijiao++;
                        }
                        else
                        {
                            this.dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            yijiao++;
                        }
                    }
                }
                label12.Text = yijiao.ToString();
                label15.Text = weijiao.ToString();
            }
            else
            {
                MessageBox.Show("请选择查询方式");
            }
            
        }

        private void cbSelectWay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectWay.Text.ToString() == "id" && cbSelectWay.Text.ToString() == "名字")
            {
                tbcontent.Visible = true;
                label2.Visible = true;
                cbProv.Visible = false;
                label3.Visible = false;
                cbCity.Visible = false;
                label4.Visible = false;
                tbStartDate.Visible = false;
                label5.Visible = false;
                tbEndDate.Visible = false;
                label6.Visible = false;
                cbMonth.Visible = false;
                label7.Visible = false;
                panel2.Visible = false;
                

                this.dataGridView1.Visible = true;
                this.dataGridView2.Visible = false;
            }
            if (cbSelectWay.Text.ToString() == "省市")
            {
                tbcontent.Visible = false;
                label2.Visible = false;
                cbProv.Visible = true;
                label3.Visible = true;
                cbCity.Visible = true;
                label4.Visible = true;
                tbStartDate.Visible = false;
                label5.Visible = false;
                tbEndDate.Visible = false;
                label6.Visible = false;
                cbMonth.Visible = false;
                label7.Visible = false;
                panel2.Visible = false;
                

                this.dataGridView1.Visible = true;
                this.dataGridView2.Visible = false;
            }
            if (cbSelectWay.Text.ToString() == "加盟日期")
            {
                tbcontent.Visible = false;
                label2.Visible = false;
                cbProv.Visible = false;
                label3.Visible = false;
                cbCity.Visible = false;
                label4.Visible = false;
                tbStartDate.Visible = true;
                label5.Visible = true;
                tbEndDate.Visible = true;
                label6.Visible = true;
                cbMonth.Visible = false;
                label7.Visible = false;
                panel2.Visible = false;
            

                this.dataGridView1.Visible = true;
                this.dataGridView2.Visible = false;
            }
            if (cbSelectWay.Text.ToString() == "某月商标费到期人员")
            {
                tbcontent.Visible = false;
                label2.Visible = false;
                cbProv.Visible = false;
                label3.Visible = false;
                cbCity.Visible = false;
                label4.Visible = false;
                tbStartDate.Visible = false;
                label5.Visible = false;
                tbEndDate.Visible = false;
                label6.Visible = false;
                cbMonth.Visible = true;
                label7.Visible = true;
                panel2.Visible = true;
                

                this.dataGridView1.Visible = false;
                this.dataGridView2.Visible = true;
            }
        }

        private void selectForm_Load(object sender, EventArgs e)
        {
            tbcontent.Visible = true;
            label2.Visible = true;
            cbProv.Visible = false;
            label3.Visible = false;
            cbCity.Visible = false;
            label4.Visible = false;
            tbStartDate.Visible = false;
            label5.Visible = false;
            tbEndDate.Visible = false;
            label6.Visible = false;
            cbMonth.Visible = false;
            label7.Visible = false;
            label9.Text = "0";
            label12.Text = "0";
            label15.Text = "0";
            panel2.Visible = false;
            
           

            this.dataGridView1.Visible = true;
            this.dataGridView2.Visible = false;
        }

        #region 省市发生变动
        private void cbProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProv.SelectedItem.ToString() == "北京")
            {
                cbCity.Items.Clear();
                cbCity.Text = "丰台";
                cbCity.Items.Add("东城");
                cbCity.Items.Add("丰台");
                cbCity.Items.Add("西城");
                cbCity.Items.Add("海淀");
                cbCity.Items.Add("朝阳");
                cbCity.Items.Add("通州");
                cbCity.Items.Add("顺义");
                cbCity.Items.Add("大兴");
                cbCity.Items.Add("昌平");
                cbCity.Items.Add("房山");
                cbCity.Items.Add("怀柔");
                cbCity.Items.Add("平谷");
                cbCity.Items.Add("密云");
                cbCity.Items.Add("延庆");
            }
            if (cbProv.SelectedItem.ToString() == "上海")
            {
                cbCity.Items.Clear();
                cbCity.Text = "浦东";
                cbCity.Items.Add("浦东");
                cbCity.Items.Add("徐汇");
                cbCity.Items.Add("长宁");
                cbCity.Items.Add("普陀");
                cbCity.Items.Add("闸北");
                cbCity.Items.Add("虹口");
                cbCity.Items.Add("杨浦");
                cbCity.Items.Add("黄埔");
                cbCity.Items.Add("卢湾");
                cbCity.Items.Add("静安");
                cbCity.Items.Add("宝山");
                cbCity.Items.Add("闵行");
                cbCity.Items.Add("嘉定");
                cbCity.Items.Add("金山");
                cbCity.Items.Add("松江");
                cbCity.Items.Add("青浦");
                cbCity.Items.Add("南汇");
                cbCity.Items.Add("奉贤");
            }
            if (cbProv.SelectedItem.ToString() == "天津")
            {
                cbCity.Items.Clear();
                cbCity.Text = "和平";
                cbCity.Items.Add("和平");
                cbCity.Items.Add("河西");
                cbCity.Items.Add("河东");
                cbCity.Items.Add("南开");
                cbCity.Items.Add("红桥");
                cbCity.Items.Add("河北");
                cbCity.Items.Add("东丽");
                cbCity.Items.Add("西青");
                cbCity.Items.Add("津南");
                cbCity.Items.Add("北辰");
                cbCity.Items.Add("塘沽");
                cbCity.Items.Add("大港");
                cbCity.Items.Add("汉沽");
            }
            if (cbProv.SelectedItem.ToString() == "重庆")
            {
                cbCity.Items.Clear();
                cbCity.Text = "万州";
                cbCity.Items.Add("万州");
            }
            if (cbProv.SelectedItem.ToString() == "黑龙江")
            {
                cbCity.Items.Clear();
                cbCity.Text = "哈尔滨";
                cbCity.Items.Add("哈尔滨");
                cbCity.Items.Add("齐齐哈尔");
                cbCity.Items.Add("牡丹江");
                cbCity.Items.Add("佳木斯");
                cbCity.Items.Add("大庆");
                cbCity.Items.Add("鸡西");
                cbCity.Items.Add("双鸭山");
                cbCity.Items.Add("伊春");
                cbCity.Items.Add("七台河");
                cbCity.Items.Add("鹤岗");
                cbCity.Items.Add("黑河");
                cbCity.Items.Add("绥化");
                cbCity.Items.Add("大兴安岭地区");
            }
            if (cbProv.SelectedItem.ToString() == "辽宁")
            {
                cbCity.Items.Clear();
                cbCity.Text = "沈阳";
                cbCity.Items.Add("沈阳");
                cbCity.Items.Add("大连");
                cbCity.Items.Add("鞍山");
                cbCity.Items.Add("抚顺");
                cbCity.Items.Add("本溪");
                cbCity.Items.Add("丹东");
                cbCity.Items.Add("锦州");
                cbCity.Items.Add("营口");
                cbCity.Items.Add("阜新");
                cbCity.Items.Add("辽阳");
                cbCity.Items.Add("盘锦");
                cbCity.Items.Add("铁岭");
                cbCity.Items.Add("朝阳");
                cbCity.Items.Add("葫芦岛");
            }
            if (cbProv.SelectedItem.ToString() == "吉林")
            {
                cbCity.Items.Clear();
                cbCity.Text = "长春";
                cbCity.Items.Add("长春");
                cbCity.Items.Add("吉林");
                cbCity.Items.Add("四平");
                cbCity.Items.Add("辽源");
                cbCity.Items.Add("通化");
                cbCity.Items.Add("白山");
                cbCity.Items.Add("松原");
                cbCity.Items.Add("白城");
            }
            if (cbProv.SelectedItem.ToString() == "河北")
            {
                cbCity.Items.Clear();
                cbCity.Text = "石家庄";
                cbCity.Items.Add("石家庄");
                cbCity.Items.Add("唐山");
                cbCity.Items.Add("邯郸");
                cbCity.Items.Add("秦皇岛");
                cbCity.Items.Add("保定");
                cbCity.Items.Add("张家口");
                cbCity.Items.Add("承德");
                cbCity.Items.Add("廊坊");
                cbCity.Items.Add("沧州");
                cbCity.Items.Add("衡水");
                cbCity.Items.Add("邢台");
            }
            if (cbProv.SelectedItem.ToString() == "河南")
            {
                cbCity.Items.Clear();
                cbCity.Text = "新乡";
                cbCity.Items.Add("郑州");
                cbCity.Items.Add("新乡");
                cbCity.Items.Add("洛阳");
                cbCity.Items.Add("安阳");
                cbCity.Items.Add("焦作");
                cbCity.Items.Add("许昌");
                cbCity.Items.Add("平顶山");
                cbCity.Items.Add("漯河");
                cbCity.Items.Add("开封");
                cbCity.Items.Add("濮阳");
                cbCity.Items.Add("鹤壁");
                cbCity.Items.Add("南阳");
                cbCity.Items.Add("三门峡");
                cbCity.Items.Add("驻马店");
                cbCity.Items.Add("商丘");
                cbCity.Items.Add("信阳");
                cbCity.Items.Add("周口");
            }
            if (cbProv.SelectedItem.ToString() == "湖北")
            {
                cbCity.Items.Clear();
                cbCity.Text = "武汉";
                cbCity.Items.Add("武汉");
                cbCity.Items.Add("十堰");
                cbCity.Items.Add("襄樊");
                cbCity.Items.Add("随州");
                cbCity.Items.Add("荆门");
                cbCity.Items.Add("孝感");
                cbCity.Items.Add("宜昌");
                cbCity.Items.Add("黄冈");
                cbCity.Items.Add("鄂州");
                cbCity.Items.Add("荆州");
                cbCity.Items.Add("黄石");
                cbCity.Items.Add("咸宁");
            }
            if (cbProv.SelectedItem.ToString() == "湖南")
            {
                cbCity.Items.Clear();
                cbCity.Text = "长沙";
                cbCity.Items.Add("长沙");
                cbCity.Items.Add("株洲");
                cbCity.Items.Add("湘潭");
                cbCity.Items.Add("衡阳");
                cbCity.Items.Add("邵阳");
                cbCity.Items.Add("岳阳");
                cbCity.Items.Add("常德");
                cbCity.Items.Add("张家界");
                cbCity.Items.Add("益阳");
                cbCity.Items.Add("郴州");
                cbCity.Items.Add("永州");
                cbCity.Items.Add("怀化");
                cbCity.Items.Add("娄底");
            }
            if (cbProv.SelectedItem.ToString() == "山东")
            {
                cbCity.Items.Clear();
                cbCity.Text = "济南";
                cbCity.Items.Add("济南");
                cbCity.Items.Add("青岛");
                cbCity.Items.Add("淄博");
                cbCity.Items.Add("枣庄");
                cbCity.Items.Add("东营");
                cbCity.Items.Add("烟台");
                cbCity.Items.Add("潍坊");
                cbCity.Items.Add("济宁");
                cbCity.Items.Add("泰安");
                cbCity.Items.Add("威海");
                cbCity.Items.Add("日照");
                cbCity.Items.Add("滨州");
                cbCity.Items.Add("德州");
                cbCity.Items.Add("聊城");
                cbCity.Items.Add("临沂");
                cbCity.Items.Add("菏泽");
                cbCity.Items.Add("莱芜");
            }
            if (cbProv.SelectedItem.ToString() == "山西")
            {
                cbCity.Items.Clear();
                cbCity.Text = "太原";
                cbCity.Items.Add("太原");
                cbCity.Items.Add("大同");
                cbCity.Items.Add("阳泉");
                cbCity.Items.Add("长治");
                cbCity.Items.Add("晋城");
                cbCity.Items.Add("朔州");
                cbCity.Items.Add("晋中");
                cbCity.Items.Add("运城");
                cbCity.Items.Add("忻州");
                cbCity.Items.Add("临汾");
                cbCity.Items.Add("吕梁");
            }
            if (cbProv.SelectedItem.ToString() == "陕西")
            {
                cbCity.Items.Clear();
                cbCity.Text = "西安";
                cbCity.Items.Add("西安");
                cbCity.Items.Add("宝鸡");
                cbCity.Items.Add("咸阳");
                cbCity.Items.Add("渭南");
                cbCity.Items.Add("铜川");
                cbCity.Items.Add("延安");
                cbCity.Items.Add("榆林");
                cbCity.Items.Add("汉中");
                cbCity.Items.Add("安康");
                cbCity.Items.Add("商洛");
            }
            if (cbProv.SelectedItem.ToString() == "安徽")
            {
                cbCity.Items.Clear();
                cbCity.Text = "合肥";
                cbCity.Items.Add("芜湖");
                cbCity.Items.Add("蚌埠");
                cbCity.Items.Add("淮南");
                cbCity.Items.Add("马鞍山");
                cbCity.Items.Add("淮北");
                cbCity.Items.Add("铜陵");
                cbCity.Items.Add("安庆");
                cbCity.Items.Add("黄山");
                cbCity.Items.Add("阜阳");
                cbCity.Items.Add("宿州");
                cbCity.Items.Add("滁州");
                cbCity.Items.Add("六安");
                cbCity.Items.Add("宣城");
                cbCity.Items.Add("池州");
                cbCity.Items.Add("亳州");
            }
            if (cbProv.SelectedItem.ToString() == "浙江")
            {
                cbCity.Items.Clear();
                cbCity.Text = "杭州";
                cbCity.Items.Add("宁波");
                cbCity.Items.Add("温州");
                cbCity.Items.Add("嘉兴");
                cbCity.Items.Add("湖州");
                cbCity.Items.Add("绍兴");
                cbCity.Items.Add("金华");
                cbCity.Items.Add("舟山");
                cbCity.Items.Add("台州");
                cbCity.Items.Add("丽水");
                cbCity.Items.Add("衢州");
            }
            if (cbProv.SelectedItem.ToString() == "江苏")
            {
                cbCity.Items.Clear();
                cbCity.Text = "南京";
                cbCity.Items.Add("南京");
                cbCity.Items.Add("无锡");
                cbCity.Items.Add("徐州");
                cbCity.Items.Add("常州");
                cbCity.Items.Add("苏州");
                cbCity.Items.Add("南通");
                cbCity.Items.Add("连云港");
                cbCity.Items.Add("淮安");
                cbCity.Items.Add("盐城");
                cbCity.Items.Add("扬州");
                cbCity.Items.Add("镇江");
                cbCity.Items.Add("泰州");
                cbCity.Items.Add("宿迁");
            }
            if (cbProv.SelectedItem.ToString() == "福建")
            {
                cbCity.Items.Clear();
                cbCity.Text = "福州";
                cbCity.Items.Add("福州");
                cbCity.Items.Add("厦门");
                cbCity.Items.Add("莆田");
                cbCity.Items.Add("三明");
                cbCity.Items.Add("泉州");
                cbCity.Items.Add("漳州");
                cbCity.Items.Add("南平");
                cbCity.Items.Add("龙岩");
                cbCity.Items.Add("宁德");
            }
            if (cbProv.SelectedItem.ToString() == "广东")
            {
                cbCity.Items.Clear();
                cbCity.Text = "广州";
                cbCity.Items.Add("广州");
                cbCity.Items.Add("深圳");
                cbCity.Items.Add("珠海");
                cbCity.Items.Add("汕头");
                cbCity.Items.Add("佛山");
                cbCity.Items.Add("韶关");
                cbCity.Items.Add("湛江");
                cbCity.Items.Add("肇庆");
                cbCity.Items.Add("江门");
                cbCity.Items.Add("茂名");
                cbCity.Items.Add("惠州");
                cbCity.Items.Add("梅州");
                cbCity.Items.Add("汕尾");
                cbCity.Items.Add("河源");
                cbCity.Items.Add("阳江");
                cbCity.Items.Add("清远");
                cbCity.Items.Add("东莞");
                cbCity.Items.Add("中山");
                cbCity.Items.Add("潮州");
                cbCity.Items.Add("揭阳");
                cbCity.Items.Add("云浮");
            }
            if (cbProv.SelectedItem.ToString() == "海南")
            {
                cbCity.Items.Clear();
                cbCity.Text = "海口";
                cbCity.Items.Add("海口");
                cbCity.Items.Add("三亚");
                cbCity.Items.Add("琼海");
                cbCity.Items.Add("儋州");
                cbCity.Items.Add("文昌");
                cbCity.Items.Add("万宁");
                cbCity.Items.Add("东方");
                cbCity.Items.Add("陵水");
                cbCity.Items.Add("临高");
                cbCity.Items.Add("乐东");
            }
            if (cbProv.SelectedItem.ToString() == "四川")
            {
                cbCity.Items.Clear();
                cbCity.Text = "成都";
                cbCity.Items.Add("成都");
                cbCity.Items.Add("自贡");
                cbCity.Items.Add("攀枝花");
                cbCity.Items.Add("泸州");
                cbCity.Items.Add("德阳");
                cbCity.Items.Add("绵阳");
                cbCity.Items.Add("广元");
                cbCity.Items.Add("遂宁");
                cbCity.Items.Add("内江");
                cbCity.Items.Add("乐山");
                cbCity.Items.Add("南充");
                cbCity.Items.Add("宜宾");
                cbCity.Items.Add("广安");
                cbCity.Items.Add("达州");
                cbCity.Items.Add("巴中");
                cbCity.Items.Add("雅安");
                cbCity.Items.Add("眉山");
                cbCity.Items.Add("资阳");
                cbCity.Items.Add("阿坝");
            }
            if (cbProv.SelectedItem.ToString() == "云南")
            {
                cbCity.Items.Clear();
                cbCity.Text = "昆明";
                cbCity.Items.Add("昆明");
                cbCity.Items.Add("曲靖");
                cbCity.Items.Add("邵通");
                cbCity.Items.Add("玉溪");
                cbCity.Items.Add("楚雄");
                cbCity.Items.Add("红河");
                cbCity.Items.Add("文山");
                cbCity.Items.Add("普洱");
                cbCity.Items.Add("版纳");
                cbCity.Items.Add("大理");
                cbCity.Items.Add("保山");
                cbCity.Items.Add("德宏");
                cbCity.Items.Add("丽江");
                cbCity.Items.Add("怒江");
                cbCity.Items.Add("迪庆");
                cbCity.Items.Add("临沧");
            }
            if (cbProv.SelectedItem.ToString() == "贵州")
            {
                cbCity.Items.Clear();
                cbCity.Text = "贵阳";
                cbCity.Items.Add("贵阳");
                cbCity.Items.Add("遵义");
                cbCity.Items.Add("六盘水");
                cbCity.Items.Add("安顺");
                cbCity.Items.Add("毕节");
                cbCity.Items.Add("铜仁");
                cbCity.Items.Add("黔西南");
                cbCity.Items.Add("黔东南");
                cbCity.Items.Add("黔南");
            }
            if (cbProv.SelectedItem.ToString() == "青海")
            {
                cbCity.Items.Clear();
                cbCity.Text = "西宁";
                cbCity.Items.Add("西宁");
                cbCity.Items.Add("海东");
                cbCity.Items.Add("海西");
                cbCity.Items.Add("海南");
                cbCity.Items.Add("海北");
                cbCity.Items.Add("黄南");
                cbCity.Items.Add("果洛");
                cbCity.Items.Add("玉树");
            }
            if (cbProv.SelectedItem.ToString() == "甘肃")
            {
                cbCity.Items.Clear();
                cbCity.Text = "兰州";
                cbCity.Items.Add("兰州");
                cbCity.Items.Add("嘉峪关");
                cbCity.Items.Add("金昌");
                cbCity.Items.Add("白银");
                cbCity.Items.Add("天水");
                cbCity.Items.Add("武威");
                cbCity.Items.Add("张掖");
                cbCity.Items.Add("酒泉");
                cbCity.Items.Add("平凉");
                cbCity.Items.Add("庆阳");
                cbCity.Items.Add("定西");
                cbCity.Items.Add("陇南");
                cbCity.Items.Add("临夏");
                cbCity.Items.Add("甘南");
            }
            if (cbProv.SelectedItem.ToString() == "江西")
            {
                cbCity.Items.Clear();
                cbCity.Text = "南昌";
                cbCity.Items.Add("南昌");
                cbCity.Items.Add("九江");
                cbCity.Items.Add("赣州");
                cbCity.Items.Add("吉安");
                cbCity.Items.Add("萍乡");
                cbCity.Items.Add("鹰潭");
                cbCity.Items.Add("新余");
                cbCity.Items.Add("宜春");
                cbCity.Items.Add("上饶");
                cbCity.Items.Add("景德镇");
                cbCity.Items.Add("抚州");
            }
            if (cbProv.SelectedItem.ToString() == "台湾")
            {
                cbCity.Items.Clear();
                cbCity.Text = "台北";
                cbCity.Items.Add("台北");
            }
            if (cbProv.SelectedItem.ToString() == "内蒙")
            {
                cbCity.Items.Clear();
                cbCity.Text = "呼和浩特";
                cbCity.Items.Add("呼和浩特");
                cbCity.Items.Add("包头");
                cbCity.Items.Add("乌海");
                cbCity.Items.Add("赤峰");
                cbCity.Items.Add("通辽");
                cbCity.Items.Add("鄂尔多斯");
                cbCity.Items.Add("呼伦贝尔");
                cbCity.Items.Add("巴彦淖尔");
                cbCity.Items.Add("乌兰察布");
            }
            if (cbProv.SelectedItem.ToString() == "宁夏")
            {
                cbCity.Items.Clear();
                cbCity.Text = "银川";
                cbCity.Items.Add("银川");
                cbCity.Items.Add("灵武");
                cbCity.Items.Add("石嘴山");
                cbCity.Items.Add("青铜峡");
                cbCity.Items.Add("固原");
                cbCity.Items.Add("吴忠");
            }
            if (cbProv.SelectedItem.ToString() == "新疆")
            {
                cbCity.Items.Clear();
                cbCity.Text = "乌鲁木齐";
                cbCity.Items.Add("乌鲁木齐");
                cbCity.Items.Add("克拉玛依");
            }
        }
        #endregion

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
