namespace Invoicing.Common
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVer = new System.Windows.Forms.Label();
            this.labelOS = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picAppTip = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppTip)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(245, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "警告：本计算机程序受版权法和国际条约保护，如未经授权而擅自复制或传播本程序的部分(或其中任何全部)，将受到严厉的民事和刑事制裁，并将在法律许可的最大限度内受到起诉" +
                "。";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "产品名称：电脑耗材进销存管理系统";
            // 
            // labelVer
            // 
            this.labelVer.AutoSize = true;
            this.labelVer.Location = new System.Drawing.Point(13, 107);
            this.labelVer.Name = "labelVer";
            this.labelVer.Size = new System.Drawing.Size(65, 12);
            this.labelVer.TabIndex = 5;
            this.labelVer.Text = "产品版本：";
            // 
            // labelOS
            // 
            this.labelOS.AutoSize = true;
            this.labelOS.Location = new System.Drawing.Point(13, 137);
            this.labelOS.Name = "labelOS";
            this.labelOS.Size = new System.Drawing.Size(65, 12);
            this.labelOS.TabIndex = 6;
            this.labelOS.Text = "操作系统：";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(13, 169);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(65, 12);
            this.labelTo.TabIndex = 7;
            this.labelTo.Text = "此授权给：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "联系方式：QQ 397199114";
            // 
            // picAppTip
            // 
            this.picAppTip.Image = ((System.Drawing.Image)(resources.GetObject("picAppTip.Image")));
            this.picAppTip.Location = new System.Drawing.Point(288, 80);
            this.picAppTip.Name = "picAppTip";
            this.picAppTip.Size = new System.Drawing.Size(32, 32);
            this.picAppTip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAppTip.TabIndex = 9;
            this.picAppTip.TabStop = false;
            this.picAppTip.Click += new System.EventHandler(this.picAppTip_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 33);
            this.panel1.TabIndex = 10;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picAppTip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelOS);
            this.Controls.Add(this.labelVer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于 - 电脑耗材进销存管理系统";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppTip)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVer;
        private System.Windows.Forms.Label labelOS;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picAppTip;
        private System.Windows.Forms.Panel panel1;
    }
}