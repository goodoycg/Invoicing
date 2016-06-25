namespace Invoicing.Common
{
    partial class ucProvodeType
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
            this.txtType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvType = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(46, 368);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(451, 21);
            this.txtType.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "类别";
            // 
            // lvType
            // 
            this.lvType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvType.FullRowSelect = true;
            this.lvType.GridLines = true;
            this.lvType.HideSelection = false;
            this.lvType.Location = new System.Drawing.Point(0, 0);
            this.lvType.Name = "lvType";
            this.lvType.Size = new System.Drawing.Size(500, 356);
            this.lvType.SmallImageList = this.imageList1;
            this.lvType.TabIndex = 6;
            this.lvType.UseCompatibleStateImageBehavior = false;
            this.lvType.View = System.Windows.Forms.View.Details;
            this.lvType.SelectedIndexChanged += new System.EventHandler(this.lvType_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "类别";
            this.columnHeader2.Width = 400;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ucProvodeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvType);
            this.Name = "ucProvodeType";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvType;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList1;
    }
}
