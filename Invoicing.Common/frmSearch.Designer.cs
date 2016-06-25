namespace Invoicing.Common
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbFuzzy = new System.Windows.Forms.RadioButton();
            this.rbNoFuzzy = new System.Windows.Forms.RadioButton();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.labelGoodsname = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtGoodsCode = new System.Windows.Forms.TextBox();
            this.labelGoodscode = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 124);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtGoodsCode);
            this.tabPage1.Controls.Add(this.labelGoodscode);
            this.tabPage1.Controls.Add(this.rbFuzzy);
            this.tabPage1.Controls.Add(this.rbNoFuzzy);
            this.tabPage1.Controls.Add(this.txtGoodsName);
            this.tabPage1.Controls.Add(this.labelGoodsname);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 99);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置条件";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbFuzzy
            // 
            this.rbFuzzy.AutoSize = true;
            this.rbFuzzy.Location = new System.Drawing.Point(140, 76);
            this.rbFuzzy.Name = "rbFuzzy";
            this.rbFuzzy.Size = new System.Drawing.Size(47, 16);
            this.rbFuzzy.TabIndex = 4;
            this.rbFuzzy.Text = "模糊";
            this.rbFuzzy.UseVisualStyleBackColor = true;
            // 
            // rbNoFuzzy
            // 
            this.rbNoFuzzy.AutoSize = true;
            this.rbNoFuzzy.Checked = true;
            this.rbNoFuzzy.Location = new System.Drawing.Point(87, 76);
            this.rbNoFuzzy.Name = "rbNoFuzzy";
            this.rbNoFuzzy.Size = new System.Drawing.Size(47, 16);
            this.rbNoFuzzy.TabIndex = 3;
            this.rbNoFuzzy.TabStop = true;
            this.rbNoFuzzy.Text = "精准";
            this.rbNoFuzzy.UseVisualStyleBackColor = true;
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(63, 35);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(280, 21);
            this.txtGoodsName.TabIndex = 2;
            this.txtGoodsName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGoodsName_KeyDown);
            // 
            // labelGoodsname
            // 
            this.labelGoodsname.AutoSize = true;
            this.labelGoodsname.Location = new System.Drawing.Point(4, 38);
            this.labelGoodsname.Name = "labelGoodsname";
            this.labelGoodsname.Size = new System.Drawing.Size(53, 12);
            this.labelGoodsname.TabIndex = 1;
            this.labelGoodsname.Text = "商品名称";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(184, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "取消(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(265, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "确定(&O)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtGoodsCode
            // 
            this.txtGoodsCode.Location = new System.Drawing.Point(63, 46);
            this.txtGoodsCode.Name = "txtGoodsCode";
            this.txtGoodsCode.Size = new System.Drawing.Size(280, 21);
            this.txtGoodsCode.TabIndex = 6;
            this.txtGoodsCode.Visible = false;
            this.txtGoodsCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGoodsCode_KeyDown);
            // 
            // labelGoodscode
            // 
            this.labelGoodscode.AutoSize = true;
            this.labelGoodscode.Location = new System.Drawing.Point(4, 49);
            this.labelGoodscode.Name = "labelGoodscode";
            this.labelGoodscode.Size = new System.Drawing.Size(53, 12);
            this.labelGoodscode.TabIndex = 5;
            this.labelGoodscode.Text = "商品编码";
            this.labelGoodscode.Visible = false;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 166);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbFuzzy;
        private System.Windows.Forms.RadioButton rbNoFuzzy;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label labelGoodsname;
        private System.Windows.Forms.TextBox txtGoodsCode;
        private System.Windows.Forms.Label labelGoodscode;
    }
}