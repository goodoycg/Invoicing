namespace Invoicing.Stock
{
    partial class ucStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStock));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.imageListLV = new System.Windows.Forms.ImageList(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tabControlStock = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageListTab = new System.Windows.Forms.ImageList(this.components);
            this.labelTotal_ = new System.Windows.Forms.Label();
            this.panelStat = new System.Windows.Forms.Panel();
            this.labelFixpriceTotal = new System.Windows.Forms.Label();
            this.labelFixpriceTotal_ = new System.Windows.Forms.Label();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.labelTotalCount_ = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PurchasContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInvoicing = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lvStock = new Invoicing.Common.ListViewSoftEditable(this.components);
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelChart = new System.Windows.Forms.Panel();
            this.chartColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelChartType = new System.Windows.Forms.Panel();
            this.cb3D = new System.Windows.Forms.CheckBox();
            this.rbProvider = new System.Windows.Forms.RadioButton();
            this.rbGoodType = new System.Windows.Forms.RadioButton();
            this.panelColumn = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.tabControlStock.SuspendLayout();
            this.panelStat.SuspendLayout();
            this.PurchasContextMenu.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            this.panelChartType.SuspendLayout();
            this.panelColumn.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListLV
            // 
            this.imageListLV.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListLV.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListLV.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.tabControlStock);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(192, 370);
            this.panelLeft.TabIndex = 7;
            // 
            // tabControlStock
            // 
            this.tabControlStock.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlStock.Controls.Add(this.tabPage1);
            this.tabControlStock.Controls.Add(this.tabPage2);
            this.tabControlStock.Controls.Add(this.tabPage3);
            this.tabControlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStock.ImageList = this.imageListTab;
            this.tabControlStock.Location = new System.Drawing.Point(0, 0);
            this.tabControlStock.Multiline = true;
            this.tabControlStock.Name = "tabControlStock";
            this.tabControlStock.Padding = new System.Drawing.Point(3, 3);
            this.tabControlStock.SelectedIndex = 0;
            this.tabControlStock.ShowToolTips = true;
            this.tabControlStock.Size = new System.Drawing.Size(192, 370);
            this.tabControlStock.TabIndex = 1;
            this.tabControlStock.SelectedIndexChanged += new System.EventHandler(this.tabControlStock_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(39, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(149, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.ToolTipText = "商品";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(39, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(149, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.ToolTipText = "商品类别";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(39, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(149, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.ToolTipText = "供应商";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageListTab
            // 
            this.imageListTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTab.ImageStream")));
            this.imageListTab.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTab.Images.SetKeyName(0, "ark.ico");
            this.imageListTab.Images.SetKeyName(1, "fsview.ico");
            this.imageListTab.Images.SetKeyName(2, "cookie.ico");
            // 
            // labelTotal_
            // 
            this.labelTotal_.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotal_.Location = new System.Drawing.Point(0, 0);
            this.labelTotal_.Name = "labelTotal_";
            this.labelTotal_.Size = new System.Drawing.Size(76, 24);
            this.labelTotal_.TabIndex = 0;
            this.labelTotal_.Text = "合计(元)：";
            this.labelTotal_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelStat
            // 
            this.panelStat.Controls.Add(this.labelFixpriceTotal);
            this.panelStat.Controls.Add(this.labelFixpriceTotal_);
            this.panelStat.Controls.Add(this.labelTotalCount);
            this.panelStat.Controls.Add(this.labelTotalCount_);
            this.panelStat.Controls.Add(this.labelTotal);
            this.panelStat.Controls.Add(this.labelTotal_);
            this.panelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStat.Location = new System.Drawing.Point(0, 134);
            this.panelStat.Name = "panelStat";
            this.panelStat.Size = new System.Drawing.Size(799, 24);
            this.panelStat.TabIndex = 10;
            // 
            // labelFixpriceTotal
            // 
            this.labelFixpriceTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFixpriceTotal.Location = new System.Drawing.Point(458, 0);
            this.labelFixpriceTotal.Name = "labelFixpriceTotal";
            this.labelFixpriceTotal.Size = new System.Drawing.Size(102, 24);
            this.labelFixpriceTotal.TabIndex = 24;
            this.labelFixpriceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFixpriceTotal_
            // 
            this.labelFixpriceTotal_.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFixpriceTotal_.Location = new System.Drawing.Point(367, 0);
            this.labelFixpriceTotal_.Name = "labelFixpriceTotal_";
            this.labelFixpriceTotal_.Size = new System.Drawing.Size(91, 24);
            this.labelFixpriceTotal_.TabIndex = 23;
            this.labelFixpriceTotal_.Text = "定价金额(元)：";
            this.labelFixpriceTotal_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalCount
            // 
            this.labelTotalCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotalCount.Location = new System.Drawing.Point(267, 0);
            this.labelTotalCount.Name = "labelTotalCount";
            this.labelTotalCount.Size = new System.Drawing.Size(100, 24);
            this.labelTotalCount.TabIndex = 22;
            this.labelTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalCount_
            // 
            this.labelTotalCount_.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotalCount_.Location = new System.Drawing.Point(176, 0);
            this.labelTotalCount_.Name = "labelTotalCount_";
            this.labelTotalCount_.Size = new System.Drawing.Size(91, 24);
            this.labelTotalCount_.TabIndex = 21;
            this.labelTotalCount_.Text = "合计数量(个)：";
            this.labelTotalCount_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotal
            // 
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotal.Location = new System.Drawing.Point(76, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(100, 24);
            this.labelTotal.TabIndex = 20;
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(192, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 370);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // PurchasContextMenu
            // 
            this.PurchasContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCopy,
            this.MenuInvoicing});
            this.PurchasContextMenu.Name = "PurchasContextMenu";
            this.PurchasContextMenu.Size = new System.Drawing.Size(149, 48);
            // 
            // MenuCopy
            // 
            this.MenuCopy.Name = "MenuCopy";
            this.MenuCopy.Size = new System.Drawing.Size(148, 22);
            this.MenuCopy.Text = "复制(&C)";
            this.MenuCopy.Click += new System.EventHandler(this.MenuCopy_Click);
            // 
            // MenuInvoicing
            // 
            this.MenuInvoicing.Name = "MenuInvoicing";
            this.MenuInvoicing.Size = new System.Drawing.Size(148, 22);
            this.MenuInvoicing.Text = "进销存信息(&I)";
            this.MenuInvoicing.Click += new System.EventHandler(this.MenuInvoicing_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.lvStock);
            this.panelRight.Controls.Add(this.panelStat);
            this.panelRight.Controls.Add(this.panelChart);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(195, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(799, 370);
            this.panelRight.TabIndex = 12;
            // 
            // lvStock
            // 
            this.lvStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader12,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader11,
            this.columnHeader6});
            this.lvStock.ContextMenuStrip = this.PurchasContextMenu;
            this.lvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvStock.FullRowSelect = true;
            this.lvStock.GridLines = true;
            this.lvStock.HideSelection = false;
            this.lvStock.ListDecimalColumnIndex = ((System.Collections.Generic.List<int>)(resources.GetObject("lvStock.ListDecimalColumnIndex")));
            this.lvStock.Location = new System.Drawing.Point(0, 0);
            this.lvStock.MultiSelect = false;
            this.lvStock.Name = "lvStock";
            this.lvStock.Size = new System.Drawing.Size(799, 134);
            this.lvStock.SmallImageList = this.imageListLV;
            this.lvStock.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvStock.TabIndex = 8;
            this.lvStock.UseCompatibleStateImageBehavior = false;
            this.lvStock.View = System.Windows.Forms.View.Details;
            this.lvStock.DoubleClick += new System.EventHandler(this.lvStock_DoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "序号";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "进货时间";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名称";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "商品编码";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "单位";
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
            this.columnHeader3.Text = "库存数量";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "进货单价";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "金额";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "商品定价";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "备注";
            this.columnHeader6.Width = 500;
            // 
            // panelChart
            // 
            this.panelChart.Controls.Add(this.panelColumn);
            this.panelChart.Controls.Add(this.chartPie);
            this.panelChart.Controls.Add(this.panelChartType);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChart.Location = new System.Drawing.Point(0, 158);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(799, 212);
            this.panelChart.TabIndex = 9;
            // 
            // chartColumn
            // 
            this.chartColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chartColumn.ChartAreas.Add(chartArea1);
            this.chartColumn.Location = new System.Drawing.Point(0, 0);
            this.chartColumn.Name = "chartColumn";
            this.chartColumn.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartColumn.Series.Add(series1);
            this.chartColumn.Size = new System.Drawing.Size(277, 212);
            this.chartColumn.TabIndex = 3;
            this.chartColumn.Text = "chart2";
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
            this.panelChartType.Controls.Add(this.rbGoodType);
            this.panelChartType.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChartType.Location = new System.Drawing.Point(0, 0);
            this.panelChartType.Name = "panelChartType";
            this.panelChartType.Size = new System.Drawing.Size(131, 212);
            this.panelChartType.TabIndex = 1;
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
            this.rbProvider.Location = new System.Drawing.Point(7, 44);
            this.rbProvider.Name = "rbProvider";
            this.rbProvider.Size = new System.Drawing.Size(59, 16);
            this.rbProvider.TabIndex = 2;
            this.rbProvider.Text = "供应商";
            this.rbProvider.UseVisualStyleBackColor = true;
            this.rbProvider.CheckedChanged += new System.EventHandler(this.rbProvider_CheckedChanged);
            // 
            // rbGoodType
            // 
            this.rbGoodType.AutoSize = true;
            this.rbGoodType.Checked = true;
            this.rbGoodType.Location = new System.Drawing.Point(7, 17);
            this.rbGoodType.Name = "rbGoodType";
            this.rbGoodType.Size = new System.Drawing.Size(71, 16);
            this.rbGoodType.TabIndex = 0;
            this.rbGoodType.TabStop = true;
            this.rbGoodType.Text = "商品类别";
            this.rbGoodType.UseVisualStyleBackColor = true;
            this.rbGoodType.CheckedChanged += new System.EventHandler(this.rbGoodType_CheckedChanged);
            // 
            // panelColumn
            // 
            this.panelColumn.AutoScroll = true;
            this.panelColumn.Controls.Add(this.chartColumn);
            this.panelColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColumn.Location = new System.Drawing.Point(519, 0);
            this.panelColumn.Name = "panelColumn";
            this.panelColumn.Size = new System.Drawing.Size(280, 212);
            this.panelColumn.TabIndex = 4;
            // 
            // ucStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft);
            this.Name = "ucStock";
            this.Size = new System.Drawing.Size(994, 370);
            this.panelLeft.ResumeLayout(false);
            this.tabControlStock.ResumeLayout(false);
            this.panelStat.ResumeLayout(false);
            this.PurchasContextMenu.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            this.panelChartType.ResumeLayout(false);
            this.panelChartType.PerformLayout();
            this.panelColumn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private Invoicing.Common.ListViewSoftEditable lvStock;
        private System.Windows.Forms.ImageList imageListLV;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelTotal_;
        private System.Windows.Forms.Panel panelStat;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabControl tabControlStock;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label labelTotalCount;
        private System.Windows.Forms.Label labelTotalCount_;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label labelFixpriceTotal;
        private System.Windows.Forms.Label labelFixpriceTotal_;
        private System.Windows.Forms.ContextMenuStrip PurchasContextMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuInvoicing;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ImageList imageListTab;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelChartType;
        private System.Windows.Forms.CheckBox cb3D;
        private System.Windows.Forms.RadioButton rbProvider;
        private System.Windows.Forms.RadioButton rbGoodType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.Panel panelColumn;
    }
}
