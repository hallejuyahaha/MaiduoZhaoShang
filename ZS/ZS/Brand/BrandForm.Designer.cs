namespace ZS.Brand
{
    partial class BrandForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jiaofeiData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jiaofeiMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jiaofeiNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbAdd = new System.Windows.Forms.Button();
            this.tbdelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMoney = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "缴费日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "缴费金额";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jiaofeiData,
            this.jiaofeiMoney,
            this.jiaofeiNotes});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // jiaofeiData
            // 
            this.jiaofeiData.DataPropertyName = "jiaofeiData";
            this.jiaofeiData.HeaderText = "缴费日期";
            this.jiaofeiData.Name = "jiaofeiData";
            // 
            // jiaofeiMoney
            // 
            this.jiaofeiMoney.DataPropertyName = "jiaofeiMoney";
            this.jiaofeiMoney.HeaderText = "缴费金额";
            this.jiaofeiMoney.Name = "jiaofeiMoney";
            // 
            // jiaofeiNotes
            // 
            this.jiaofeiNotes.DataPropertyName = "jiaofeiNotes";
            this.jiaofeiNotes.HeaderText = "缴费备注";
            this.jiaofeiNotes.Name = "jiaofeiNotes";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(110, 284);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 21);
            this.tbDate.TabIndex = 3;
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(191, 380);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(75, 23);
            this.tbAdd.TabIndex = 5;
            this.tbAdd.Text = "添加";
            this.tbAdd.UseVisualStyleBackColor = true;
            this.tbAdd.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // tbdelete
            // 
            this.tbdelete.Location = new System.Drawing.Point(642, 380);
            this.tbdelete.Name = "tbdelete";
            this.tbdelete.Size = new System.Drawing.Size(75, 23);
            this.tbdelete.TabIndex = 6;
            this.tbdelete.Text = "删除";
            this.tbdelete.UseVisualStyleBackColor = true;
            this.tbdelete.Click += new System.EventHandler(this.tbdelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "备注";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 241);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 162);
            this.textBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "缴费日期 缴费金额不能为空";
            // 
            // tbMoney
            // 
            this.tbMoney.FormattingEnabled = true;
            this.tbMoney.Items.AddRange(new object[] {
            "5000",
            "10000"});
            this.tbMoney.Location = new System.Drawing.Point(110, 344);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(100, 20);
            this.tbMoney.TabIndex = 10;
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 406);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbdelete);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BrandForm";
            this.Text = "BrandForm";
            this.Load += new System.EventHandler(this.BrandForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Button tbAdd;
        private System.Windows.Forms.Button tbdelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jiaofeiData;
        private System.Windows.Forms.DataGridViewTextBoxColumn jiaofeiMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn jiaofeiNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tbMoney;
    }
}