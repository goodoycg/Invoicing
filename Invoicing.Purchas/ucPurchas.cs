using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Invoicing.Common;

namespace Invoicing.Purchas
{
    public partial class ucPurchas : UserControl, IOutput, ISearchGoods
    {
        private string m_strDatetime = string.Empty;
        private string m_strCurrentGoodsDatetime = string.Empty;
        private ucDateTime m_Datetime;
        private ucProviderTree m_ProviderTree;
        private ucGoodsTypeTree m_GoodsTypeTree;
        public event EventHandler<EventArgs> PurchasChanged;
        private SystemUser m_SystemUser;
        public ucPurchas(SystemUser _SystemUser)
        {
            InitializeComponent();

            m_SystemUser = _SystemUser;

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

            this.lvPurchas.ListDecimalColumnIndex.AddRange(new int[] { 0, 7, 8, 9, 10 });

            this.tabControlGoods.TabPages[0].Controls.Add(m_Datetime);
            this.tabControlGoods.TabPages[1].Controls.Add(m_GoodsTypeTree);
            this.tabControlGoods.TabPages[2].Controls.Add(m_ProviderTree);

           
        }

        public void RefreshChart()
        {
            this.chartColumn.BackColor = Color.White;
            this.chartPie.BackColor = Color.White;

            this.chartColumn.Series[0].Color = Color.Green;

            this.chartColumn.ChartAreas[0].AxisX.MajorGrid.Interval = 2;//X轴全部显示

            this.chartPie.ChartAreas[0].Area3DStyle.Enable3D = true;
            this.chartColumn.ChartAreas[0].Area3DStyle.Enable3D = true;

            this.rbYearmonth_CheckedChanged(null, null);
        } 
        public void InitTree()
        {
            m_Datetime.InitTree();
        }               
        
        private void tabControlGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlGoods.SelectedIndex == 0)
            {
                if (m_Datetime.tvDatetime.SelectedNode != null)
                {
                    LoadData(Foundation.GetDatetimeData(this.m_strDatetime));
                }
            }
            else if (this.tabControlGoods.SelectedIndex == 1)
            {
                if (m_GoodsTypeTree.GoodsTypeTree.SelectedNode != null)
                {
                    LoadData(Foundation.GetGoodsTypeData(m_GoodsTypeTree.GoodsTypeTree.SelectedNode.Tag.ToString()));
                }
                else
                {
                    m_GoodsTypeTree.GoodsTypeTree.SelectedNode = m_GoodsTypeTree.GoodsTypeTree.Nodes[0];
                }
            }
            else if (this.tabControlGoods.SelectedIndex == 2)
            {
                if (m_ProviderTree.ProviderTree.SelectedNode != null)
                {
                    LoadData(Foundation.GetProviderData(m_ProviderTree.ProviderTree.SelectedNode.Tag.ToString()));
                }
                else
                {
                    m_ProviderTree.ProviderTree.SelectedNode = m_ProviderTree.ProviderTree.Nodes[0];
                }
            }
        }
        void m_Datetime_DatetimeChanged(object sender, DatetimeTreeEventArgs e)
        {
            this.MenuAdd.Enabled = e.dateTimeType == DatetimeType.Day;            
            m_strDatetime = e.DatatimeString;

            LoadData(Foundation.GetDatetimeData(m_strDatetime));
        }
        void GoodsTypeTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadData(Foundation.GetGoodsTypeData(e.Node.Tag.ToString()));
        }        
        void ProviderTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadData(Foundation.GetProviderData(e.Node.Tag.ToString()));
        }
        public void Search()
        {
            frmSearch s = new frmSearch(ModeType.Stock);
            if (s.ShowDialog(this.ParentForm) == DialogResult.OK)
            {
                string strGoodName = s.GoodsName;

                string strSql = @"select Purchas.*,round(incount * inprice,2) as instat,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
                strSql += "from Purchas,Providers,goodsunit,GoodsType ";
                strSql += "where Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno and ";
                strSql += "GoodsType.typeno=purchas.typeno and Purchas.goodsname";
                if (s.IsFuzzy)
                {
                    strSql += " like '%" + strGoodName + "%' order by intime desc";//recorddatetime like '" + Datetime + "%'");
                }
                else
                {
                    strSql += " ='" + strGoodName + "' order by intime desc";
                }
                DataSet ds = Foundation.ReadDataSet(strSql);
                LoadData(ds);
            }
        }
        private void LoadData(DataSet ds)
        {
            this.lvPurchas.Items.Clear();                 
            
            decimal iStat = 0;
            int iStatCount = 0;
            decimal FixpriceTotal = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.lvPurchas.Items.Add(new ListViewItem(new string[] {
                    (this.lvPurchas.Items.Count + 1).ToString().PadLeft(3,' '), 
                    dr["intime"].ToString(),
                    dr["goodsname"].ToString(), 
                    dr["goodscode"].ToString(),
                    dr["unitname"].ToString(), 
                    dr["typename"].ToString(), 
                    dr["providername"].ToString(), 
                    dr["incount"].ToString(), 
                    dr["inprice"].ToString(), 
                    dr["instat"].ToString(), 
                    dr["fixprice"].ToString(),
                    dr["remarks"].ToString() }) { 
                    Tag = dr["goodsno"].ToString(), 
                    Name = dr["outcount"].ToString() });               
                
                iStat += Convert.ToDecimal(dr["instat"].ToString());
                iStatCount += Convert.ToInt32(dr["incount"].ToString());
                FixpriceTotal += Convert.ToDecimal(dr["fixprice"].ToString()) * Convert.ToDecimal(dr["incount"].ToString());
            }
            this.labelTotal.Text = iStat.ToString();// Purchas.PurchasTotal(m_strDatetime);
            this.labelTotalCount.Text = iStatCount.ToString();
            this.label1FixpriceTotal.Text = FixpriceTotal.ToString();
        }        

            
        
        private void MenuAdd_Click(object sender, EventArgs e)
        {
            frmPurchasGoods frmPurcha = new frmPurchasGoods(OperationType.Add);
            //直接写方法
            frmPurcha.AddedPurcha += new EventHandler<Purchas>((o, purcha) =>
            {
                this.lvPurchas.Items.Insert(0, new ListViewItem(new string[] { 
                    (this.lvPurchas.Items.Count + 1).ToString().PadLeft(3 ,' '),
                    purcha.InTime,
                    purcha.GoodsName, 
                    purcha.GoodsCode,
                    purcha.UnitName,
                    purcha.TypeName,
                    purcha.ProviderName,
                    purcha.InCount.ToString(), 
                    purcha.InPrice.ToString(), 
                    Convert.ToString(purcha.InPrice * purcha.InCount),
                    purcha.FixPrice.ToString(),
                    purcha.Remarks }) { Tag = purcha.GoodsNO, Name = "0" });
                this.labelTotal.Text = (Convert.ToDecimal(this.labelTotal.Text) + purcha.InPrice * purcha.InCount).ToString();
                if (PurchasChanged != null)
                {
                    PurchasChanged(null, null);
                }
                tabControlGoods_SelectedIndexChanged(null, null);
            });
            frmPurcha.Purcha = new Purchas();
            frmPurcha.ShowDialog(this.ParentForm);
        }

       
        private void MenuModify_Click(object sender, EventArgs e)
        {
            if (this.lvPurchas.SelectedItems == null || this.lvPurchas.SelectedItems.Count < 1)
            {
                return;
            }
            frmPurchasGoods frmPurchas = new frmPurchasGoods(OperationType.Modify);
            Purchas purchas = new Purchas(Convert.ToInt32(this.lvPurchas.SelectedItems[0].Tag.ToString()));            
            frmPurchas.Purcha = purchas;
            if (frmPurchas.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }
            
            purchas.InTime = m_strCurrentGoodsDatetime;
            
            int iIndex = 1;
            this.lvPurchas.SelectedItems[0].SubItems[iIndex++].Text = purchas.InTime;
            this.lvPurchas.SelectedItems[0].SubItems[iIndex++].Text = purchas.GoodsName;
            this.lvPurchas.SelectedItems[0].SubItems[iIndex++].Text = purchas.GoodsCode;

            this.lvPurchas.SelectedItems[0].SubItems[iIndex++].Text = purchas.UnitName;// this.cbbUnit.SelectedItem.ToString();
            this.lvPurchas.SelectedItems[0].SubItems[iIndex++].Text = purchas.TypeName;//this.cbbType.SelectedItem.ToString();
            this.lvPurchas.SelectedItems[0].SubItems[iIndex++].Text = purchas.ProviderName;//this.cbbProvider.SelectedItem.ToString();

            this.lvPurchas.SelectedItems[0].SubItems[iIndex++].Text = purchas.InCount.ToString();
            this.lvPurchas.SelectedItems[0].SubItems[iIndex++].Text = purchas.InPrice.ToString();
            this.lvPurchas.SelectedItems[0].SubItems[iIndex++].Text = Convert.ToString(purchas.InPrice * purchas.InCount);
            this.lvPurchas.SelectedItems[0].SubItems[iIndex++].Text = purchas.FixPrice.ToString();

            this.lvPurchas.SelectedItems[0].SubItems[iIndex++].Text = purchas.Remarks;

            this.labelTotal.Text = (Convert.ToDecimal(this.labelTotal.Text) - Convert.ToDecimal(this.lvPurchas.SelectedItems[0].SubItems[9].Text) + purchas.InPrice * purchas.InCount).ToString();


            if (PurchasChanged != null)
            {
                PurchasChanged(null, null);
            }
            tabControlGoods_SelectedIndexChanged(null, null);
           
        }

        private void MenuDelete_Click(object sender, EventArgs e)
        {
            if (this.lvPurchas.SelectedItems == null || this.lvPurchas.SelectedItems.Count < 1)
            {
                MessageBox.Show(this.ParentForm, "请选择要删除的进货！", "提示", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show(this.ParentForm, "所选择的进货将被删除，请确认！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr != DialogResult.OK)
            {
                return;
            }
            Purchas purchas = new Purchas { GoodsNO = Convert.ToInt32(this.lvPurchas.SelectedItems[0].Tag.ToString()) };
            if (purchas.Delete())
            {
                this.labelTotal.Text = (Convert.ToDecimal(this.labelTotal.Text) - Convert.ToDecimal(this.lvPurchas.SelectedItems[0].SubItems[8].Text)).ToString();
                this.lvPurchas.Items.Remove(this.lvPurchas.SelectedItems[0]);
                if (PurchasChanged != null)
                {
                    PurchasChanged(null, null);
                }

                tabControlGoods_SelectedIndexChanged(null, null);
            }
        }

        private void MenuCopy_Click(object sender, EventArgs e)
        {
            if (this.lvPurchas.SelectedItems != null && this.lvPurchas.SelectedItems.Count > 0)
            {
                string strCopy = string.Empty;
                for (int i = 1; i < this.lvPurchas.Columns.Count; i++)
                {
                    strCopy += this.lvPurchas.Columns[i].Text + ":" + this.lvPurchas.SelectedItems[0].SubItems[i].Text + " ";
                }
                if (strCopy != string.Empty)
                {
                    Clipboard.SetDataObject(strCopy);//有则把选择的文本放到剪贴板上
                }
            }
            else
            {
                MessageBox.Show("请选择要复制的进货数据", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MenuInvoicing_Click(object sender, EventArgs e)
        {
            lvPurchas_DoubleClick(null, null);
        }

        private void lvPurchas_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvPurchas.SelectedItems == null || this.lvPurchas.SelectedItems.Count == 0)
                return;
            InventoryInfo o = new InventoryInfo(ModeType.Purchas,
                Convert.ToInt32(this.lvPurchas.SelectedItems[0].Tag.ToString()), m_SystemUser);
            o.ShowDialog(this.ParentForm);
        }
        public void Output()
        {
            Foundation.OutputCSV(this.lvPurchas, "进货" + System.DateTime.Now.ToString("yyyyMMddHHssmm") + ".csv",
                new string[] {
                    this.labelTotal_.Text,
                    this.labelTotal.Text,
                    this.labelTotalCount_.Text,
                    this.labelTotalCount.Text,
                this.label1FixpriceTotal_.Text,
                this.label1FixpriceTotal.Text});
        }

        
        private void rbGoodType_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbGoodType.Checked)
            {
                string s = "SELECT typename as 商品类别,round(sum(incount*inprice),2) as 金额 from Purchas,goodstype where purchas.typeno=goodstype.typeno group by goodstype.typename";
                
                DataTable dtData = Invoicing.Common.Foundation.ReadDataSet(s).Tables[0];

                chartColumn.DataSource = dtData;
                chartColumn.Series[0].YValueMembers = "金额";
                chartColumn.Series[0].XValueMember = "商品类别";
                chartColumn.Series[0].ChartType = SeriesChartType.Column;
                this.chartColumn.Series[0].IsValueShownAsLabel = true;
                this.chartColumn.ChartAreas[0].AxisX.Interval = 1;//設置X軸座標的間隔為1  
                this.chartColumn.ChartAreas[0].AxisX.IntervalOffset = 1;//設置X軸座標偏移為1
                //this.chartColumn.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true;//設置是否交錯顯示，比如數據多時分成兩行來顯示
                this.chartColumn.Width = 300 + dtData.Rows.Count * 60;

                chartPie.DataSource = dtData;
                chartPie.Series[0].YValueMembers = "金额";
                chartPie.Series[0].XValueMember = "商品类别";
                chartPie.Series[0].ChartType = SeriesChartType.Pie;
                this.chartPie.BackColor = Color.White;
            }
        }

        private void rbYearmonth_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbYearmonth.Checked)
            {
                string s = "SELECT t as 进货年月 ,round(sum(incount*inprice),2) as 金额 from (select incount,inprice,format(cdate(intime),'yyyy-mm') as t from Purchas) group by t";
                
                DataTable dtData = Invoicing.Common.Foundation.ReadDataSet(s).Tables[0];

                chartColumn.DataSource = dtData;
                chartColumn.Series[0].YValueMembers = "金额";
                chartColumn.Series[0].XValueMember = "进货年月";
                chartColumn.Series[0].ChartType = SeriesChartType.Column;
                this.chartColumn.Series[0].IsValueShownAsLabel = true;
                this.chartColumn.ChartAreas[0].AxisX.Interval = 1;
                this.chartColumn.ChartAreas[0].AxisX.IntervalOffset = 1;
                //this.chartColumn.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true;
                this.chartColumn.Width = 300 + dtData.Rows.Count * 60;


                chartPie.DataSource = dtData;
                chartPie.Series[0].YValueMembers = "金额";
                chartPie.Series[0].XValueMember = "进货年月";
                chartPie.Series[0].ChartType = SeriesChartType.Pie;
                this.chartPie.BackColor = Color.White;
            }
        }

        private void rbProvider_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbProvider.Checked)
            {
                string s = "SELECT providername as 供应商,round(sum(incount*inprice),2) as 金额 from Purchas,providers where purchas.providerno=providers.providerno group by providers.providername";
                
                DataTable dtData = Invoicing.Common.Foundation.ReadDataSet(s).Tables[0];

                this.chartColumn.DataSource = dtData;
                this.chartColumn.Series[0].YValueMembers = "金额";
                this.chartColumn.Series[0].XValueMember = "供应商";
                this.chartColumn.Series[0].ChartType = SeriesChartType.Column;
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

        private void cb3D_CheckedChanged(object sender, EventArgs e)
        {
            this.chartPie.ChartAreas[0].Area3DStyle.Enable3D = this.cb3D.Checked;
            this.chartColumn.ChartAreas[0].Area3DStyle.Enable3D = this.cb3D.Checked;
        }      

        
    }
}
