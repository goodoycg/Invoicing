using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Invoicing.Common;


namespace Invoicing.Stock
{
    public partial class ucStockGoodstree : UserControl
    {
        public event EventHandler<SelectGoodsEventArgs> AfterSelectGoods;
        public ucStockGoodstree()
        {
            InitializeComponent();
        }

        public void LoadStockGoods()
        {
            this.tvStockGoods.Nodes.Clear();

            TreeNode all = new TreeNode(Foundation.AllGoodsName) { Tag = 0, ImageIndex = 0, SelectedImageIndex = 1 };
            DataSet ds = Foundation.GetAllStockGoodsName();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                TreeNode sn = new TreeNode(dr["goodsname"].ToString()) { Tag = string.Empty, ImageIndex = 2, SelectedImageIndex = 3 };
                all.Nodes.Add(sn);
            }
            
            this.tvStockGoods.Nodes.Add(all);            
            this.tvStockGoods.SelectedNode = tvStockGoods.Nodes[0];
            this.tvStockGoods.ExpandAll();
        }

        private void tvStockGoods_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.tvStockGoods.SelectedNode != null && this.AfterSelectGoods != null)
            {
                AfterSelectGoods(this.tvStockGoods, new SelectGoodsEventArgs { 
                    GoodsName = this.tvStockGoods.SelectedNode.Text });
            }
        }        
    }
}
