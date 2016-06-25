namespace Invoicing.Common
{
    partial class ucShopInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtShopname = new System.Windows.Forms.TextBox();
            this.txtShoptel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShopaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "店铺名称";
            // 
            // txtShopname
            // 
            this.txtShopname.Location = new System.Drawing.Point(62, 4);
            this.txtShopname.MaxLength = 120;
            this.txtShopname.Name = "txtShopname";
            this.txtShopname.Size = new System.Drawing.Size(435, 21);
            this.txtShopname.TabIndex = 1;
            // 
            // txtShoptel
            // 
            this.txtShoptel.Location = new System.Drawing.Point(62, 58);
            this.txtShoptel.MaxLength = 120;
            this.txtShoptel.Name = "txtShoptel";
            this.txtShoptel.Size = new System.Drawing.Size(435, 21);
            this.txtShoptel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "联系电话";
            // 
            // txtShopaddress
            // 
            this.txtShopaddress.Location = new System.Drawing.Point(62, 31);
            this.txtShopaddress.MaxLength = 120;
            this.txtShopaddress.Name = "txtShopaddress";
            this.txtShopaddress.Size = new System.Drawing.Size(435, 21);
            this.txtShopaddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "店铺地址";
            // 
            // ucShopInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtShopaddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShoptel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtShopname);
            this.Controls.Add(this.label1);
            this.Name = "ucShopInfo";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShopname;
        private System.Windows.Forms.TextBox txtShoptel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShopaddress;
        private System.Windows.Forms.Label label3;
    }
}
