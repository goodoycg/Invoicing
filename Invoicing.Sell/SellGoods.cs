using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using Invoicing.Common;


namespace Invoicing.Sell
{
    public partial class SellGoods : Form
    {
        public int GoodsNO { set; get; }
        public decimal Inprice { set; get; }
        private string CurrGoodsCode { set; get; }
        OtherInfo other;
        public SellGoods()
        {
            InitializeComponent();
            this.lvSell.ListDecimalColumnIndex.AddRange(new int[] { 0, 2, 3, 4, 5, 6, 7 });
        }
        private void SellGoods_Load(object sender, EventArgs e)
        {
            other = Foundation.GetOtherInfo();
            this.cbbPrint.Checked = other.Sell2Print;
            
        }
        private void btnSelectgoods_Click(object sender, EventArgs e)
        {
            frmGoods goods = new frmGoods();
            Point p = this.PointToScreen(this.btnSelectgoods.Location);
            goods.Location = new Point(p.X - goods.Width, p.Y - goods.Height);

            if (goods.ShowDialog(this) == DialogResult.OK)
            {
                this.numPriceDisCount.Value = 10;
                this.txtGoodsname.Text = goods.GoodsName;
                this.CurrGoodsCode = goods.GoodsCode;
                this.txtFixPrice.Text = goods.FixPrice.ToString();
                this.numPrice.Value = goods.FixPrice;
                dFixPrice = goods.FixPrice;
                this.numCount.Maximum = goods.StockCount;                
                this.GoodsNO = goods.GoodsNO;
                this.Inprice = goods.StockInPrice;
                this.numCount.Focus();
                this.numCount.Select(0, this.numCount.Value.ToString().Length);
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
            }
        }
        private decimal dFixPrice = 0;
        private decimal dStatIn = 0;
        private decimal dDisCountStat = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtGoodsname.Text == string.Empty || this.numCount.Value == 0 || this.numPrice.Value == 0)
            {
                MessageBox.Show(this, "请设置好商品、单价和数量！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; ;
            }
            if (this.numCount.Value > this.numCount.Maximum)
            {
                MessageBox.Show(this, "销售数量不能大于库存数量！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; ;
            }
            decimal dPrice = this.numPrice.Value;
            dPrice = dPrice * this.numPriceDisCount.Value / 10;
            decimal TotalMoney = this.numCount.Value * dPrice;//金额
            decimal DisCountMoney = this.numCount.Value * dFixPrice - TotalMoney;//折扣金额
            this.lvSell.Items.Add(
                new ListViewItem(
                    new string[] { 
                        (this.lvSell.Items.Count +1).ToString().PadLeft(3 ,' '), 
                        this.txtGoodsname.Text,
                        this.CurrGoodsCode,
                    this.numCount.Value.ToString(),
                    dPrice.ToString(),
                    TotalMoney.ToString(),
                    DisCountMoney.ToString(),
                    this.txtFixPrice.Text,                    
                    this.txtRemarks.Text})
                        {
                            Tag = this.GoodsNO
                        });
            dStatIn += TotalMoney;
            dDisCountStat += DisCountMoney;
            this.numCount.Minimum = 0;
            this.numPrice.Minimum = 0;
            this.numCount.Value = 0;
            this.numPrice.Value = 0;
            this.txtGoodsname.Text = string.Empty;
            this.txtFixPrice.Text = string.Empty;
            this.txtStatIn.Text = dStatIn.ToString();
            this.txtDisCountTotal.Text = dDisCountStat.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lvSell.SelectedItems == null || this.lvSell.SelectedItems.Count < 1)
                return;

            dStatIn -= Convert.ToDecimal(this.lvSell.SelectedItems[0].SubItems[5].Text);
            this.txtStatIn.Text = dStatIn.ToString();

            dDisCountStat -= Convert.ToDecimal(this.lvSell.SelectedItems[0].SubItems[6].Text);
            this.txtDisCountTotal.Text = dDisCountStat.ToString();           

            this.lvSell.Items.Remove(this.lvSell.SelectedItems[0]);
            for (int i = 0; i < this.lvSell.Items.Count; i++)
            {
                this.lvSell.Items[i].Text = (i + 1).ToString().PadLeft(3, ' ');
            }
        }
        private string m_strDataTime;
        public string SellDataTime
        {
            get { return m_strDataTime; }
            set { m_strDataTime = value; }
        }
        private int m_OrderNO;
        public int OrderNO
        {
            get { return m_OrderNO; }
            set { m_OrderNO = value; }
        }
        
        public event EventHandler<GoodsSelledEventArgs> GoodsSelled;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.lvSell.Items.Count < 1)
                return;

            GoodsSelledEventArgs ee = new GoodsSelledEventArgs();
            OrderNO = Foundation.GetNewOrderNO();
            SellDataTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            foreach (ListViewItem lvi in this.lvSell.Items)
            {
                Sell sell = new Sell();
                sell.OrderNO = OrderNO;
                sell.GoodsNO = Convert.ToInt32(lvi.Tag.ToString());
                sell.OutTime = SellDataTime;
                sell.OutCount = Convert.ToInt32(lvi.SubItems[3].Text);
                sell.OutPrice = Convert.ToDecimal(lvi.SubItems[4].Text);
                sell.Remarks = lvi.SubItems[8].Text;

                if (sell.Save())
                {
                    //ee.listSellNO.Add(sell.SellNO); 
                    ee.SellTime = SellDataTime;               
                }
            }

            if (GoodsSelled != null)
            {
                GoodsSelled(null, ee);
            }

            if (this.cbbPrint.Checked)
            {
                PrintData();
            }
                    
            
            //iStatIn = 0;
            //this.txtReturnOut.Text = "0";
            //this.numTrueIN.Value = 0;
            //this.txtStatIn.Text = iStatIn.ToString();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            
            decimal d2 = Convert.ToDecimal(this.txtStatIn.Text);//应收
            decimal d3 = d2;
            d2 = d2 * this.numDisCount.Value / 10;//折扣后应收
            if (this.numTrueIN.Value < d2)
            {
                MessageBox.Show(this, "实收不能少于折扣后应收！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.txtDisCountTotal.Text = (Convert.ToDecimal(this.txtDisCountTotal.Text) + d3 - d2).ToString();
            this.txtReturnOut.Text = (this.numTrueIN.Value - d2).ToString();
        }

        #region 打印
        /// <summary>
        /// 每页行数(不包括标题行)
        /// </summary>
        private int m_iRowCountPerPage = 45;
        /// <summary>
        /// 当前行
        /// </summary>
        private int m_iCurrentRow = 0;
        /// <summary>
        /// 当前页
        /// </summary>
        private int m_iCurrentPage = 0;
        private System.Drawing.Printing.PageSettings storedPageSettings = null;
        /// <summary>
        /// 数据的总行数
        /// </summary>
        private int iLVRowCount = 0;
        /// <summary>
        /// 数据的总列数
        /// </summary>
        private int iLVColCount = 0;
        private string strTitle = "";
        /// <summary>
        /// 表格的标题
        /// </summary>
        private List<string> listTitle = new List<string>();
        /// <summary>
        /// 单元格的宽度
        /// </summary>
        float[] CellWidth;
        /// <summary>
        /// 左边距
        /// </summary>
        float LeftWidth = 50.0F;
        /// <summary>
        /// 上边距
        /// </summary>
        float TopWidth = 50.0F;
        /// <summary>
        /// 单元格高度
        /// </summary>
        float CellHeight = 20.0F;
        /// <summary>
        /// 第一行的高度
        /// </summary>
        float FirstRowHeight = 20F;
        /// <summary>
        /// 整个表格宽度
        /// </summary>
        float TableWidth;
        /// <summary>
        /// 每个单元格左边的Ｘ坐标
        /// </summary>
        float[] CellWidthStartLeft;
        string strTitleAddress;
        string strTitleTelTime;
        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="bPreview">是否预览</param>
        private void PrintData()
        {
            iLVRowCount = this.lvSell.Items.Count;

            m_iCurrentRow = 0;
            try
            {
                PrintDocument pd = new PrintDocument();
                //假定为默认打印机
                if (storedPageSettings != null)
                {
                    pd.DefaultPageSettings = storedPageSettings;
                }
                pd.DefaultPageSettings.Landscape = false;//页面是纵向false，如横向用true
                pd.PrintPage += new PrintPageEventHandler(PrintSell);

                m_iCurrentPage = 0;
                int m_iPageCount = iLVRowCount / this.m_iRowCountPerPage;
                if (iLVRowCount % this.m_iRowCountPerPage > 0)
                {
                    m_iPageCount++;
                }
                pd.PrinterSettings.MinimumPage = 1;
                pd.PrinterSettings.MaximumPage = m_iPageCount;
                pd.PrinterSettings.FromPage = 1;
                pd.PrinterSettings.ToPage = m_iPageCount;

                if (this.cbbPrint.Checked)
                {
                    PrintPreviewDialog dlg = new PrintPreviewDialog();
                    dlg.Document = pd;

                    Form print = dlg.FindForm();
                    print.Text = "打印预览销售单";//标题
                    print.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    print.StartPosition = FormStartPosition.CenterScreen;
                    pd.DocumentName = m_iPageCount.ToString();

                    dlg.ShowDialog();
                }
                //else
                //{                
                    //pd.Print();//直接打印
                //}
                
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message + ex.StackTrace);
            }
        }     
       
        private void PrintSell(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrintDocument pd = sender as PrintDocument;
            try
            {
                this.m_iCurrentPage++;
                int iTotalPage = iLVRowCount / this.m_iRowCountPerPage;
                if (iLVRowCount % this.m_iRowCountPerPage > 0)
                {
                    iTotalPage++;
                }
                //调整到打印范围开始页
                if (m_iCurrentPage < e.PageSettings.PrinterSettings.FromPage)
                {
                    this.m_iCurrentPage = e.PageSettings.PrinterSettings.FromPage;
                    this.m_iCurrentRow += this.m_iRowCountPerPage * ((e.PageSettings.PrinterSettings.FromPage - 1) / 2);
                }

                #region 标  题
                TableWidth = pd.DefaultPageSettings.Bounds.Width - 2 * LeftWidth;
                iLVColCount = 5;
                ShopInfo shopInfo = new ShopInfo();
                strTitle = shopInfo.Shopname;
                strTitleAddress = "地址：" + shopInfo.Shopaddress;
                strTitleTelTime = "电话：" + shopInfo.Shoptel + " 时间：" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                listTitle.Clear();
                for (int i = 1; i < this.lvSell.Columns.Count - 2; i++)
                {//序号与定价\备注不打印
                    listTitle.Add(this.lvSell.Columns[i].Text);
                }
                CellWidth = new float[6] { 320f, 120f, 80f, 80f, 80f, 80f };//只能为常数
                CellWidth[0] = TableWidth - CellWidth[1] - CellWidth[2] - CellWidth[3] - CellWidth[4] - CellWidth[5];

                float firstRowAdd = 0F;         //第一行高出的数值
                float tableheight = CellHeight * m_iRowCountPerPage + FirstRowHeight + firstRowAdd;
                //float strheight = 100F;//标题的高度
                float CurrentYValue = TopWidth;
                float fRowHeight = 40F;
                PrintDraw.DrawString(e.Graphics, strTitle, LeftWidth, CurrentYValue, TableWidth, fRowHeight,
                    StringAlignment.Center, new Font("楷体_GB2312", 20, System.Drawing.FontStyle.Bold));
                CurrentYValue += fRowHeight;

                fRowHeight = 20F;
                PrintDraw.DrawString(e.Graphics, strTitleAddress, LeftWidth, CurrentYValue, TableWidth, fRowHeight,
                    StringAlignment.Center, new Font("楷体_GB2312", 10, System.Drawing.FontStyle.Regular));
                CurrentYValue += fRowHeight;

                fRowHeight = 20F;
                PrintDraw.DrawString(e.Graphics, strTitleTelTime, LeftWidth, CurrentYValue, TableWidth, fRowHeight,
                    StringAlignment.Center, new Font("楷体_GB2312", 10, System.Drawing.FontStyle.Regular));
                CurrentYValue += fRowHeight;

                Pen doublePen = new Pen(Color.DarkRed, 1);
                #endregion

                #region  线条
                //外框.
                Pen blackPen = new Pen(Color.Black, 3);
                //最外的矩形
                float table_x = LeftWidth;
                float table_y = CurrentYValue;//+ 20F
                blackPen = new Pen(Color.Black, 1);
                table_y += firstRowAdd;
                CellWidthStartLeft = new float[CellWidth.Length];
                float f = 0f;
                for (int i = 0; i < CellWidthStartLeft.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        f += CellWidth[j];
                    }
                    CellWidthStartLeft[i] = f;
                    f = 0f;
                }
                float fCellWidth1 = TableWidth / this.iLVColCount;//列数
                #endregion

                #region 表内数据
                for (int i = 0; i < listTitle.Count; i++)
                {//标题
                    PrintDraw.DrawString(e.Graphics, listTitle[i],
                                      LeftWidth + CellWidthStartLeft[i],
                                      table_y,//
                                      CellWidth[i],
                                      CellHeight,
                                      System.Drawing.StringAlignment.Center, new Font("宋体", 9, FontStyle.Bold));
                }

                e.Graphics.DrawLine(blackPen, table_x, table_y + FirstRowHeight, table_x + TableWidth, table_y + FirstRowHeight);

                int iRow = 1;
                string strDrawText = string.Empty;
                int iGCol = 1;
                for (int iGRow = this.m_iCurrentRow; iGRow < this.m_iCurrentRow + this.m_iRowCountPerPage; iGRow++)
                {
                    if (iGRow == this.lvSell.Items.Count)
                    {
                        break;
                    }
                    for (iGCol = 1; iGCol < this.lvSell.Columns.Count - 2; iGCol++)
                    {
                        if (iGCol == 1)
                        {
                            strDrawText = this.lvSell.Items[iGRow].SubItems[iGCol - 1].Text.PadLeft(3, ' ') + " " + this.lvSell.Items[iGRow].SubItems[iGCol].Text;
                        }
                        else
                        {
                            strDrawText = this.lvSell.Items[iGRow].SubItems[iGCol].Text;
                        }
                        PrintDraw.DrawString(e.Graphics, strDrawText,
                            LeftWidth + CellWidthStartLeft[iGCol - 1],
                            table_y + CellHeight * (iRow - 1) + FirstRowHeight,
                            CellWidth[iGCol - 1],
                            CellHeight,
                            System.Drawing.StringAlignment.Center,
                            new Font("宋体", 9));
                    }
                    iRow++;
                }


                #endregion
                if (this.m_iCurrentPage < iTotalPage && this.m_iCurrentPage < e.PageSettings.PrinterSettings.ToPage)
                {
                    this.m_iCurrentRow += this.m_iRowCountPerPage;
                    e.HasMorePages = true;
                }
                else
                {
                    this.m_iCurrentPage = 0;
                    this.m_iCurrentRow = 0;
                    e.HasMorePages = false;

                    e.Graphics.DrawLine(blackPen,
                        LeftWidth,
                        table_y + CellHeight * (iRow - 1) + FirstRowHeight,
                        LeftWidth + TableWidth,
                        table_y + CellHeight * (iRow - 1) + FirstRowHeight);

                    string strText = "总件数：" + this.lvSell.Items.Count.ToString() + " ";
                    strText += "应收：" + this.txtStatIn.Text + "元 ";
                    strText += "实收：" + this.numTrueIN.Value.ToString() + "元 ";
                    strText += "找零：" + this.txtReturnOut.Text + "元 ";
                    strText += "折扣金额：" + this.txtDisCountTotal.Text + "元";
                    
                    PrintDraw.DrawString(e.Graphics, strText,
                                    LeftWidth,
                                    table_y + CellHeight * (iRow - 2) + FirstRowHeight,//
                                    TableWidth,
                                    CellHeight * 5,
                                    System.Drawing.StringAlignment.Center,
                                    new Font("宋体", 9));

                    strText = other.Notethings;
                    strText += "\r\n\r\n欢迎再次光临";
                    PrintDraw.DrawString(e.Graphics, strText,
                                    LeftWidth,
                                    table_y + CellHeight * iRow + FirstRowHeight,//
                                    TableWidth,
                                    CellHeight * 5,
                                    System.Drawing.StringAlignment.Center,
                                    new Font("宋体", 9));
                }

            }
            catch (Exception ex)
            {
                e.Graphics.DrawString(ex.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(10, 10));
            }
        }
        #endregion        
    }
}
