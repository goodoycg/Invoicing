namespace Invoicing.Purchas
{
    partial class frmPurchasGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchasGoods));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpInTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGoodscode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numFixPrice = new System.Windows.Forms.NumericUpDown();
            this.txtGoodsname = new System.Windows.Forms.TextBox();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.cbbUnit = new System.Windows.Forms.ComboBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbProvider = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbAdds = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFixPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(5, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 202);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpInTime);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtGoodscode);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numFixPrice);
            this.tabPage1.Controls.Add(this.txtGoodsname);
            this.tabPage1.Controls.Add(this.numCount);
            this.tabPage1.Controls.Add(this.txtRemarks);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.numPrice);
            this.tabPage1.Controls.Add(this.cbbUnit);
            this.tabPage1.Controls.Add(this.cbbType);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cbbProvider);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 177);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpInTime
            // 
            this.dtpInTime.Location = new System.Drawing.Point(400, 49);
            this.dtpInTime.Name = "dtpInTime";
            this.dtpInTime.Size = new System.Drawing.Size(111, 21);
            this.dtpInTime.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "进货时间";
            // 
            // txtGoodscode
            // 
            this.txtGoodscode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGoodscode.Location = new System.Drawing.Point(68, 48);
            this.txtGoodscode.MaxLength = 120;
            this.txtGoodscode.Name = "txtGoodscode";
            this.txtGoodscode.Size = new System.Drawing.Size(277, 21);
            this.txtGoodscode.TabIndex = 25;
            this.txtGoodscode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGoodscode_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "商品编码";
            // 
            // numFixPrice
            // 
            this.numFixPrice.DecimalPlaces = 2;
            this.numFixPrice.Location = new System.Drawing.Point(68, 110);
            this.numFixPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numFixPrice.Name = "numFixPrice";
            this.numFixPrice.Size = new System.Drawing.Size(111, 21);
            this.numFixPrice.TabIndex = 4;
            this.numFixPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFixPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numFixPrice_KeyDown);
            // 
            // txtGoodsname
            // 
            this.txtGoodsname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGoodsname.Location = new System.Drawing.Point(68, 17);
            this.txtGoodsname.MaxLength = 120;
            this.txtGoodsname.Name = "txtGoodsname";
            this.txtGoodsname.Size = new System.Drawing.Size(443, 21);
            this.txtGoodsname.TabIndex = 0;
            this.txtGoodsname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGoodsname_KeyDown);
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(234, 79);
            this.numCount.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(111, 21);
            this.numCount.TabIndex = 2;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numCount_KeyDown);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.Location = new System.Drawing.Point(68, 140);
            this.txtRemarks.MaxLength = 125;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(443, 21);
            this.txtRemarks.TabIndex = 7;
            this.txtRemarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRemarks_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "备    注";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "商品定价";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(400, 79);
            this.numPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(111, 21);
            this.numPrice.TabIndex = 3;
            this.numPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numPrice_KeyDown);
            // 
            // cbbUnit
            // 
            this.cbbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUnit.FormattingEnabled = true;
            this.cbbUnit.Location = new System.Drawing.Point(68, 79);
            this.cbbUnit.Name = "cbbUnit";
            this.cbbUnit.Size = new System.Drawing.Size(111, 20);
            this.cbbUnit.TabIndex = 1;
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(235, 110);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(111, 20);
            this.cbbType.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "进货单价";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "商品单位";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "商品类别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "进货数量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "供应商";
            // 
            // cbbProvider
            // 
            this.cbbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProvider.FormattingEnabled = true;
            this.cbbProvider.Location = new System.Drawing.Point(400, 110);
            this.cbbProvider.Name = "cbbProvider";
            this.cbbProvider.Size = new System.Drawing.Size(111, 20);
            this.cbbProvider.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名称";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(448, 216);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(347, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // cbAdds
            // 
            this.cbAdds.AutoSize = true;
            this.cbAdds.Checked = true;
            this.cbAdds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAdds.Location = new System.Drawing.Point(21, 220);
            this.cbAdds.Name = "cbAdds";
            this.cbAdds.Size = new System.Drawing.Size(72, 16);
            this.cbAdds.TabIndex = 11;
            this.cbAdds.Text = "连续添加";
            this.cbAdds.UseVisualStyleBackColor = true;
            // 
            // frmPurchasGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 245);
            this.Controls.Add(this.cbAdds);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPurchasGoods";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "进货";
            this.Load += new System.EventHandler(this.frmPurchasGoods_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFixPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numFixPrice;
        private System.Windows.Forms.TextBox txtGoodsname;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.ComboBox cbbUnit;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtGoodscode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbAdds;
    }
}