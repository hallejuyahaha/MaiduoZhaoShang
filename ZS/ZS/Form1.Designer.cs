namespace ZS
{
    partial class Form1
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
            this.btAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btUpdata = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btVisiting = new System.Windows.Forms.Button();
            this.btBrand = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.谁的商标使用费没交ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记事本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(2, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1206, 500);
            this.dataGridView1.TabIndex = 0;
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
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.Width = 51;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "电话";
            this.phone.Name = "phone";
            this.phone.Width = 51;
            // 
            // prov
            // 
            this.prov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prov.DataPropertyName = "prov";
            this.prov.HeaderText = "省份";
            this.prov.Name = "prov";
            this.prov.Width = 51;
            // 
            // city
            // 
            this.city.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.city.DataPropertyName = "city";
            this.city.HeaderText = "城市";
            this.city.Name = "city";
            this.city.Width = 51;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "地址";
            this.address.Name = "address";
            this.address.Width = 51;
            // 
            // jiamengDate
            // 
            this.jiamengDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jiamengDate.DataPropertyName = "jiamengDate";
            this.jiamengDate.HeaderText = "加盟日期";
            this.jiamengDate.Name = "jiamengDate";
            this.jiamengDate.Width = 61;
            // 
            // kaiyeDate
            // 
            this.kaiyeDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kaiyeDate.DataPropertyName = "kaiyeDate";
            this.kaiyeDate.HeaderText = "开业日期";
            this.kaiyeDate.Name = "kaiyeDate";
            this.kaiyeDate.Width = 61;
            // 
            // jieyueDate
            // 
            this.jieyueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jieyueDate.DataPropertyName = "jieyueDate";
            this.jieyueDate.HeaderText = "解约日期";
            this.jieyueDate.Name = "jieyueDate";
            this.jieyueDate.Width = 61;
            // 
            // baozhengjinReturnData
            // 
            this.baozhengjinReturnData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.baozhengjinReturnData.DataPropertyName = "baozhengjinReturnData";
            this.baozhengjinReturnData.HeaderText = "保证金退还日期";
            this.baozhengjinReturnData.Name = "baozhengjinReturnData";
            this.baozhengjinReturnData.Width = 83;
            // 
            // isBaozhengjinReturn
            // 
            this.isBaozhengjinReturn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isBaozhengjinReturn.DataPropertyName = "isBaozhengjinReturn";
            this.isBaozhengjinReturn.HeaderText = "保证金是否退还";
            this.isBaozhengjinReturn.Name = "isBaozhengjinReturn";
            this.isBaozhengjinReturn.Width = 83;
            // 
            // kaiyePeople
            // 
            this.kaiyePeople.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kaiyePeople.DataPropertyName = "kaiyePeople";
            this.kaiyePeople.HeaderText = "开业人员";
            this.kaiyePeople.Name = "kaiyePeople";
            this.kaiyePeople.Width = 61;
            // 
            // constractNumber
            // 
            this.constractNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.constractNumber.DataPropertyName = "constractNumber";
            this.constractNumber.HeaderText = "合同编号";
            this.constractNumber.Name = "constractNumber";
            this.constractNumber.Width = 61;
            // 
            // saleVolume
            // 
            this.saleVolume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.saleVolume.DataPropertyName = "saleVolume";
            this.saleVolume.HeaderText = "销量";
            this.saleVolume.Name = "saleVolume";
            this.saleVolume.Width = 51;
            // 
            // peixianSituation
            // 
            this.peixianSituation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.peixianSituation.DataPropertyName = "peixianSituation";
            this.peixianSituation.HeaderText = "配线情况";
            this.peixianSituation.Name = "peixianSituation";
            this.peixianSituation.Width = 61;
            // 
            // zuodianSituation
            // 
            this.zuodianSituation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.zuodianSituation.DataPropertyName = "zuodianSituation";
            this.zuodianSituation.HeaderText = "做店情况";
            this.zuodianSituation.Name = "zuodianSituation";
            this.zuodianSituation.Width = 61;
            // 
            // lastbrandDate
            // 
            this.lastbrandDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lastbrandDate.DataPropertyName = "lastbrandDate";
            this.lastbrandDate.HeaderText = "上次缴商标费日期";
            this.lastbrandDate.Name = "lastbrandDate";
            this.lastbrandDate.Width = 83;
            // 
            // jiamengMoney
            // 
            this.jiamengMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jiamengMoney.DataPropertyName = "jiamengMoney";
            this.jiamengMoney.HeaderText = "加盟费";
            this.jiamengMoney.Name = "jiamengMoney";
            this.jiamengMoney.Width = 61;
            // 
            // baozhengjinMoney
            // 
            this.baozhengjinMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            this.notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.notes.DataPropertyName = "notes";
            this.notes.HeaderText = "备注";
            this.notes.Name = "notes";
            this.notes.Width = 51;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(87, 580);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "添加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btUpdata
            // 
            this.btUpdata.Location = new System.Drawing.Point(306, 580);
            this.btUpdata.Name = "btUpdata";
            this.btUpdata.Size = new System.Drawing.Size(75, 23);
            this.btUpdata.TabIndex = 3;
            this.btUpdata.Text = "修改";
            this.btUpdata.UseVisualStyleBackColor = true;
            this.btUpdata.Click += new System.EventHandler(this.btUpdata_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(417, 580);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btVisiting
            // 
            this.btVisiting.Location = new System.Drawing.Point(706, 580);
            this.btVisiting.Name = "btVisiting";
            this.btVisiting.Size = new System.Drawing.Size(75, 23);
            this.btVisiting.TabIndex = 5;
            this.btVisiting.Text = "讯店情况";
            this.btVisiting.UseVisualStyleBackColor = true;
            this.btVisiting.Click += new System.EventHandler(this.btVisiting_Click);
            // 
            // btBrand
            // 
            this.btBrand.Location = new System.Drawing.Point(815, 580);
            this.btBrand.Name = "btBrand";
            this.btBrand.Size = new System.Drawing.Size(102, 23);
            this.btBrand.TabIndex = 7;
            this.btBrand.Text = "商标使用费情况";
            this.btBrand.UseVisualStyleBackColor = true;
            this.btBrand.Click += new System.EventHandler(this.btBrand_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1220, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.谁的商标使用费没交ToolStripMenuItem,
            this.刷新ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 谁的商标使用费没交ToolStripMenuItem
            // 
            this.谁的商标使用费没交ToolStripMenuItem.Name = "谁的商标使用费没交ToolStripMenuItem";
            this.谁的商标使用费没交ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.谁的商标使用费没交ToolStripMenuItem.Text = "谁的商标使用费没交";
            this.谁的商标使用费没交ToolStripMenuItem.Click += new System.EventHandler(this.谁的商标使用费没交ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算器ToolStripMenuItem,
            this.记事本ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 计算器ToolStripMenuItem
            // 
            this.计算器ToolStripMenuItem.Name = "计算器ToolStripMenuItem";
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.计算器ToolStripMenuItem.Text = "计算器";
            this.计算器ToolStripMenuItem.Click += new System.EventHandler(this.计算器ToolStripMenuItem_Click);
            // 
            // 记事本ToolStripMenuItem
            // 
            this.记事本ToolStripMenuItem.Name = "记事本ToolStripMenuItem";
            this.记事本ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.记事本ToolStripMenuItem.Text = "记事本";
            this.记事本ToolStripMenuItem.Click += new System.EventHandler(this.记事本ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 643);
            this.Controls.Add(this.btBrand);
            this.Controls.Add(this.btVisiting);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btUpdata);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btUpdata;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btVisiting;
        private System.Windows.Forms.Button btBrand;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记事本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 谁的商标使用费没交ToolStripMenuItem;
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

    }
}