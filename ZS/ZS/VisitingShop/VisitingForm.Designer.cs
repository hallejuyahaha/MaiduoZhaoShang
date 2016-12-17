namespace ZS.VisitingShop
{
    partial class VisitingForm
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
            this.timer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isviolation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violationsituation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitingnotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.timer,
            this.visitername,
            this.visitdate,
            this.isviolation,
            this.violationsituation,
            this.saleV,
            this.visitingnotes});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(874, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.DataPropertyName = "timer";
            this.timer.HeaderText = "巡店次数";
            this.timer.Name = "timer";
            this.timer.Width = 78;
            // 
            // visitername
            // 
            this.visitername.DataPropertyName = "visitername";
            this.visitername.HeaderText = "巡店员";
            this.visitername.Name = "visitername";
            this.visitername.Width = 66;
            // 
            // visitdate
            // 
            this.visitdate.DataPropertyName = "visitdate";
            this.visitdate.HeaderText = "巡店日期";
            this.visitdate.Name = "visitdate";
            this.visitdate.Width = 78;
            // 
            // isviolation
            // 
            this.isviolation.DataPropertyName = "isviolation";
            this.isviolation.HeaderText = "是否违规";
            this.isviolation.Name = "isviolation";
            this.isviolation.Width = 78;
            // 
            // violationsituation
            // 
            this.violationsituation.DataPropertyName = "violationsituation";
            this.violationsituation.HeaderText = "违规情况";
            this.violationsituation.Name = "violationsituation";
            this.violationsituation.Width = 78;
            // 
            // saleV
            // 
            this.saleV.DataPropertyName = "saleV";
            this.saleV.HeaderText = "销量";
            this.saleV.Name = "saleV";
            this.saleV.Width = 54;
            // 
            // visitingnotes
            // 
            this.visitingnotes.DataPropertyName = "visitingnotes";
            this.visitingnotes.HeaderText = "备注";
            this.visitingnotes.Name = "visitingnotes";
            this.visitingnotes.Width = 54;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(599, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VisitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VisitingForm";
            this.Text = "VisitingForm";
            this.Load += new System.EventHandler(this.VisitingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitername;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn isviolation;
        private System.Windows.Forms.DataGridViewTextBoxColumn violationsituation;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleV;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitingnotes;
    }
}