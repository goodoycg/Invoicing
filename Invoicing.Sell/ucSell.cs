using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Invoicing.Common;

namespace Invoicing.Sell
{
    public partial class ucSell : UserControl, IOutput,ISearchGoods
    {
        private string m_strDatetime = string.Empty;
        private ucDateTime m_Datetime;
        private ucProviderTree m_ProviderTree;
        private ucGoodsTypeTree m_GoodsTypeTree;
        private ucLatelySell m_LatelySell;
        public int GoodsNO { get; set; }

        private SystemUser m_SystemUser;
        public ucSell(SystemUser _SystemUser)
        {
            InitializeComponent();

            m_SystemUser = _SystemUser;
            m_LatelySell = new ucLatelySell(_SystemUser);
            m_LatelySell.Dock = DockStyle.Fill;
            m_LatelySell.LatelySellTree.AfterSelect += new TreeViewEventHandler(LatelySellTree_AfterSelect);

            m_Datetime = new ucDateTime();
            m_Datetime.Dock = DockStyle.Fill;
            m_Datetime.DatetimeChanged += new EventHandler<DatetimeTreeEventArgs>(m_Datetime_DatetimeChanged);

            m_GoodsTypeTree = new ucGoodsTypeTree();
            m_GoodsTypeTree.LoadGoodsType();
            m_GoodsTypeTree.Dock = DockStyle.Fill;
            m_GoodsTypeTree.GoodsTypeTree.AfterSelect += new TreeViewEventHandler(GoodsTypeTree_AfterSelect);

            m_ProviderTree = new ucProviderTree();
            m_ProviderTree.LoadProvider();
            m_ProviderTree.Dock = DockStyle.Fill;
            m_ProviderTree.ProviderTree.AfterSelect += new TreeViewEventHandler(ProviderTree_AfterSelect);

            this.lvSell.ListDecimalColumnIndex.AddRange(new int[] { 0, 7, 8, 9, 10, 11 });

            this.tabControlSell.TabPages[0].Controls.Add(m_LatelySell);
            this.tabControlSell.TabPages[1].Controls.Add(m_Datetime);
            this.tabControlSell.TabPages[2].Controls.Add(m_GoodsTypeTree);
            this.tabControlSell.TabPages[3].Controls.Add(m_ProviderTree);

            if (!m_SystemUser.ShowProfit)
            {
                this.labelProfit.Width = this.labelProfit_.Width = 0;
                this.lvSell.Columns[11].Width = 0;
            }
            
            
        }

        #region 最近
        void LatelySellTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (m_LatelySell.LatelySellTree.SelectedNode == null)
                return;
            if (m_LatelySell.LatelySellTree.SelectedNode.Tag.ToString() == "0")
            {//所有最近销售
                LoadDataNew(Foundation.LatelyAllSell(m_SystemUser.SellDay));
            }
            else
            {//单笔销售
                LoadDataNew(Foundation.GetSellTimeData(m_LatelySell.LatelySellTree.SelectedNode.Text, m_SystemUser.SellDay));
            }            
        }
        #endregion

        #region 日期
        void m_Datetime_DatetimeChanged(object sender, DatetimeTreeEventArgs e)
        {
            if (e != null)
            {
                m_strDatetime = e.DatatimeString;
            }
            LoadDataNew(Foundation.GetSellDataOuttime(m_strDatetime, m_SystemUser.SellDay));
        }
        #endregion

        #region 类型
        void GoodsTypeTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadDataNew(Foundation.SellGetGoodsTypeData(m_GoodsTypeTree.GoodsTypeTree.SelectedNode.Tag.ToString(), m_SystemUser.SellDay));
        }
        #endregion

        #region 供应商
        void ProviderTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadDataNew(Foundation.SellGetProviderData(m_ProviderTree.ProviderTree.SelectedNode.Tag.ToString(), m_SystemUser.SellDay));
        }
        #endregion
        public void InitTree()
        {
            m_Datetime.InitTree();
        }
        public void LatelySell()
        {
            m_LatelySell.LoadLatelySell();
        }
        private void LoadDataNew(DataSet ds)
        {
            this.lvSell.Items.Clear();
            OrderNO = string.Empty;
            m_lviBackColor = Color.White;
            this.labelTotal.Text = "0";
            this.labelTotalCount.Text = "0";
            this.labelFixpriceTotal.Text = "0";
            this.labelProfit.Text = "0";
            LoadDataAdd(ds);
        }
        public void Search()
        {
            frmSearch s = new frmSearch(ModeType.Stock);
            if (s.ShowDialog(this.ParentForm) == DialogResult.OK)
            {
                string strGoodName = s.GoodsName;              
                string strSql = @"select sell.*,round(sell.outcount * sell.outprice,2) as outstat,round(sell.outcount * (sell.outprice-purchas.inprice),2) as profit,";
                strSql += "purchas.goodsname,purchas.goodscode,purchas.fixprice,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
                strSql += "from Sell,purchas,goodsunit,Providers,GoodsType where Purchas.unitno = goodsunit.UnitNO and ";
                strSql += "Providers.ProviderNO=purchas.providerno and GoodsType.typeno=purchas.typeno and Sell.goodsno=purchas.goodsno and purchas.goodsname";

                if (s.IsFuzzy)
                {
                    strSql += " like '%" + strGoodName + "%'";//recorddatetime like '" + Datetime + "%'");
                }
                else
                {
                    strSql += " ='" + strGoodName + "'";
                }
                DataSet ds = Foundation.ReadDataSet(strSql);
                LoadDataNew(ds);
            }
        }
        private Color m_lviBackColor = Color.White;
        private string OrderNO = string.Empty;
        private void LoadDataAdd(DataSet ds)
        {
            if (ds == null || ds.Tables[0].Rows.Count == 0)
                return;

            decimal iOutStat = Convert.ToDecimal(this.labelTotal.Text);
            int iOutStatCount = Convert.ToInt32(this.labelTotalCount.Text);
            decimal dFixpriceTotal = Convert.ToDecimal(this.labelFixpriceTotal.Text);
            decimal dProfit = Convert.ToDecimal(this.labelProfit.Text);
            if (string.Empty == OrderNO)
            {
                OrderNO = ds.Tables[0].Rows[0]["orderno"].ToString();
            }
            bool bUseing = false;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (OrderNO != dr["orderno"].ToString())
                {
                    OrderNO = dr["orderno"].ToString();
                    m_lviBackColor = m_lviBackColor == Color.White ? SystemColors.Control : Color.White;
                }
                bUseing = dr["useing"].ToString() == "1";
                this.lvSell.Items.Add(new ListViewItem(new string[] { 
                    (this.lvSell.Items.Count + 1).ToString().PadLeft(3 ,' '),
                    dr["outtime"].ToString(),
                    dr["goodsname"].ToString(), 
                    dr["goodscode"].ToString(), 
                    dr["unitname"].ToString(), 
                    dr["typename"].ToString(), 
                    dr["providername"].ToString(), 
                    dr["outcount"].ToString(), 
                    dr["fixprice"].ToString(),
                    dr["outprice"].ToString(), 
                    dr["outstat"].ToString(), 
                    dr["profit"].ToString(), 
                    dr["remarks"].ToString() }) { Tag = dr["sellno"].ToString(), Name = dr["goodsno"].ToString(), BackColor = (bUseing ? m_lviBackColor : Color.Red) });
                if (bUseing)
                {//统计没有作废的销售记录
                    iOutStat += Convert.ToDecimal(dr["outstat"].ToString());
                    iOutStatCount += Convert.ToInt32(dr["outcount"].ToString());
                    dFixpriceTotal += Convert.ToDecimal(dr["fixprice"].ToString()) * Convert.ToDecimal(dr["outcount"].ToString());
                    dProfit += Convert.ToDecimal(dr["profit"].ToString());
                }
            }
            this.labelTotal.Text = iOutStat.ToString();
            this.labelTotalCount.Text = iOutStatCount.ToString();
            this.labelFixpriceTotal.Text = dFixpriceTotal.ToString();
            this.labelProfit.Text = dProfit.ToString();
        }   
        
        void s_GoodsSelled(object sender, GoodsSelledEventArgs e)
        {
           
        }       

        
        public void Output()
        {
            Foundation.OutputCSV(this.lvSell,
                "销售" + System.DateTime.Now.ToString("yyyyMMddHHssmm") + ".csv",
                new string[] { 
                    this.labelTotal_.Text,
                    this.labelTotal.Text,
                    this.labelTotalCount_.Text,
                    this.labelTotalCount.Text,
                    this.labelFixpriceTotal_.Text,
                    this.labelFixpriceTotal.Text,
                    this.labelProfit_.Text,
                    this.labelProfit.Text });
        }

        
        private void tabControlSell_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlSell.SelectedIndex == 0)
            {
                LatelySellTree_AfterSelect(null, null);
            }
            else if (this.tabControlSell.SelectedIndex == 1)
            {
                m_Datetime_DatetimeChanged(null, null);
            }
            else if (this.tabControlSell.SelectedIndex == 2)
            {
                if (m_GoodsTypeTree.GoodsTypeTree.SelectedNode == null)
                {
                    m_GoodsTypeTree.GoodsTypeTree.SelectedNode = m_GoodsTypeTree.GoodsTypeTree.Nodes[0];
                }
                else
                {
                    GoodsTypeTree_AfterSelect(null, null);
                }
            }
            else if (this.tabControlSell.SelectedIndex == 3)
            {
                if (m_ProviderTree.ProviderTree.SelectedNode == null)
                {
                    m_ProviderTree.ProviderTree.SelectedNode = m_ProviderTree.ProviderTree.Nodes[0];
                }
                else
                {
                    ProviderTree_AfterSelect(null, null);
                }
            }
        }
                      

        private void lvSell_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvSell.SelectedItems == null || this.lvSell.SelectedItems.Count < 1)
                return;
            if (this.lvSell.SelectedItems[0].BackColor == Color.Red)
            {
                this.MenuCancelSell.Enabled = false;
                this.MenuResetSell.Enabled = true;
            }
            else
            {
                this.MenuCancelSell.Enabled = true;
                this.MenuResetSell.Enabled = false;
            }
        }       

        private void MenuSellGoods_Click(object sender, EventArgs e)
        {
            SellGoods s = new SellGoods();
            s.GoodsSelled += new EventHandler<GoodsSelledEventArgs>(s_GoodsSelled);
            if (s.ShowDialog(this.ParentForm) == DialogResult.OK)
            {
                this.m_LatelySell.LatelySellTree.Nodes[0].Nodes.Insert(0, new TreeNode(s.SellDataTime) { Tag = string.Empty });
                this.m_LatelySell.LatelySellTree.SelectedNode = this.m_LatelySell.LatelySellTree.Nodes[0].Nodes[0];
            }
            this.m_LatelySell.LatelySellTree.Nodes[0].Collapse(false);
        }

        

        private void MenuDeleteSell_Click(object sender, EventArgs e)
        {
            if (this.lvSell.SelectedItems != null && this.lvSell.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("将删除所选择的销售数据,请确认！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    foreach (ListViewItem lvi in this.lvSell.SelectedItems)
                    {
                        Foundation.DeleteSellNO(lvi.Tag.ToString());
                        //if(Foundation.DeleteSellNO(lvi.Tag.ToString()))
                        //{
                        //    this.labelTotal.Text = (Convert.ToInt32(this.labelTotal.Text) - Convert.ToInt32(lvi.SubItems[9].Text)).ToString();
                        //    this.labelTotalCount.Text = (Convert.ToInt32(this.labelTotalCount.Text) - Convert.ToInt32(lvi.SubItems[6].Text)).ToString();
                        //    this.lvSell.Items.Remove(lvi); 
                        //}                                         
                    }
                    tabControlSell_SelectedIndexChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的销售数据",
                     "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MenuResetSell_Click(object sender, EventArgs e)
        {
            if (this.lvSell.SelectedItems != null && this.lvSell.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("将恢复所选择的作废销售数据,请确认！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    foreach (ListViewItem lvi in this.lvSell.SelectedItems)
                    {
                        if (lvi.BackColor == Color.Red)
                        {
                            Foundation.ResetSellNO(lvi.Tag.ToString());
                            //if (Foundation.ResetSellNO(lvi.Tag.ToString()))
                            //{
                            //    this.labelTotal.Text = (Convert.ToInt32(this.labelTotal.Text) + Convert.ToInt32(lvi.SubItems[9].Text)).ToString();
                            //    this.labelTotalCount.Text = (Convert.ToInt32(this.labelTotalCount.Text) + Convert.ToInt32(lvi.SubItems[6].Text)).ToString();
                            //}
                        }
                    }
                    tabControlSell_SelectedIndexChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("请选择要恢复的作废销售数据",
                     "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        

        private void MenuCancelSell_Click(object sender, EventArgs e)
        {
            if (this.lvSell.SelectedItems != null && this.lvSell.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("将作废所选择的销售数据,请确认！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    foreach (ListViewItem lvi in this.lvSell.SelectedItems)
                    {
                        Foundation.CancelSellNO(lvi.Tag.ToString());
                        //if (Foundation.CancelSellNO(lvi.Tag.ToString()))
                        //{
                        //    lvi.BackColor = Color.Red;
                        //    this.labelTotal.Text = (Convert.ToInt32(this.labelTotal.Text) - Convert.ToInt32(lvi.SubItems[9].Text)).ToString();
                        //    this.labelTotalCount.Text = (Convert.ToInt32(this.labelTotalCount.Text) - Convert.ToInt32(lvi.SubItems[6].Text)).ToString();
                        //}
                    }
                    tabControlSell_SelectedIndexChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("请选择要作废的销售数据", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MenuSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void SellContextMenu_Opening(object sender, CancelEventArgs e)
        {
            this.MenuCancelSell.Visible = m_SystemUser.CancelSell;
            this.MenuDeleteSell.Visible = m_SystemUser.DeleteSell;
        }

        private void MenuCopy_Click(object sender, EventArgs e)
        {
            if (this.lvSell.SelectedItems != null && this.lvSell.SelectedItems.Count > 0)
            {
                string strCopy = string.Empty;
                for (int i = 1; i < this.lvSell.Columns.Count; i++)
                {
                    strCopy += this.lvSell.Columns[i].Text + ":" + this.lvSell.SelectedItems[0].SubItems[i].Text + " ";
                }

                if (strCopy != string.Empty)
                {
                    Clipboard.SetDataObject(strCopy);//有则把选择的文本放到剪贴板上
                }
            }
            else
            {
                MessageBox.Show("请选择要复制的销售数据", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MenuInvoicing_Click(object sender, EventArgs e)
        {
            ShowInvoicingInfo();
        }

        private void lvSell_DoubleClick(object sender, EventArgs e)
        {
            ShowInvoicingInfo();
        }
        private void ShowInvoicingInfo()
        {
            if (this.lvSell.SelectedItems != null && this.lvSell.SelectedItems.Count > 0)
            {
                InventoryInfo o = new InventoryInfo(ModeType.Sell,
                   Convert.ToInt32(this.lvSell.SelectedItems[0].Name.ToString()), m_SystemUser);
                o.ShowDialog(this.ParentForm);
            }
            else
            {
                MessageBox.Show("请选择要查看进销存信息的销售数据", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
