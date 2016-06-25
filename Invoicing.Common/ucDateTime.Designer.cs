namespace Invoicing
{
    partial class ucDateTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDateTime));
            this.tvDatetime = new System.Windows.Forms.TreeView();
            this.imgNodes = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDatetime
            // 
            this.tvDatetime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDatetime.HideSelection = false;
            this.tvDatetime.ImageIndex = 0;
            this.tvDatetime.ImageList = this.imgNodes;
            this.tvDatetime.Location = new System.Drawing.Point(0, 23);
            this.tvDatetime.Name = "tvDatetime";
            this.tvDatetime.SelectedImageIndex = 0;
            this.tvDatetime.Size = new System.Drawing.Size(194, 524);
            this.tvDatetime.TabIndex = 0;
            this.tvDatetime.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDatetime_AfterSelect);
            // 
            // imgNodes
            // 
            this.imgNodes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgNodes.ImageStream")));
            this.imgNodes.TransparentColor = System.Drawing.Color.Transparent;
            this.imgNodes.Images.SetKeyName(0, "Year2.gif");
            this.imgNodes.Images.SetKeyName(1, "yearsel2.bmp");
            this.imgNodes.Images.SetKeyName(2, "month.bmp");
            this.imgNodes.Images.SetKeyName(3, "monthsel.bmp");
            this.imgNodes.Images.SetKeyName(4, "day.ico");
            this.imgNodes.Images.SetKeyName(5, "daysel.bmp");
            this.imgNodes.Images.SetKeyName(6, "bs.gif");
            this.imgNodes.Images.SetKeyName(7, "bo.gif");
            this.imgNodes.Images.SetKeyName(8, "");
            this.imgNodes.Images.SetKeyName(9, "");
            this.imgNodes.Images.SetKeyName(10, "year.bmp");
            this.imgNodes.Images.SetKeyName(11, "Year1.gif");
            this.imgNodes.Images.SetKeyName(12, "yearsel.bmp");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbYear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 23);
            this.panel1.TabIndex = 1;
            // 
            // cbbYear
            // 
            this.cbbYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(70, 0);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(124, 20);
            this.cbbYear.TabIndex = 1;
            this.cbbYear.SelectedIndexChanged += new System.EventHandler(this.cbbYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始年份：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tvDatetime);
            this.Controls.Add(this.panel1);
            this.Name = "ucDateTime";
            this.Size = new System.Drawing.Size(194, 547);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgNodes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TreeView tvDatetime;
    }
}
