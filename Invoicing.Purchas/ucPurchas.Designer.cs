namespace Invoicing.Purchas
{
    partial class ucPurchas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPurchas));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tabControlGoods = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageListTab = new System.Windows.Forms.ImageList(this.components);
            this.panelStat = new System.Windows.Forms.Panel();
            this.label1FixpriceTotal = new System.Windows.Forms.Label();
            this.label1FixpriceTotal_ = new System.Windows.Forms.Label();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.labelTotalCount_ = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotal_ = new System.Windows.Forms.Label();
            this.PurchasContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuModify = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuInvoicing = new System.Windows.Forms.ToolStripMenuItem();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelColumn = new System.Windows.Forms.Panel();
            this.chartColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelChartType = new System.Windows.Forms.Panel();
            this.cb3D = new System.Windows.Forms.CheckBox();
            this.rbProvider = new System.Windows.Forms.RadioButton();
            this.rbYearmonth = new System.Windows.Forms.RadioButton();
            this.rbGoodType = new System.Windows.Forms.RadioButton();
            this.imageListLV = new System.Windows.Forms.ImageList(this.components);
            this.panelRight = new System.Windows.Forms.Panel();
            this.lvPurchas = new Invoicing.Common.ListViewSoftEditable(this.components);
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelLeft.SuspendLayout();
            this.tabControlGoods.SuspendLayout();
            this.panelStat.SuspendLayout();
            this.PurchasContextMenu.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.panelColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            this.panelChartType.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft.Controls.Add(this.tabControlGoods);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 306);
            this.panelLeft.TabIndex = 3;
            // 
            // tabControlGoods
            // 
            this.tabControlGoods.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlGoods.Controls.Add(this.tabPage1);
            this.tabControlGoods.Controls.Add(this.tabPage2);
            this.tabControlGoods.Controls.Add(this.tabPage3);
            this.tabControlGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlGoods.ImageList = this.imageListTab;
            this.tabControlGoods.ItemSize = new System.Drawing.Size(32, 32);
            this.tabControlGoods.Location = new System.Drawing.Point(0, 0);
            this.tabControlGoods.Multiline = true;
            this.tabControlGoods.Name = "tabControlGoods";
            this.tabControlGoods.Padding = new System.Drawing.Point(1, 3);
            this.tabControlGoods.SelectedIndex = 0;
            this.tabControlGoods.ShowToolTips = true;
            this.tabControlGoods.Size = new System.Drawing.Size(200, 306);
            this.tabControlGoods.TabIndex = 0;
            this.tabControlGoods.SelectedIndexChanged += new System.EventHandler(this.tabControlGoods_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(36, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(160, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.ToolTipText = "日期";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(36, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(160, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.ToolTipText = "商品类别";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(36, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(160, 298);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.ToolTipText = "供应商";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageListTab
            // 
            this.imageListTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTab.ImageStream")));
            this.imageListTab.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTab.Images.SetKeyName(0, "clock.ico");
            this.imageListTab.Images.SetKeyName(1, "fsview.ico");
            this.imageListTab.Images.SetKeyName(2, "cookie.ico");
            // 
            // panelStat
            // 
            this.panelStat.Controls.Add(this.label1FixpriceTotal);
            this.panelStat.Controls.Add(this.label1FixpriceTotal_);
            this.panelStat.Controls.Add(this.labelTotalCount);
            this.panelStat.Controls.Add(this.labelTotalCount_);
            this.panelStat.Controls.Add(this.labelTotal);
            this.panelStat.Controls.Add(this.labelTotal_);
            this.panelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStat.Location = new System.Drawing.Point(0, 70);
            this.panelStat.Name = "panelStat";
            this.panelStat.Size = new System.Drawing.Size(956, 24);
            this.panelStat.TabIndex = 6;
            // 
            // label1FixpriceTotal
            // 
            this.label1FixpriceTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1FixpriceTotal.Location = new System.Drawing.Point(519, 0);
            this.label1FixpriceTotal.Name = "label1FixpriceTotal";
            this.label1FixpriceTotal.Size = new System.Drawing.Size(102, 24);
            this.label1FixpriceTotal.TabIndex = 5;
            this.label1FixpriceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1FixpriceTotal_
            // 
            this.label1FixpriceTotal_.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1FixpriceTotal_.Location = new System.Drawing.Point(428, 0);
            this.label1FixpriceTotal_.Name = "label1FixpriceTotal_";
            this.label1FixpriceTotal_.Size = new System.Drawing.Size(91, 24);
            this.label1FixpriceTotal_.TabIndex = 4;
            this.label1FixpriceTotal_.Text = "定价金额(元)：";
            this.label1FixpriceTotal_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalCount
            // 
            this.labelTotalCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotalCount.Location = new System.Drawing.Point(326, 0);
            this.labelTotalCount.Name = "labelTotalCount";
            this.labelTotalCount.Size = new System.Drawing.Size(102, 24);
            this.labelTotalCount.TabIndex = 3;
            this.labelTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalCount_
            // 
            this.labelTotalCount_.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotalCount_.Location = new System.Drawing.Point(231, 0);
            this.labelTotalCount_.Name = "labelTotalCount_";
            this.labelTotalCount_.Size = new System.Drawing.Size(95, 24);
            this.labelTotalCount_.TabIndex = 2;
            this.labelTotalCount_.Text = "合计数量(个)：";
            this.labelTotalCount_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotal
            // 
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotal.Location = new System.Drawing.Point(131, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(100, 24);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotal_
            // 
            this.labelTotal_.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotal_.Location = new System.Drawing.Point(0, 0);
            this.labelTotal_.Name = "labelTotal_";
            this.labelTotal_.Size = new System.Drawing.Size(131, 24);
            this.labelTotal_.TabIndex = 0;
            this.labelTotal_.Text = "合计  进价金额(元)：";
            this.labelTotal_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PurchasContextMenu
            // 
            this.PurchasContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAdd,
            this.MenuModify,
            this.MenuDelete,
            this.toolStripMenuItem2,
            this.MenuCopy,
            this.toolStripMenuItem1,
            this.MenuInvoicing});
            this.PurchasContextMenu.Name = "PurchasContextMenu";
            this.PurchasContextMenu.Size = new System.Drawing.Size(149, 126);
            // 
            // MenuAdd
            // 
            this.MenuAdd.Image = ((System.Drawing.Image)(resources.GetObject("MenuAdd.Image")));
            this.MenuAdd.Name = "MenuAdd";
            this.MenuAdd.Size = new System.Drawing.Size(148, 22);
            this.MenuAdd.Text = "添加(&A)";
            this.MenuAdd.Click += new System.EventHandler(this.MenuAdd_Click);
            // 
            // MenuModify
            // 
            this.MenuModify.Image = ((System.Drawing.Image)(resources.GetObject("MenuModify.Image")));
            this.MenuModify.Name = "MenuModify";
            this.MenuModify.Size = new System.Drawing.Size(148, 22);
            this.MenuModify.Text = "修改(&M)";
            this.MenuModify.Click += new System.EventHandler(this.MenuModify_Click);
            // 
            // MenuDelete
            // 
            this.MenuDelete.Image = ((System.Drawing.Image)(resources.GetObject("MenuDelete.Image")));
            this.MenuDelete.Name = "MenuDelete";
            this.MenuDelete.Size = new System.Drawing.Size(148, 22);
            this.MenuDelete.Text = "删除(&D)";
            this.MenuDelete.Click += new System.EventHandler(this.MenuDelete_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 6);
            // 
            // MenuCopy
            // 
            this.MenuCopy.Name = "MenuCopy";
            this.MenuCopy.Size = new System.Drawing.Size(148, 22);
            this.MenuCopy.Text = "复制(&C)";
            this.MenuCopy.Click += new System.EventHandler(this.MenuCopy_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // MenuInvoicing
            // 
            this.MenuInvoicing.Name = "MenuInvoicing";
            this.MenuInvoicing.Size = new System.Drawing.Size(148, 22);
            this.MenuInvoicing.Text = "进销存信息(&I)";
            this.MenuInvoicing.Click += new System.EventHandler(this.MenuInvoicing_Click);
            // 
            // panelChart
            // 
            this.panelChart.Controls.Add(this.panelColumn);
            this.panelChart.Controls.Add(this.chartPie);
            this.panelChart.Controls.Add(this.panelChartType);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChart.Location = new System.Drawing.Point(0, 94);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(956, 212);
            this.panelChart.TabIndex = 7;
            // 
            // panelColumn
            // 
            this.panelColumn.AutoScroll = true;
            this.panelColumn.Controls.Add(this.chartColumn);
            this.panelColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColumn.Location = new System.Drawing.Point(519, 0);
            this.panelColumn.Name = "panelColumn";
            this.panelColumn.Size = new System.Drawing.Size(437, 212);
            this.panelColumn.TabIndex = 3;
            // 
            // chartColumn
            // 
            this.chartColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chartColumn.ChartAreas.Add(chartArea1);
            this.chartColumn.Location = new System.Drawing.Point(60, 15);
            this.chartColumn.Name = "chartColumn";
            this.chartColumn.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartColumn.Series.Add(series1);
            this.chartColumn.Size = new System.Drawing.Size(316, 142);
            this.chartColumn.TabIndex = 1;
            // 
            // chartPie
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea2);
            this.chartPie.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chartPie.Legends.Add(legend1);
            this.chartPie.Location = new System.Drawing.Point(131, 0);
            this.chartPie.Name = "chartPie";
            this.chartPie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPie.Series.Add(series2);
            this.chartPie.Size = new System.Drawing.Size(388, 212);
            this.chartPie.TabIndex = 2;
            this.chartPie.Text = "chart1";
            // 
            // panelChartType
            // 
            this.panelChartType.BackColor = System.Drawing.Color.White;
            this.panelChartType.Controls.Add(this.cb3D);
            this.panelChartType.Controls.Add(this.rbProvider);
            this.panelChartType.Controls.Add(this.rbYearmonth);
            this.panelChartType.Controls.Add(this.rbGoodType);
            this.panelChartType.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChartType.Location = new System.Drawing.Point(0, 0);
            this.panelChartType.Name = "panelChartType";
            this.panelChartType.Size = new System.Drawing.Size(131, 212);
            this.panelChartType.TabIndex = 0;
            // 
            // cb3D
            // 
            this.cb3D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb3D.AutoSize = true;
            this.cb3D.Checked = true;
            this.cb3D.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb3D.Location = new System.Drawing.Point(6, 192);
            this.cb3D.Name = "cb3D";
            this.cb3D.Size = new System.Drawing.Size(72, 16);
            this.cb3D.TabIndex = 3;
            this.cb3D.Text = "三维立体";
            this.cb3D.UseVisualStyleBackColor = true;
            this.cb3D.CheckedChanged += new System.EventHandler(this.cb3D_CheckedChanged);
            // 
            // rbProvider
            // 
            this.rbProvider.AutoSize = true;
            this.rbProvider.Location = new System.Drawing.Point(11, 69);
            this.rbProvider.Name = "rbProvider";
            this.rbProvider.Size = new System.Drawing.Size(59, 16);
            this.rbProvider.TabIndex = 2;
            this.rbProvider.Text = "供应商";
            this.rbProvider.UseVisualStyleBackColor = true;
            this.rbProvider.CheckedChanged += new System.EventHandler(this.rbProvider_CheckedChanged);
            // 
            // rbYearmonth
            // 
            this.rbYearmonth.AutoSize = true;
            this.rbYearmonth.Checked = true;
            this.rbYearmonth.Location = new System.Drawing.Point(11, 15);
            this.rbYearmonth.Name = "rbYearmonth";
            this.rbYearmonth.Size = new System.Drawing.Size(71, 16);
            this.rbYearmonth.TabIndex = 1;
            this.rbYearmonth.TabStop = true;
            this.rbYearmonth.Text = "进货年月";
            this.rbYearmonth.UseVisualStyleBackColor = true;
            this.rbYearmonth.CheckedChanged += new System.EventHandler(this.rbYearmonth_CheckedChanged);
            // 
            // rbGoodType
            // 
            this.rbGoodType.AutoSize = true;
            this.rbGoodType.Location = new System.Drawing.Point(11, 42);
            this.rbGoodType.Name = "rbGoodType";
            this.rbGoodType.Size = new System.Drawing.Size(71, 16);
            this.rbGoodType.TabIndex = 0;
            this.rbGoodType.Text = "商品类别";
            this.rbGoodType.UseVisualStyleBackColor = true;
            this.rbGoodType.CheckedChanged += new System.EventHandler(this.rbGoodType_CheckedChanged);
            // 
            // imageListLV
            // 
            this.imageListLV.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListLV.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListLV.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.lvPurchas);
            this.panelRight.Controls.Add(this.panelStat);
            this.panelRight.Controls.Add(this.panelChart);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(200, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(956, 306);
            this.panelRight.TabIndex = 9;
            // 
            // lvPurchas
            // 
            this.lvPurchas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader12,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader8,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader11});
            this.lvPurchas.ContextMenuStrip = this.PurchasContextMenu;
            this.lvPurchas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPurchas.FullRowSelect = true;
            this.lvPurchas.GridLines = true;
            this.lvPurchas.HideSelection = false;
            this.lvPurchas.ListDecimalColumnIndex = ((System.Collections.Generic.List<int>)(resources.GetObject("lvPurchas.ListDecimalColumnIndex")));
            this.lvPurchas.Location = new System.Drawing.Point(0, 0);
            this.lvPurchas.MultiSelect = false;
            this.lvPurchas.Name = "lvPurchas";
            this.lvPurchas.Size = new System.Drawing.Size(956, 70);
            this.lvPurchas.SmallImageList = this.imageListLV;
            this.lvPurchas.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvPurchas.TabIndex = 4;
            this.lvPurchas.UseCompatibleStateImageBehavior = false;
            this.lvPurchas.View = System.Windows.Forms.View.Details;
            this.lvPurchas.DoubleClick += new System.EventHandler(this.lvPurchas_DoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "序号";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "进货时间";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名称";
            this.columnHeader2.Width = 270;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "商品编码";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "商品单位";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "商品类别";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "供应商";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "进货数量";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "进货单价";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "金额";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "定价";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 70;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "备注";
            this.columnHeader11.Width = 200;
            // 
            // ucPurchas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "ucPurchas";
            this.Size = new System.Drawing.Size(1156, 306);
            this.panelLeft.ResumeLayout(false);
            this.tabControlGoods.ResumeLayout(false);
            this.panelStat.ResumeLayout(false);
            this.PurchasContextMenu.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.panelColumn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            this.panelChartType.ResumeLayout(false);
            this.panelChartType.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private Invoicing.Common.ListViewSoftEditable lvPurchas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panelStat;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotal_;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ImageList imageListTab;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TabControl tabControlGoods;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelTotalCount;
        private System.Windows.Forms.Label labelTotalCount_;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label1FixpriceTotal;
        private System.Windows.Forms.Label label1FixpriceTotal_;
        private System.Windows.Forms.ContextMenuStrip PurchasContextMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuModify;
        private System.Windows.Forms.ToolStripMenuItem MenuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuInvoicing;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelChartType;
        private System.Windows.Forms.RadioButton rbProvider;
        private System.Windows.Forms.RadioButton rbYearmonth;
        private System.Windows.Forms.RadioButton rbGoodType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.ImageList imageListLV;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.CheckBox cb3D;
        private System.Windows.Forms.Panel panelColumn;

    }
}
