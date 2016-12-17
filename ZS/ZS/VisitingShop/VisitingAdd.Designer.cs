namespace ZS.VisitingShop
{
    partial class VisitingAdd
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVisiterName = new System.Windows.Forms.TextBox();
            this.tbVisitDate = new System.Windows.Forms.TextBox();
            this.cbIsViolation = new System.Windows.Forms.ComboBox();
            this.tbViolationSituation = new System.Windows.Forms.TextBox();
            this.tbSaleV = new System.Windows.Forms.TextBox();
            this.tbVisitingNotes = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Label();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "巡店员：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "巡店日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "是否违规：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "违规情况：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "销量：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "巡店备注：";
            // 
            // tbVisiterName
            // 
            this.tbVisiterName.Location = new System.Drawing.Point(158, 62);
            this.tbVisiterName.Name = "tbVisiterName";
            this.tbVisiterName.Size = new System.Drawing.Size(100, 21);
            this.tbVisiterName.TabIndex = 6;
            // 
            // tbVisitDate
            // 
            this.tbVisitDate.Location = new System.Drawing.Point(158, 111);
            this.tbVisitDate.Name = "tbVisitDate";
            this.tbVisitDate.Size = new System.Drawing.Size(100, 21);
            this.tbVisitDate.TabIndex = 7;
            // 
            // cbIsViolation
            // 
            this.cbIsViolation.FormattingEnabled = true;
            this.cbIsViolation.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cbIsViolation.Location = new System.Drawing.Point(158, 194);
            this.cbIsViolation.Name = "cbIsViolation";
            this.cbIsViolation.Size = new System.Drawing.Size(57, 20);
            this.cbIsViolation.TabIndex = 8;
            // 
            // tbViolationSituation
            // 
            this.tbViolationSituation.Location = new System.Drawing.Point(158, 273);
            this.tbViolationSituation.Multiline = true;
            this.tbViolationSituation.Name = "tbViolationSituation";
            this.tbViolationSituation.Size = new System.Drawing.Size(165, 141);
            this.tbViolationSituation.TabIndex = 9;
            // 
            // tbSaleV
            // 
            this.tbSaleV.Location = new System.Drawing.Point(415, 19);
            this.tbSaleV.Name = "tbSaleV";
            this.tbSaleV.Size = new System.Drawing.Size(100, 21);
            this.tbSaleV.TabIndex = 10;
            // 
            // tbVisitingNotes
            // 
            this.tbVisitingNotes.Location = new System.Drawing.Point(522, 172);
            this.tbVisitingNotes.Multiline = true;
            this.tbVisitingNotes.Name = "tbVisitingNotes";
            this.tbVisitingNotes.Size = new System.Drawing.Size(213, 256);
            this.tbVisitingNotes.TabIndex = 11;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(210, 442);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(476, 445);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 13;
            this.btClose.Text = "取消";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(76, 22);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(53, 12);
            this.timer.TabIndex = 14;
            this.timer.Text = "巡店次数";
            // 
            // tbTimer
            // 
            this.tbTimer.Location = new System.Drawing.Point(158, 13);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.Size = new System.Drawing.Size(100, 21);
            this.tbTimer.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "不能为空";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "不能为空";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(521, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "不能为空";
            // 
            // VisitingAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbVisitingNotes);
            this.Controls.Add(this.tbSaleV);
            this.Controls.Add(this.tbViolationSituation);
            this.Controls.Add(this.cbIsViolation);
            this.Controls.Add(this.tbVisitDate);
            this.Controls.Add(this.tbVisiterName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VisitingAdd";
            this.Text = "VisitingAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVisiterName;
        private System.Windows.Forms.TextBox tbVisitDate;
        private System.Windows.Forms.ComboBox cbIsViolation;
        private System.Windows.Forms.TextBox tbViolationSituation;
        private System.Windows.Forms.TextBox tbSaleV;
        private System.Windows.Forms.TextBox tbVisitingNotes;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}