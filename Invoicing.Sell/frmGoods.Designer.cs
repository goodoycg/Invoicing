namespace Invoicing.Sell
{
    partial class frmGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoods));
            this.lvStockGoods = new Invoicing.Common.ListViewSoftEditable(this.components);
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1Goods = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAllGoods = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1Goods.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvStockGoods
            // 
            this.lvStockGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStockGoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader4,
            this.columnHeader3});
            this.lvStockGoods.FullRowSelect = true;
            this.lvStockGoods.GridLines = true;
            this.lvStockGoods.HideSelection = false;
            this.lvStockGoods.ListDecimalColumnIndex = ((System.Collections.Generic.List<int>)(resources.GetObject("lvStockGoods.ListDecimalColumnIndex")));
            this.lvStockGoods.Location = new System.Drawing.Point(141, 0);
            this.lvStockGoods.Name = "lvStockGoods";
            this.lvStockGoods.Size = new System.Drawing.Size(779, 286);
            this.lvStockGoods.SmallImageList = this.imageList1;
            this.lvStockGoods.TabIndex = 0;
            this.lvStockGoods.UseCompatibleStateImageBehavior = false;
            this.lvStockGoods.View = System.Windows.Forms.View.Details;
            this.lvStockGoods.SelectedIndexChanged += new System.EventHandler(this.lvStockGoods_SelectedIndexChanged);
            this.lvStockGoods.DoubleClick += new System.EventHandler(this.lvStockGoods_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "序号";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "进货时间";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名称";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "库存数量";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "商品定价";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 70;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(822, 292);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(728, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl1Goods
            // 
            this.tabControl1Goods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1Goods.Controls.Add(this.tabPage1);
            this.tabControl1Goods.Controls.Add(this.tabPage2);
            this.tabControl1Goods.Location = new System.Drawing.Point(0, 0);
            this.tabControl1Goods.Name = "tabControl1Goods";
            this.tabControl1Goods.SelectedIndex = 0;
            this.tabControl1Goods.Size = new System.Drawing.Size(135, 263);
            this.tabControl1Goods.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(127, 238);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "类别";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(127, 238);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "供应商";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAllGoods
            // 
            this.btnAllGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAllGoods.Location = new System.Drawing.Point(0, 263);
            this.btnAllGoods.Name = "btnAllGoods";
            this.btnAllGoods.Size = new System.Drawing.Size(135, 23);
            this.btnAllGoods.TabIndex = 4;
            this.btnAllGoods.Text = "所有库存商品";
            this.btnAllGoods.UseVisualStyleBackColor = true;
            this.btnAllGoods.Click += new System.EventHandler(this.btnAllGoods_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(633, 292);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查找(&F)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "商品编码";
            this.columnHeader6.Width = 120;
            // 
            // frmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 320);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAllGoods);
            this.Controls.Add(this.tabControl1Goods);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lvStockGoods);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGoods";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "库存商品";
            this.Load += new System.EventHandler(this.frmGoods_Load);
            this.tabControl1Goods.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Invoicing.Common.ListViewSoftEditable lvStockGoods;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1Goods;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnAllGoods;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}