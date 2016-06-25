namespace Invoicing.Sell
{
    partial class ucLatelySell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLatelySell));
            this.LatelySellTree = new System.Windows.Forms.TreeView();
            this.imgNodes = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // LatelySellTree
            // 
            this.LatelySellTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LatelySellTree.FullRowSelect = true;
            this.LatelySellTree.HideSelection = false;
            this.LatelySellTree.ImageIndex = 4;
            this.LatelySellTree.ImageList = this.imgNodes;
            this.LatelySellTree.Location = new System.Drawing.Point(0, 0);
            this.LatelySellTree.Name = "LatelySellTree";
            this.LatelySellTree.SelectedImageIndex = 5;
            this.LatelySellTree.Size = new System.Drawing.Size(150, 150);
            this.LatelySellTree.TabIndex = 0;
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
            // ucLatelySell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LatelySellTree);
            this.Name = "ucLatelySell";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView LatelySellTree;
        private System.Windows.Forms.ImageList imgNodes;

    }
}
