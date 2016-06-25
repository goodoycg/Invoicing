namespace Invoicing.Common
{
    partial class UserManage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManage));
            this.lvUser = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSellInprice = new System.Windows.Forms.CheckBox();
            this.cbShowProfit = new System.Windows.Forms.CheckBox();
            this.cbRecord = new System.Windows.Forms.CheckBox();
            this.cbSell = new System.Windows.Forms.CheckBox();
            this.panelSell = new System.Windows.Forms.Panel();
            this.rbSellSomedays = new System.Windows.Forms.RadioButton();
            this.rbSellAll = new System.Windows.Forms.RadioButton();
            this.rbSellToday = new System.Windows.Forms.RadioButton();
            this.cbSystemSet = new System.Windows.Forms.CheckBox();
            this.cbProvider = new System.Windows.Forms.CheckBox();
            this.cbCancelSell = new System.Windows.Forms.CheckBox();
            this.cbDeleteSell = new System.Windows.Forms.CheckBox();
            this.cbPurchas = new System.Windows.Forms.CheckBox();
            this.cbUser = new System.Windows.Forms.CheckBox();
            this.cbStock = new System.Windows.Forms.CheckBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtRePW = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelSell.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvUser
            // 
            this.lvUser.BackColor = System.Drawing.Color.White;
            this.lvUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader13,
            this.columnHeader12});
            this.lvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUser.FullRowSelect = true;
            this.lvUser.GridLines = true;
            this.lvUser.HideSelection = false;
            this.lvUser.Location = new System.Drawing.Point(0, 0);
            this.lvUser.Name = "lvUser";
            this.lvUser.Size = new System.Drawing.Size(1128, 301);
            this.lvUser.SmallImageList = this.imageList1;
            this.lvUser.TabIndex = 2;
            this.lvUser.UseCompatibleStateImageBehavior = false;
            this.lvUser.View = System.Windows.Forms.View.Details;
            this.lvUser.SelectedIndexChanged += new System.EventHandler(this.lvUser_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "用户名";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "进货";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "销售";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "库存";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "用户管理";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "供应商管理";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "配置管理";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "作废销售单";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "删除销售单";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "记账";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "显示盈利";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "进货单价（销售）";
            this.columnHeader13.Width = 120;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "备注";
            this.columnHeader12.Width = 120;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txtPW);
            this.panel2.Controls.Add(this.txtRemarks);
            this.panel2.Controls.Add(this.txtRePW);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 144);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSellInprice);
            this.groupBox1.Controls.Add(this.cbShowProfit);
            this.groupBox1.Controls.Add(this.cbRecord);
            this.groupBox1.Controls.Add(this.cbSell);
            this.groupBox1.Controls.Add(this.panelSell);
            this.groupBox1.Controls.Add(this.cbSystemSet);
            this.groupBox1.Controls.Add(this.cbProvider);
            this.groupBox1.Controls.Add(this.cbCancelSell);
            this.groupBox1.Controls.Add(this.cbDeleteSell);
            this.groupBox1.Controls.Add(this.cbPurchas);
            this.groupBox1.Controls.Add(this.cbUser);
            this.groupBox1.Controls.Add(this.cbStock);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 81);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "权限";
            // 
            // cbSellInprice
            // 
            this.cbSellInprice.AutoSize = true;
            this.cbSellInprice.Location = new System.Drawing.Point(750, 18);
            this.cbSellInprice.Name = "cbSellInprice";
            this.cbSellInprice.Size = new System.Drawing.Size(132, 16);
            this.cbSellInprice.TabIndex = 18;
            this.cbSellInprice.Text = "销售进货单价及金额";
            this.cbSellInprice.UseVisualStyleBackColor = true;
            // 
            // cbShowProfit
            // 
            this.cbShowProfit.AutoSize = true;
            this.cbShowProfit.Location = new System.Drawing.Point(674, 18);
            this.cbShowProfit.Name = "cbShowProfit";
            this.cbShowProfit.Size = new System.Drawing.Size(72, 16);
            this.cbShowProfit.TabIndex = 17;
            this.cbShowProfit.Text = "显示盈利";
            this.cbShowProfit.UseVisualStyleBackColor = true;
            // 
            // cbRecord
            // 
            this.cbRecord.AutoSize = true;
            this.cbRecord.Location = new System.Drawing.Point(622, 18);
            this.cbRecord.Name = "cbRecord";
            this.cbRecord.Size = new System.Drawing.Size(48, 16);
            this.cbRecord.TabIndex = 16;
            this.cbRecord.Text = "记账";
            this.cbRecord.UseVisualStyleBackColor = true;
            // 
            // cbSell
            // 
            this.cbSell.AutoSize = true;
            this.cbSell.Location = new System.Drawing.Point(102, 18);
            this.cbSell.Name = "cbSell";
            this.cbSell.Size = new System.Drawing.Size(48, 16);
            this.cbSell.TabIndex = 15;
            this.cbSell.Text = "销售";
            this.cbSell.UseVisualStyleBackColor = true;
            this.cbSell.CheckedChanged += new System.EventHandler(this.cbSell_CheckedChanged);
            // 
            // panelSell
            // 
            this.panelSell.Controls.Add(this.rbSellSomedays);
            this.panelSell.Controls.Add(this.rbSellAll);
            this.panelSell.Controls.Add(this.rbSellToday);
            this.panelSell.Enabled = false;
            this.panelSell.Location = new System.Drawing.Point(48, 40);
            this.panelSell.Name = "panelSell";
            this.panelSell.Size = new System.Drawing.Size(551, 31);
            this.panelSell.TabIndex = 14;
            // 
            // rbSellSomedays
            // 
            this.rbSellSomedays.AutoSize = true;
            this.rbSellSomedays.Location = new System.Drawing.Point(177, 8);
            this.rbSellSomedays.Name = "rbSellSomedays";
            this.rbSellSomedays.Size = new System.Drawing.Size(179, 16);
            this.rbSellSomedays.TabIndex = 2;
            this.rbSellSomedays.Text = "销售-可查看最近5天销售记录";
            this.rbSellSomedays.UseVisualStyleBackColor = true;
            // 
            // rbSellAll
            // 
            this.rbSellAll.AutoSize = true;
            this.rbSellAll.Location = new System.Drawing.Point(368, 8);
            this.rbSellAll.Name = "rbSellAll";
            this.rbSellAll.Size = new System.Drawing.Size(161, 16);
            this.rbSellAll.TabIndex = 1;
            this.rbSellAll.Text = "销售-可查看全部销售记录";
            this.rbSellAll.UseVisualStyleBackColor = true;
            // 
            // rbSellToday
            // 
            this.rbSellToday.AutoSize = true;
            this.rbSellToday.Checked = true;
            this.rbSellToday.Location = new System.Drawing.Point(4, 8);
            this.rbSellToday.Name = "rbSellToday";
            this.rbSellToday.Size = new System.Drawing.Size(161, 16);
            this.rbSellToday.TabIndex = 0;
            this.rbSellToday.TabStop = true;
            this.rbSellToday.Text = "销售-可查看当天销售记录";
            this.rbSellToday.UseVisualStyleBackColor = true;
            // 
            // cbSystemSet
            // 
            this.cbSystemSet.AutoSize = true;
            this.cbSystemSet.Location = new System.Drawing.Point(370, 18);
            this.cbSystemSet.Name = "cbSystemSet";
            this.cbSystemSet.Size = new System.Drawing.Size(72, 16);
            this.cbSystemSet.TabIndex = 12;
            this.cbSystemSet.Text = "配置管理";
            this.cbSystemSet.UseVisualStyleBackColor = true;
            // 
            // cbProvider
            // 
            this.cbProvider.AutoSize = true;
            this.cbProvider.Location = new System.Drawing.Point(282, 18);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(84, 16);
            this.cbProvider.TabIndex = 11;
            this.cbProvider.Text = "供应商管理";
            this.cbProvider.UseVisualStyleBackColor = true;
            // 
            // cbCancelSell
            // 
            this.cbCancelSell.AutoSize = true;
            this.cbCancelSell.Enabled = false;
            this.cbCancelSell.Location = new System.Drawing.Point(446, 18);
            this.cbCancelSell.Name = "cbCancelSell";
            this.cbCancelSell.Size = new System.Drawing.Size(84, 16);
            this.cbCancelSell.TabIndex = 9;
            this.cbCancelSell.Text = "作废销售单";
            this.cbCancelSell.UseVisualStyleBackColor = true;
            // 
            // cbDeleteSell
            // 
            this.cbDeleteSell.AutoSize = true;
            this.cbDeleteSell.Enabled = false;
            this.cbDeleteSell.Location = new System.Drawing.Point(534, 18);
            this.cbDeleteSell.Name = "cbDeleteSell";
            this.cbDeleteSell.Size = new System.Drawing.Size(84, 16);
            this.cbDeleteSell.TabIndex = 10;
            this.cbDeleteSell.Text = "删除销售单";
            this.cbDeleteSell.UseVisualStyleBackColor = true;
            // 
            // cbPurchas
            // 
            this.cbPurchas.AutoSize = true;
            this.cbPurchas.Location = new System.Drawing.Point(50, 18);
            this.cbPurchas.Name = "cbPurchas";
            this.cbPurchas.Size = new System.Drawing.Size(48, 16);
            this.cbPurchas.TabIndex = 1;
            this.cbPurchas.Text = "进货";
            this.cbPurchas.UseVisualStyleBackColor = true;
            // 
            // cbUser
            // 
            this.cbUser.AutoSize = true;
            this.cbUser.Location = new System.Drawing.Point(206, 18);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(72, 16);
            this.cbUser.TabIndex = 8;
            this.cbUser.Text = "用户管理";
            this.cbUser.UseVisualStyleBackColor = true;
            // 
            // cbStock
            // 
            this.cbStock.AutoSize = true;
            this.cbStock.Location = new System.Drawing.Point(154, 18);
            this.cbStock.Name = "cbStock";
            this.cbStock.Size = new System.Drawing.Size(48, 16);
            this.cbStock.TabIndex = 3;
            this.cbStock.Text = "库存";
            this.cbStock.UseVisualStyleBackColor = true;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(237, 14);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(100, 21);
            this.txtPW.TabIndex = 7;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(96, 41);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(406, 21);
            this.txtRemarks.TabIndex = 6;
            // 
            // txtRePW
            // 
            this.txtRePW.Location = new System.Drawing.Point(402, 14);
            this.txtRePW.Name = "txtRePW";
            this.txtRePW.PasswordChar = '*';
            this.txtRePW.Size = new System.Drawing.Size(100, 21);
            this.txtRePW.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(96, 14);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 21);
            this.txtUsername.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "备　注";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "重复密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(1003, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 301);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1128, 175);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1120, 150);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "用户信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(839, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "增加(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Location = new System.Drawing.Point(921, 6);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "修改(&M)";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 36);
            this.panel1.TabIndex = 12;
            // 
            // UserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 512);
            this.Controls.Add(this.lvUser);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.UserManage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelSell.ResumeLayout(false);
            this.panelSell.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbStock;
        private System.Windows.Forms.CheckBox cbPurchas;
        private System.Windows.Forms.ListView lvUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtRePW;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.CheckBox cbUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbDeleteSell;
        private System.Windows.Forms.CheckBox cbCancelSell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSystemSet;
        private System.Windows.Forms.CheckBox cbProvider;
        private System.Windows.Forms.Panel panelSell;
        private System.Windows.Forms.RadioButton rbSellSomedays;
        private System.Windows.Forms.RadioButton rbSellAll;
        private System.Windows.Forms.RadioButton rbSellToday;
        private System.Windows.Forms.CheckBox cbSell;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.CheckBox cbRecord;
        private System.Windows.Forms.CheckBox cbShowProfit;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.CheckBox cbSellInprice;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}