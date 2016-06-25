namespace Invoicing.Sell
{
    partial class ucSell
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSell));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tabControlSell = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProfit = new System.Windows.Forms.Label();
            this.labelProfit_ = new System.Windows.Forms.Label();
            this.labelFixpriceTotal = new System.Windows.Forms.Label();
            this.labelFixpriceTotal_ = new System.Windows.Forms.Label();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.labelTotalCount_ = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotal_ = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SellContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuSellGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuCancelSell = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteSell = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuResetSell = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuInvoicing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.lvSell = new Invoicing.Common.ListViewSoftEditable(this.components);
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelLeft.SuspendLayout();
            this.tabControlSell.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SellContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.tabControlSell);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(211, 280);
            this.panelLeft.TabIndex = 7;
            // 
            // tabControlSell
            // 
            this.tabControlSell.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlSell.Controls.Add(this.tabPage4);
            this.tabControlSell.Controls.Add(this.tabPage1);
            this.tabControlSell.Controls.Add(this.tabPage2);
            this.tabControlSell.Controls.Add(this.tabPage3);
            this.tabControlSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSell.Location = new System.Drawing.Point(0, 0);
            this.tabControlSell.Name = "tabControlSell";
            this.tabControlSell.SelectedIndex = 0;
            this.tabControlSell.Size = new System.Drawing.Size(211, 280);
            this.tabControlSell.TabIndex = 1;
            this.tabControlSell.SelectedIndexChanged += new System.EventHandler(this.tabControlSell_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(203, 255);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "最近销售";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(203, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "日期";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(203, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "类别";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(203, 255);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "供应商";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelProfit);
            this.panel1.Controls.Add(this.labelProfit_);
            this.panel1.Controls.Add(this.labelFixpriceTotal);
            this.panel1.Controls.Add(this.labelFixpriceTotal_);
            this.panel1.Controls.Add(this.labelTotalCount);
            this.panel1.Controls.Add(this.labelTotalCount_);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.labelTotal_);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(211, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 25);
            this.panel1.TabIndex = 10;
            // 
            // labelProfit
            // 
            this.labelProfit.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelProfit.Location = new System.Drawing.Point(537, 0);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(71, 25);
            this.labelProfit.TabIndex = 26;
            this.labelProfit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProfit_
            // 
            this.labelProfit_.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelProfit_.Location = new System.Drawing.Point(471, 0);
            this.labelProfit_.Name = "labelProfit_";
            this.labelProfit_.Size = new System.Drawing.Size(66, 25);
            this.labelProfit_.TabIndex = 25;
            this.labelProfit_.Text = "盈利(元)：";
            this.labelProfit_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFixpriceTotal
            // 
            this.labelFixpriceTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFixpriceTotal.Location = new System.Drawing.Point(400, 0);
            this.labelFixpriceTotal.Name = "labelFixpriceTotal";
            this.labelFixpriceTotal.Size = new System.Drawing.Size(71, 25);
            this.labelFixpriceTotal.TabIndex = 24;
            this.labelFixpriceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFixpriceTotal_
            // 
            this.labelFixpriceTotal_.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFixpriceTotal_.Location = new System.Drawing.Point(309, 0);
            this.labelFixpriceTotal_.Name = "labelFixpriceTotal_";
            this.labelFixpriceTotal_.Size = new System.Drawing.Size(91, 25);
            this.labelFixpriceTotal_.TabIndex = 23;
            this.labelFixpriceTotal_.Text = "定价金额(元)：";
            this.labelFixpriceTotal_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalCount
            // 
            this.labelTotalCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotalCount.Location = new System.Drawing.Point(238, 0);
            this.labelTotalCount.Name = "labelTotalCount";
            this.labelTotalCount.Size = new System.Drawing.Size(71, 25);
            this.labelTotalCount.TabIndex = 19;
            this.labelTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalCount_
            // 
            this.labelTotalCount_.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotalCount_.Location = new System.Drawing.Point(147, 0);
            this.labelTotalCount_.Name = "labelTotalCount_";
            this.labelTotalCount_.Size = new System.Drawing.Size(91, 25);
            this.labelTotalCount_.TabIndex = 18;
            this.labelTotalCount_.Text = "合计数量(个)：";
            this.labelTotalCount_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotal
            // 
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotal.Location = new System.Drawing.Point(76, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(71, 25);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotal_
            // 
            this.labelTotal_.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotal_.Location = new System.Drawing.Point(0, 0);
            this.labelTotal_.Name = "labelTotal_";
            this.labelTotal_.Size = new System.Drawing.Size(76, 25);
            this.labelTotal_.TabIndex = 0;
            this.labelTotal_.Text = "合计(元)：";
            this.labelTotal_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SellContextMenu
            // 
            this.SellContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSellGoods,
            this.toolStripMenuItem1,
            this.MenuCancelSell,
            this.MenuDeleteSell,
            this.toolStripMenuItem2,
            this.MenuResetSell,
            this.toolStripMenuItem3,
            this.MenuInvoicing,
            this.toolStripMenuItem4,
            this.MenuSearch,
            this.MenuCopy});
            this.SellContextMenu.Name = "SellContextMenu";
            this.SellContextMenu.Size = new System.Drawing.Size(149, 182);
            this.SellContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.SellContextMenu_Opening);
            // 
            // MenuSellGoods
            // 
            this.MenuSellGoods.Image = ((System.Drawing.Image)(resources.GetObject("MenuSellGoods.Image")));
            this.MenuSellGoods.Name = "MenuSellGoods";
            this.MenuSellGoods.Size = new System.Drawing.Size(148, 22);
            this.MenuSellGoods.Text = "销售商品(&S)";
            this.MenuSellGoods.Click += new System.EventHandler(this.MenuSellGoods_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // MenuCancelSell
            // 
            this.MenuCancelSell.Image = ((System.Drawing.Image)(resources.GetObject("MenuCancelSell.Image")));
            this.MenuCancelSell.Name = "MenuCancelSell";
            this.MenuCancelSell.Size = new System.Drawing.Size(148, 22);
            this.MenuCancelSell.Text = "作废销售(&F)";
            this.MenuCancelSell.Click += new System.EventHandler(this.MenuCancelSell_Click);
            // 
            // MenuDeleteSell
            // 
            this.MenuDeleteSell.Image = ((System.Drawing.Image)(resources.GetObject("MenuDeleteSell.Image")));
            this.MenuDeleteSell.Name = "MenuDeleteSell";
            this.MenuDeleteSell.Size = new System.Drawing.Size(148, 22);
            this.MenuDeleteSell.Text = "删除销售单(&D)";
            this.MenuDeleteSell.Click += new System.EventHandler(this.MenuDeleteSell_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 6);
            // 
            // MenuResetSell
            // 
            this.MenuResetSell.Image = ((System.Drawing.Image)(resources.GetObject("MenuResetSell.Image")));
            this.MenuResetSell.Name = "MenuResetSell";
            this.MenuResetSell.Size = new System.Drawing.Size(148, 22);
            this.MenuResetSell.Text = "恢复销售(&R)";
            this.MenuResetSell.Click += new System.EventHandler(this.MenuResetSell_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 6);
            // 
            // MenuInvoicing
            // 
            this.MenuInvoicing.Name = "MenuInvoicing";
            this.MenuInvoicing.Size = new System.Drawing.Size(148, 22);
            this.MenuInvoicing.Text = "进销存信息(&I)";
            this.MenuInvoicing.Click += new System.EventHandler(this.MenuInvoicing_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(145, 6);
            // 
            // MenuSearch
            // 
            this.MenuSearch.Image = ((System.Drawing.Image)(resources.GetObject("MenuSearch.Image")));
            this.MenuSearch.Name = "MenuSearch";
            this.MenuSearch.Size = new System.Drawing.Size(148, 22);
            this.MenuSearch.Text = "查找(&F)";
            this.MenuSearch.Click += new System.EventHandler(this.MenuSearch_Click);
            // 
            // MenuCopy
            // 
            this.MenuCopy.Name = "MenuCopy";
            this.MenuCopy.Size = new System.Drawing.Size(148, 22);
            this.MenuCopy.Text = "复制(&C)";
            this.MenuCopy.Click += new System.EventHandler(this.MenuCopy_Click);
            // 
            // lvSell
            // 
            this.lvSell.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader13,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader3,
            this.columnHeader11,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader12});
            this.lvSell.ContextMenuStrip = this.SellContextMenu;
            this.lvSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSell.FullRowSelect = true;
            this.lvSell.GridLines = true;
            this.lvSell.HideSelection = false;
            this.lvSell.ListDecimalColumnIndex = ((System.Collections.Generic.List<int>)(resources.GetObject("lvSell.ListDecimalColumnIndex")));
            this.lvSell.Location = new System.Drawing.Point(211, 0);
            this.lvSell.MultiSelect = false;
            this.lvSell.Name = "lvSell";
            this.lvSell.Size = new System.Drawing.Size(1103, 255);
            this.lvSell.SmallImageList = this.imageList1;
            this.lvSell.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvSell.TabIndex = 8;
            this.lvSell.UseCompatibleStateImageBehavior = false;
            this.lvSell.View = System.Windows.Forms.View.Details;
            this.lvSell.SelectedIndexChanged += new System.EventHandler(this.lvSell_SelectedIndexChanged);
            this.lvSell.DoubleClick += new System.EventHandler(this.lvSell_DoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "序号";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "销售时间";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名称";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "商品编码";
            this.columnHeader13.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "商品单位";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "商品类别";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "供应商";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "销售数量";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "商品定价";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "销售单价";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "金额";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "盈利";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "备注";
            this.columnHeader12.Width = 500;
            // 
            // ucSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvSell);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Name = "ucSell";
            this.Size = new System.Drawing.Size(1314, 280);
            this.panelLeft.ResumeLayout(false);
            this.tabControlSell.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SellContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotal_;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private Invoicing.Common.ListViewSoftEditable lvSell;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabControl tabControlSell;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label labelTotalCount;
        private System.Windows.Forms.Label labelTotalCount_;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label labelFixpriceTotal;
        private System.Windows.Forms.Label labelFixpriceTotal_;
        private System.Windows.Forms.Label labelProfit;
        private System.Windows.Forms.Label labelProfit_;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ContextMenuStrip SellContextMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuSellGoods;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuCancelSell;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteSell;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuResetSell;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MenuCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuInvoicing;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}
