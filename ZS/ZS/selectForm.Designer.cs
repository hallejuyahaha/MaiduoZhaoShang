namespace ZS
{
    partial class selectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSelectWay = new System.Windows.Forms.ComboBox();
            this.tbcontent = new System.Windows.Forms.TextBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jiamengDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaiyeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jieyueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baozhengjinReturnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBaozhengjinReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaiyePeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constractNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peixianSituation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zuodianSituation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastbrandDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jiamengMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baozhengjinMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProv = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jiamengDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastbrandDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandMoney2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jieyueDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSelectWay
            // 
            this.cbSelectWay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectWay.FormattingEnabled = true;
            this.cbSelectWay.Items.AddRange(new object[] {
            "id",
            "名字",
            "省市",
            "加盟日期",
            "某月商标费到期人员"});
            this.cbSelectWay.Location = new System.Drawing.Point(139, 43);
            this.cbSelectWay.Name = "cbSelectWay";
            this.cbSelectWay.Size = new System.Drawing.Size(121, 20);
            this.cbSelectWay.TabIndex = 0;
            this.cbSelectWay.SelectedIndexChanged += new System.EventHandler(this.cbSelectWay_SelectedIndexChanged);
            // 
            // tbcontent
            // 
            this.tbcontent.Location = new System.Drawing.Point(334, 42);
            this.tbcontent.Name = "tbcontent";
            this.tbcontent.Size = new System.Drawing.Size(100, 21);
            this.tbcontent.TabIndex = 1;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(536, 43);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 23);
            this.btSelect.TabIndex = 2;
            this.btSelect.Text = "查询";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "查询方式";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.phone,
            this.prov,
            this.city,
            this.address,
            this.jiamengDate,
            this.kaiyeDate,
            this.jieyueDate,
            this.baozhengjinReturnData,
            this.isBaozhengjinReturn,
            this.kaiyePeople,
            this.constractNumber,
            this.saleVolume,
            this.peixianSituation,
            this.zuodianSituation,
            this.lastbrandDate,
            this.jiamengMoney,
            this.baozhengjinMoney,
            this.brandMoney,
            this.notes});
            this.dataGridView1.Location = new System.Drawing.Point(25, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1170, 379);
            this.dataGridView1.TabIndex = 4;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 42;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "名字";
            this.name.Name = "name";
            this.name.Width = 51;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "电话";
            this.phone.Name = "phone";
            this.phone.Width = 51;
            // 
            // prov
            // 
            this.prov.DataPropertyName = "prov";
            this.prov.HeaderText = "省份";
            this.prov.Name = "prov";
            this.prov.Width = 51;
            // 
            // city
            // 
            this.city.DataPropertyName = "city";
            this.city.HeaderText = "城市";
            this.city.Name = "city";
            this.city.Width = 51;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "地址";
            this.address.Name = "address";
            this.address.Width = 51;
            // 
            // jiamengDate
            // 
            this.jiamengDate.DataPropertyName = "jiamengDate";
            this.jiamengDate.HeaderText = "加盟日期";
            this.jiamengDate.Name = "jiamengDate";
            this.jiamengDate.Width = 61;
            // 
            // kaiyeDate
            // 
            this.kaiyeDate.DataPropertyName = "kaiyeDate";
            this.kaiyeDate.HeaderText = "开业日期";
            this.kaiyeDate.Name = "kaiyeDate";
            this.kaiyeDate.Width = 61;
            // 
            // jieyueDate
            // 
            this.jieyueDate.DataPropertyName = "jieyueDate";
            this.jieyueDate.HeaderText = "解约日期";
            this.jieyueDate.Name = "jieyueDate";
            this.jieyueDate.Width = 61;
            // 
            // baozhengjinReturnData
            // 
            this.baozhengjinReturnData.DataPropertyName = "baozhengjinReturnData";
            this.baozhengjinReturnData.HeaderText = "保证金退还日期";
            this.baozhengjinReturnData.Name = "baozhengjinReturnData";
            this.baozhengjinReturnData.Width = 83;
            // 
            // isBaozhengjinReturn
            // 
            this.isBaozhengjinReturn.DataPropertyName = "isBaozhengjinReturn";
            this.isBaozhengjinReturn.HeaderText = "保证金是否退还";
            this.isBaozhengjinReturn.Name = "isBaozhengjinReturn";
            this.isBaozhengjinReturn.Width = 83;
            // 
            // kaiyePeople
            // 
            this.kaiyePeople.DataPropertyName = "kaiyePeople";
            this.kaiyePeople.HeaderText = "开业人员";
            this.kaiyePeople.Name = "kaiyePeople";
            this.kaiyePeople.Width = 61;
            // 
            // constractNumber
            // 
            this.constractNumber.DataPropertyName = "constractNumber";
            this.constractNumber.HeaderText = "合同编号";
            this.constractNumber.Name = "constractNumber";
            this.constractNumber.Width = 61;
            // 
            // saleVolume
            // 
            this.saleVolume.DataPropertyName = "saleVolume";
            this.saleVolume.HeaderText = "销量";
            this.saleVolume.Name = "saleVolume";
            this.saleVolume.Width = 51;
            // 
            // peixianSituation
            // 
            this.peixianSituation.DataPropertyName = "peixianSituation";
            this.peixianSituation.HeaderText = "配馅情况";
            this.peixianSituation.Name = "peixianSituation";
            this.peixianSituation.Width = 61;
            // 
            // zuodianSituation
            // 
            this.zuodianSituation.DataPropertyName = "zuodianSituation";
            this.zuodianSituation.HeaderText = "做店情况";
            this.zuodianSituation.Name = "zuodianSituation";
            this.zuodianSituation.Width = 61;
            // 
            // lastbrandDate
            // 
            this.lastbrandDate.DataPropertyName = "lastbrandDate";
            this.lastbrandDate.HeaderText = "上次缴商标费日期";
            this.lastbrandDate.Name = "lastbrandDate";
            this.lastbrandDate.Width = 83;
            // 
            // jiamengMoney
            // 
            this.jiamengMoney.DataPropertyName = "jiamengMoney";
            this.jiamengMoney.HeaderText = "加盟费";
            this.jiamengMoney.Name = "jiamengMoney";
            this.jiamengMoney.Width = 61;
            // 
            // baozhengjinMoney
            // 
            this.baozhengjinMoney.DataPropertyName = "baozhengjinMoney";
            this.baozhengjinMoney.HeaderText = "保证金";
            this.baozhengjinMoney.Name = "baozhengjinMoney";
            this.baozhengjinMoney.Width = 61;
            // 
            // brandMoney
            // 
            this.brandMoney.DataPropertyName = "brandMoney";
            this.brandMoney.HeaderText = "商标费";
            this.brandMoney.Name = "brandMoney";
            this.brandMoney.Width = 61;
            // 
            // notes
            // 
            this.notes.DataPropertyName = "notes";
            this.notes.HeaderText = "备注";
            this.notes.Name = "notes";
            this.notes.Width = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "id或名字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "省";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "市";
            // 
            // cbProv
            // 
            this.cbProv.FormattingEnabled = true;
            this.cbProv.Items.AddRange(new object[] {
            "北京",
            "上海",
            "天津",
            "重庆",
            "黑龙江",
            "辽宁",
            "吉林",
            "河北",
            "河南",
            "湖北",
            "湖南",
            "山东",
            "山西",
            "陕西",
            "安徽",
            "浙江",
            "江苏",
            "福建",
            "广东",
            "海南",
            "四川",
            "云南",
            "贵州",
            "青海",
            "甘肃",
            "江西",
            "台湾",
            "内蒙",
            "宁夏",
            "新疆",
            "西藏",
            "广西"});
            this.cbProv.Location = new System.Drawing.Point(89, 81);
            this.cbProv.Name = "cbProv";
            this.cbProv.Size = new System.Drawing.Size(60, 20);
            this.cbProv.TabIndex = 8;
            this.cbProv.SelectedIndexChanged += new System.EventHandler(this.cbProv_SelectedIndexChanged);
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(178, 84);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(82, 20);
            this.cbCity.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "开始日期";
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(324, 83);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(66, 21);
            this.tbStartDate.TabIndex = 11;
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(455, 84);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(69, 21);
            this.tbEndDate.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "截止日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(656, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "月份";
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(703, 43);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(39, 20);
            this.cbMonth.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.name2,
            this.phone2,
            this.prov2,
            this.city2,
            this.address2,
            this.jiamengDate2,
            this.lastbrandDate2,
            this.brandMoney2,
            this.jieyueDate2});
            this.dataGridView2.Location = new System.Drawing.Point(25, 121);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1170, 379);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // id2
            // 
            this.id2.DataPropertyName = "id";
            this.id2.HeaderText = "id";
            this.id2.Name = "id2";
            this.id2.Width = 42;
            // 
            // name2
            // 
            this.name2.DataPropertyName = "name";
            this.name2.HeaderText = "名字";
            this.name2.Name = "name2";
            this.name2.Width = 51;
            // 
            // phone2
            // 
            this.phone2.DataPropertyName = "phone";
            this.phone2.HeaderText = "电话";
            this.phone2.Name = "phone2";
            this.phone2.Width = 51;
            // 
            // prov2
            // 
            this.prov2.DataPropertyName = "prov";
            this.prov2.HeaderText = "省份";
            this.prov2.Name = "prov2";
            this.prov2.Width = 51;
            // 
            // city2
            // 
            this.city2.DataPropertyName = "city";
            this.city2.HeaderText = "城市";
            this.city2.Name = "city2";
            this.city2.Width = 51;
            // 
            // address2
            // 
            this.address2.DataPropertyName = "address";
            this.address2.HeaderText = "地址";
            this.address2.Name = "address2";
            this.address2.Width = 51;
            // 
            // jiamengDate2
            // 
            this.jiamengDate2.DataPropertyName = "jiamengDate";
            this.jiamengDate2.HeaderText = "加盟日期";
            this.jiamengDate2.Name = "jiamengDate2";
            this.jiamengDate2.Width = 61;
            // 
            // lastbrandDate2
            // 
            this.lastbrandDate2.DataPropertyName = "lastbrandDate";
            this.lastbrandDate2.HeaderText = "上次缴费日期";
            this.lastbrandDate2.Name = "lastbrandDate2";
            this.lastbrandDate2.Width = 72;
            // 
            // brandMoney2
            // 
            this.brandMoney2.DataPropertyName = "brandMoney";
            this.brandMoney2.HeaderText = "商标费";
            this.brandMoney2.Name = "brandMoney2";
            this.brandMoney2.Width = 61;
            // 
            // jieyueDate2
            // 
            this.jieyueDate2.DataPropertyName = "jieyueDate";
            this.jieyueDate2.HeaderText = "解约日期";
            this.jieyueDate2.Name = "jieyueDate2";
            this.jieyueDate2.Width = 61;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(287, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 60);
            this.panel2.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(106, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 5;
            this.label16.Text = "家";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 4;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 3;
            this.label14.Text = "未交";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(106, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "家";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "已交";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 541);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "共计";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 542);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "家";
            // 
            // selectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 578);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEndDate);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.cbProv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.tbcontent);
            this.Controls.Add(this.cbSelectWay);
            this.Name = "selectForm";
            this.Text = "selectForm";
            this.Load += new System.EventHandler(this.selectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectWay;
        private System.Windows.Forms.TextBox tbcontent;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProv;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn jiamengDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaiyeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn jieyueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn baozhengjinReturnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn isBaozhengjinReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaiyePeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn constractNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn peixianSituation;
        private System.Windows.Forms.DataGridViewTextBoxColumn zuodianSituation;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastbrandDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn jiamengMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn baozhengjinMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov2;
        private System.Windows.Forms.DataGridViewTextBoxColumn city2;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2;
        private System.Windows.Forms.DataGridViewTextBoxColumn jiamengDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastbrandDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandMoney2;
        private System.Windows.Forms.DataGridViewTextBoxColumn jieyueDate2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}