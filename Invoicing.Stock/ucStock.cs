using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Invoicing.Common;


namespace Invoicing.Stock
{
    public partial class ucStock : UserControl, IOutput,ISearchGoods
    {
        private ucStockGoodstree m_Goodstree = null;
        private string m_Goodsname = string.Empty;
        private ucProviderTree m_ProviderTree;
        private ucGoodsTypeTree m_GoodsTypeTree;
        private SystemUser m_SystemUser;
        public ucStock(SystemUser _SystemUser)
        {
            InitializeComponent();
            m_SystemUser = _SystemUser;
            m_Goodstree = new ucStockGoodstree();
            m_Goodstree.Dock = DockStyle.Fill;
            m_Goodstree.AfterSelectGoods += new EventHandler<SelectGoodsEventArgs>(m_Goodstree_AfterSelectGoods);

            m_GoodsTypeTree = new ucGoodsTypeTree();
            m_GoodsTypeTree.LoadGoodsType();
            m_GoodsTypeTree.Dock = DockStyle.Fill;
            m_GoodsTypeTree.GoodsTypeTree.AfterSelect += new TreeViewEventHandler(GoodsTypeTree_AfterSelect);

            m_ProviderTree = new ucProviderTree();
            m_ProviderTree.LoadProvider();
            m_ProviderTree.Dock = DockStyle.Fill;
            m_ProviderTree.ProviderTree.AfterSelect += new TreeViewEventHandler(ProviderTree_AfterSelect);

            this.lvStock.ListDecimalColumnIndex.AddRange(new int[] { 0, 7, 8, 9, 10 });

            this.tabControlStock.TabPages[0].Controls.Add(m_Goodstree);
            this.tabControlStock.TabPages[1].Controls.Add(m_GoodsTypeTree);
            this.tabControlStock.TabPages[2].Controls.Add(m_ProviderTree);
        }

        void m_Goodstree_AfterSelectGoods(object sender, SelectGoodsEventArgs e)
        {
            m_Goodsname = e.GoodsName;
            LoadData(Foundation.GetStockGoods(m_Goodsname));
        }
        void GoodsTypeTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadData(Foundation.GetStockGoodsTypeData(e.Node.Tag.ToString()));
        }
        void ProviderTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadData(Foundation.GetStockGoodsProviderData(e.Node.Tag.ToString()));
        }
        public void RefreshChart()
        {
            this.chartColumn.BackColor = Color.White;
            this.chartPie.BackColor = Color.White;

            this.chartColumn.Series[0].Color = Color.Green;

            this.chartColumn.ChartAreas[0].AxisX.MajorGrid.Interval = 2;//X轴全部显示

            this.chartPie.ChartAreas[0].Area3DStyle.Enable3D = true;
            this.chartColumn.ChartAreas[0].Area3DStyle.Enable3D = true;

            this.rbGoodType_CheckedChanged(null, null);
        } 
        public void LoadStockGoods()
        {
            m_Goodstree.LoadStockGoods();
        }

        public void Output()
        {
            Foundation.OutputCSV(this.lvStock, "库存" + System.DateTime.Now.ToString("yyyyMMddHHssmm") + ".csv",
                new string[] { 
                    this.labelTotal_.Text,
                    this.labelTotal.Text,
                    this.labelTotalCount_.Text,
                    this.labelTotalCount.Text,
                    this.labelFixpriceTotal_.Text,
                    this.labelFixpriceTotal.Text });
        }

        private void lvStock_DoubleClick(object sender, EventArgs e)
        {
            InventoryInfo o = new InventoryInfo(ModeType.Stock,
               Convert.ToInt32(this.lvStock.SelectedItems[0].Tag.ToString()),m_SystemUser);
            o.ShowDialog(this.ParentForm);
        }

        private void tabControlStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlStock.SelectedIndex == 0)
            {
                if (m_GoodsTypeTree.GoodsTypeTree.SelectedNode != null)
                {
                    LoadData(Foundation.GetStockGoods(m_GoodsTypeTree.GoodsTypeTree.SelectedNode.Text));
                }
            }
            else if (this.tabControlStock.SelectedIndex == 1)
            {
                if (m_GoodsTypeTree.GoodsTypeTree.SelectedNode != null)
                {
                    LoadData(Foundation.GetStockGoodsTypeData(m_GoodsTypeTree.GoodsTypeTree.SelectedNode.Tag.ToString()));
                }
                else
                {
                    m_GoodsTypeTree.GoodsTypeTree.SelectedNode = m_GoodsTypeTree.GoodsTypeTree.Nodes[0];
                }
            }
            else if (this.tabControlStock.SelectedIndex == 2)
            {
                if (m_ProviderTree.ProviderTree.SelectedNode != null)
                {
                    LoadData(Foundation.GetStockGoodsProviderData(m_ProviderTree.ProviderTree.SelectedNode.Tag.ToString()));
                }
                else
                {
                    m_ProviderTree.ProviderTree.SelectedNode = m_ProviderTree.ProviderTree.Nodes[0];
                }
            }
        }
        public void Search()
        {
            frmSearch s = new frmSearch(ModeType.Stock);
            if (s.ShowDialog(this.ParentForm) == DialogResult.OK)
            {
                string strGoodName = s.GoodsName;
                string strSql = @"select Purchas.*,(incount - outcount) as stockcount,round(stockcount * inprice,2) as instat,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
                strSql += @"from Purchas,Providers,goodsunit,GoodsType ";
                strSql += "where Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno ";
                strSql += "and GoodsType.typeno=purchas.typeno and Purchas.goodsname";
                if (s.IsFuzzy)
                {
                    strSql += " like '%" + strGoodName + "%'";//recorddatetime like '" + Datetime + "%'");
                }
                else
                {
                    strSql += " ='" + strGoodName + "'";
                }
                DataSet ds = Foundation.ReadDataSet(strSql);
                LoadData(ds);
            }

        }
        /// <summary>
        /// 加载最新库存数据
        /// </summary>
        public void LoadData(DataSet ds)
        {
            this.lvStock.Items.Clear();
            decimal iTotal = 0;
            int iTotalCount = 0;
            decimal dFixpriceTotal = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.lvStock.Items.Add(new ListViewItem(new string[] { 
                    (lvStock.Items.Count + 1).ToString().PadLeft(3 ,' '),
                    dr["intime"].ToString(),
                    dr["goodsname"].ToString(),
                    dr["goodscode"].ToString(),
                    dr["unitname"].ToString(), 
                    dr["typename"].ToString(), 
                    dr["providername"].ToString(), 
                    dr["stockcount"].ToString(),
                    dr["inprice"].ToString(),
                   dr["instat"].ToString(),
                    dr["fixprice"].ToString(),
                dr["remarks"].ToString()}) { Tag = dr["GoodsNO"].ToString() });
                iTotal += Convert.ToDecimal(dr["instat"].ToString());
                iTotalCount += Convert.ToInt32(dr["stockcount"].ToString());
                dFixpriceTotal += Convert.ToDecimal(dr["fixprice"].ToString()) * Convert.ToDecimal(dr["stockcount"].ToString());
            }
            if (iTotalCount > 0)
            {
                this.labelTotal.Text = iTotal.ToString();
                this.labelTotalCount.Text = iTotalCount.ToString();
                this.labelFixpriceTotal.Text = dFixpriceTotal.ToString();
            }
        }

        private void MenuCopy_Click(object sender, EventArgs e)
        {
            if (this.lvStock.SelectedItems != null && this.lvStock.SelectedItems.Count > 0)
            {
                string strCopy = string.Empty;
                for (int i = 1; i < this.lvStock.Columns.Count; i++)
                {
                    strCopy += this.lvStock.Columns[i].Text + ":" + this.lvStock.SelectedItems[0].SubItems[i].Text + " ";
                }
                if (strCopy != string.Empty)
                {
                    Clipboard.SetDataObject(strCopy);//有则把选择的文本放到剪贴板上
                }
            }
            else
            {
                MessageBox.Show("请选择要复制的库存数据", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MenuInvoicing_Click(object sender, EventArgs e)
        {
            this.lvStock_DoubleClick(null, null);
        }

        private void cb3D_CheckedChanged(object sender, EventArgs e)
        {
            this.chartPie.ChartAreas[0].Area3DStyle.Enable3D = this.cb3D.Checked;
            this.chartColumn.ChartAreas[0].Area3DStyle.Enable3D = this.cb3D.Checked;
        }

        private void rbGoodType_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbGoodType.Checked)
            {
                string s = "SELECT typename as 商品类别,round(sum(incount*inprice),2) as 金额 from Purchas,goodstype where  purchas.outcount<purchas.incount and purchas.typeno=goodstype.typeno group by goodstype.typename";

                DataTable dtData = Invoicing.Common.Foundation.ReadDataSet(s).Tables[0];

                chartColumn.DataSource = dtData;
                chartColumn.Series[0].YValueMembers = "金额";
                chartColumn.Series[0].XValueMember = "商品类别";
                chartColumn.Series[0].ChartType = SeriesChartType.Column;
                this.chartColumn.Series[0].IsValueShownAsLabel = true;
                this.chartColumn.ChartAreas[0].AxisX.Interval = 1;
                this.chartColumn.ChartAreas[0].AxisX.IntervalOffset = 1;
                //this.chartColumn.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true;
                this.chartColumn.Width = 300 + dtData.Rows.Count * 60;

                chartPie.DataSource = dtData;
                chartPie.Series[0].YValueMembers = "金额";
                chartPie.Series[0].XValueMember = "商品类别";
                chartPie.Series[0].ChartType = SeriesChartType.Pie;
                this.chartPie.BackColor = Color.White;
            }
        }       

        private void rbProvider_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbProvider.Checked)
            {
                string s = "SELECT providername as 供应商,round(sum(incount*inprice),2) as 金额 from Purchas,providers where  purchas.outcount<purchas.incount and purchas.providerno=providers.providerno group by providers.providername";
                
                DataTable dtData = Invoicing.Common.Foundation.ReadDataSet(s).Tables[0];

                chartColumn.DataSource = dtData;
                chartColumn.Series[0].YValueMembers = "金额";
                chartColumn.Series[0].XValueMember = "供应商";
                chartColumn.Series[0].ChartType = SeriesChartType.Column;
                this.chartColumn.Series[0].IsValueShownAsLabel = true;
                this.chartColumn.ChartAreas[0].AxisX.Interval = 1;
                this.chartColumn.ChartAreas[0].AxisX.IntervalOffset = 1;
                //this.chartColumn.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true;
                this.chartColumn.Width = 300 + dtData.Rows.Count * 60;

                chartPie.DataSource = dtData;
                chartPie.Series[0].YValueMembers = "金额";
                chartPie.Series[0].XValueMember = "供应商";
                chartPie.Series[0].ChartType = SeriesChartType.Pie;
                this.chartPie.BackColor = Color.White;
            }

        }
    }
}
