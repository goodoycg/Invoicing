using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Invoicing.Common;

namespace Invoicing.Sell
{
    public partial class frmGoods : Form
    {
        public int GoodsNO { set; get; }
        public string GoodsName { set; get; }
        public string GoodsCode { set; get; }
        public int StockCount { set; get; }
        public decimal StockInPrice { set; get; }
        public decimal FixPrice { set; get; }
        private ucProviderTree m_ProviderTree;
        private ucGoodsTypeTree m_GoodsTypeTree;

        public frmGoods()
        {
            InitializeComponent();

            m_GoodsTypeTree = new ucGoodsTypeTree();
            m_GoodsTypeTree.LoadGoodsType();
            m_GoodsTypeTree.Dock = DockStyle.Fill;
            m_GoodsTypeTree.GoodsTypeTree.AfterSelect += new TreeViewEventHandler(GoodsTypeTree_AfterSelect);

            m_ProviderTree = new ucProviderTree();
            m_ProviderTree.LoadProvider();
            m_ProviderTree.Dock = DockStyle.Fill;
            m_ProviderTree.ProviderTree.AfterSelect += new TreeViewEventHandler(ProviderTree_AfterSelect);

            this.lvStockGoods.ListDecimalColumnIndex.AddRange(new int[] { 0, 5, 6 });

            this.tabControl1Goods.TabPages[0].Controls.Add(m_GoodsTypeTree);
            this.tabControl1Goods.TabPages[1].Controls.Add(m_ProviderTree);
        }

        void GoodsTypeTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadData(Foundation.GetStockGoodsTypeData(e.Node.Tag.ToString(), false));
        }

        void ProviderTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadData(Foundation.GetStockGoodsProviderData(e.Node.Tag.ToString(), false));
        }

        private void frmGoods_Load(object sender, EventArgs e)
        {
            LoadData(Foundation.GetStockGoods(Foundation.AllGoodsName, false));
        }
        private void LoadData(DataSet ds)
        {
            this.lvStockGoods.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.lvStockGoods.Items.Add(new ListViewItem(new string[] {
                    (this.lvStockGoods.Items.Count + 1).ToString().PadLeft(3 ,' '),
                    dr["intime"].ToString().Substring(0,10),
                    dr["goodsname"].ToString(),
                    dr["goodscode"].ToString(),
                    dr["stockcount"].ToString(),
                dr["fixprice"].ToString()}) { Name = dr["inprice"].ToString(), Tag = dr["goodsno"].ToString() });
            }
            this.btnOK.Enabled = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void lvStockGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvStockGoods.SelectedItems == null || this.lvStockGoods.SelectedItems.Count < 1)
                return;
            this.btnOK.Enabled = true;
            this.GoodsNO = Convert.ToInt32(this.lvStockGoods.SelectedItems[0].Tag.ToString());
            this.GoodsName = this.lvStockGoods.SelectedItems[0].SubItems[2].Text;
            this.GoodsCode = this.lvStockGoods.SelectedItems[0].SubItems[3].Text; 
            this.StockCount = Convert.ToInt32(this.lvStockGoods.SelectedItems[0].SubItems[4].Text);
            this.FixPrice = Convert.ToInt32(this.lvStockGoods.SelectedItems[0].SubItems[5].Text);
            this.StockInPrice = Convert.ToDecimal(this.lvStockGoods.SelectedItems[0].Name.ToString());
        }

        private void lvStockGoods_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvStockGoods.SelectedItems == null || this.lvStockGoods.SelectedItems.Count < 1)
                return;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnAllGoods_Click(object sender, EventArgs e)
        {
            LoadData(Foundation.GetStockGoods(Foundation.AllGoodsName, false));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //this.lvStockGoods.Items.Add(new ListViewItem(new string[] {
            //        (this.lvStockGoods.Items.Count + 1).ToString().PadLeft(3 ,' '),
            //        dr["intime"].ToString().Substring(0,10),
            //        dr["goodsname"].ToString(),
            //        dr["stockcount"].ToString(),
            //    dr["fixprice"].ToString()}) { Name = dr["inprice"].ToString(), Tag = dr["goodsno"].ToString() });

            frmSearch s = new frmSearch(ModeType.Sell);
            if (s.ShowDialog(this) == DialogResult.OK)
            {              

                string strSql = @"select Purchas.*,Purchas.incount-Purchas.outcount as stockcount,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
                strSql += "from Purchas,Providers,goodsunit,GoodsType ";
                strSql += "where Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno and ";
                strSql += "GoodsType.typeno=purchas.typeno and Purchas.incount>Purchas.outcount";
                if (s.IsFuzzy)
                {
                    if (s.GoodsName != string.Empty)
                    {
                        strSql += " and Purchas.goodsname like '%" + s.GoodsName + "%'";//recorddatetime like '" + Datetime + "%'");
                    }
                    if (s.GoodsCode != string.Empty)
                    {
                        strSql += " and Purchas.goodscode like '%" + s.GoodsCode + "%'";
                    }
                }
                else
                {
                    if (s.GoodsName != string.Empty)
                    {
                        strSql += " and Purchas.goodsname ='" + s.GoodsName + "'";
                    }
                    if (s.GoodsCode != string.Empty)
                    {
                        strSql += " and Purchas.goodscode ='" + s.GoodsCode + "'";
                    }
                }
                strSql += " order by intime desc";
                DataSet ds = Foundation.ReadDataSet(strSql);
                LoadData(ds);

            }
        }
    }
}
