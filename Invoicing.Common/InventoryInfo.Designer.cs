namespace Invoicing.Common
{
    partial class InventoryInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryInfo));
            this.tabPurchas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvPurchas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabSell = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvSell = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabStock = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lvStock = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPurchas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabSell.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabStock.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPurchas
            // 
            this.tabPurchas.Controls.Add(this.tabPage1);
            this.tabPurchas.Location = new System.Drawing.Point(12, 12);
            this.tabPurchas.Name = "tabPurchas";
            this.tabPurchas.SelectedIndex = 0;
            this.tabPurchas.Size = new System.Drawing.Size(908, 88);
            this.tabPurchas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvPurchas);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(900, 63);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "进货";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvPurchas
            // 
            this.lvPurchas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader16,
            this.columnHeader5,
            this.ColumnHeader12});
            this.lvPurchas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPurchas.FullRowSelect = true;
            this.lvPurchas.GridLines = true;
            this.lvPurchas.HideSelection = false;
            this.lvPurchas.Location = new System.Drawing.Point(3, 3);
            this.lvPurchas.MultiSelect = false;
            this.lvPurchas.Name = "lvPurchas";
            this.lvPurchas.Size = new System.Drawing.Size(894, 57);
            this.lvPurchas.SmallImageList = this.imageList1;
            this.lvPurchas.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvPurchas.TabIndex = 5;
            this.lvPurchas.UseCompatibleStateImageBehavior = false;
            this.lvPurchas.View = System.Windows.Forms.View.Details;
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "进货数量";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "进货金额";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 80;
            // 
            // ColumnHeader12
            // 
            this.ColumnHeader12.Text = "商品定价";
            this.ColumnHeader12.Width = 70;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabSell
            // 
            this.tabSell.Controls.Add(this.tabPage3);
            this.tabSell.Location = new System.Drawing.Point(12, 107);
            this.tabSell.Name = "tabSell";
            this.tabSell.SelectedIndex = 0;
            this.tabSell.Size = new System.Drawing.Size(908, 238);
            this.tabSell.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvSell);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(900, 213);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "销售";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvSell
            // 
            this.lvSell.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader19,
            this.columnHeader18,
            this.columnHeader10,
            this.columnHeader11});
            this.lvSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSell.FullRowSelect = true;
            this.lvSell.GridLines = true;
            this.lvSell.HideSelection = false;
            this.lvSell.Location = new System.Drawing.Point(3, 3);
            this.lvSell.MultiSelect = false;
            this.lvSell.Name = "lvSell";
            this.lvSell.Size = new System.Drawing.Size(894, 207);
            this.lvSell.SmallImageList = this.imageList1;
            this.lvSell.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvSell.TabIndex = 9;
            this.lvSell.UseCompatibleStateImageBehavior = false;
            this.lvSell.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "序号";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "销售时间";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "商品名称";
            this.columnHeader8.Width = 300;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "销售数量";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "商品定价";
            this.columnHeader18.Width = 70;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "销售单价";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "销售金额";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 80;
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.tabPage5);
            this.tabStock.Location = new System.Drawing.Point(12, 350);
            this.tabStock.Name = "tabStock";
            this.tabStock.SelectedIndex = 0;
            this.tabStock.Size = new System.Drawing.Size(908, 82);
            this.tabStock.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lvStock);
            this.tabPage5.Location = new System.Drawing.Point(4, 21);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(900, 57);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "库存";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lvStock
            // 
            this.lvStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader20,
            this.columnHeader17,
            this.columnHeader4});
            this.lvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvStock.FullRowSelect = true;
            this.lvStock.GridLines = true;
            this.lvStock.HideSelection = false;
            this.lvStock.Location = new System.Drawing.Point(3, 3);
            this.lvStock.MultiSelect = false;
            this.lvStock.Name = "lvStock";
            this.lvStock.Size = new System.Drawing.Size(894, 51);
            this.lvStock.SmallImageList = this.imageList1;
            this.lvStock.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvStock.TabIndex = 9;
            this.lvStock.UseCompatibleStateImageBehavior = false;
            this.lvStock.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "进货时间";
            this.columnHeader13.Width = 150;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "商品名称";
            this.columnHeader14.Width = 300;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "库存数量";
            this.columnHeader15.Width = 80;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "商品定价";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader17.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "库存金额";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 80;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(808, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "进货单价";
            this.columnHeader16.Width = 80;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "进货单价";
            this.columnHeader19.Width = 80;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "进货单价";
            this.columnHeader20.Width = 80;
            // 
            // InventoryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 462);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabStock);
            this.Controls.Add(this.tabSell);
            this.Controls.Add(this.tabPurchas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "进销存信息";
            this.Load += new System.EventHandler(this.OtherInfo_Load);
            this.tabPurchas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabSell.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPurchas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabSell;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabStock;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListView lvPurchas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvSell;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ListView lvStock;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader ColumnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
    }
}