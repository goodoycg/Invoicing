namespace Invoicing.Common
{
    partial class ucOther
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSell2Print = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotethings = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBackupDir = new System.Windows.Forms.TextBox();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSell2Print
            // 
            this.cbSell2Print.AutoSize = true;
            this.cbSell2Print.Location = new System.Drawing.Point(6, 12);
            this.cbSell2Print.Name = "cbSell2Print";
            this.cbSell2Print.Size = new System.Drawing.Size(108, 16);
            this.cbSell2Print.TabIndex = 3;
            this.cbSell2Print.Text = "销售确定时打印";
            this.cbSell2Print.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "注意事项：";
            // 
            // txtNotethings
            // 
            this.txtNotethings.Location = new System.Drawing.Point(6, 50);
            this.txtNotethings.MaxLength = 120;
            this.txtNotethings.Multiline = true;
            this.txtNotethings.Name = "txtNotethings";
            this.txtNotethings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotethings.Size = new System.Drawing.Size(491, 54);
            this.txtNotethings.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "数据备份目录：";
            // 
            // txtBackupDir
            // 
            this.txtBackupDir.Location = new System.Drawing.Point(6, 122);
            this.txtBackupDir.Name = "txtBackupDir";
            this.txtBackupDir.ReadOnly = true;
            this.txtBackupDir.Size = new System.Drawing.Size(468, 21);
            this.txtBackupDir.TabIndex = 7;
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Location = new System.Drawing.Point(475, 121);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(25, 23);
            this.btnSelectDir.TabIndex = 8;
            this.btnSelectDir.Text = "+";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // ucOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSelectDir);
            this.Controls.Add(this.txtBackupDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNotethings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSell2Print);
            this.Name = "ucOther";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSell2Print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotethings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBackupDir;
        private System.Windows.Forms.Button btnSelectDir;
    }
}
