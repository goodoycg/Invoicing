using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Invoicing.Common
{
    public partial class InventoryInfo : Form
    {
        private ModeType m_ModeType;
        private SystemUser m_SystemUser;
        private int m_ID;
        public InventoryInfo(ModeType _ModeType, int ID, SystemUser _SystemUser)
        {
            InitializeComponent();
            m_ModeType = _ModeType;
            m_ID = ID;
            m_SystemUser = _SystemUser;
        }

        private void OtherInfo_Load(object sender, EventArgs e)
        {//Purchas Stock sell 
           
            #region Purchas  
            DataSet dsPurchas = Foundation.GetGoodsPurchas(m_ID);
            this.lvPurchas.Items.Clear();
            foreach (DataRow dr in dsPurchas.Tables[0].Rows)
            {
                this.lvPurchas.Items.Add(new ListViewItem(new string[] { 
                dr["intime"].ToString(),
                dr["goodsname"].ToString(), 
                dr["incount"].ToString(), 
                dr["inprice"].ToString(), 
                dr["instat"].ToString(),
                dr["fixprice"].ToString() }));
            }
            #endregion

            #region sell
            if (m_SystemUser.SellInprice == false)
            {
                this.lvPurchas.Columns[3].Width = 0;
                this.lvPurchas.Columns[4].Width = 0;

                this.lvSell.Columns[4].Width = 0;

                this.lvStock.Columns[3].Width = 0;
                this.lvStock.Columns[5].Width = 0;
            }
            DataSet dsSell = Foundation.GetGoodsSell(m_ID);
            this.lvSell.Items.Clear();
            decimal profitAll = 0;
            int CountAll = 0;
            foreach (DataRow dr in dsSell.Tables[0].Rows)
            {
                //decimal profit = Convert.ToDecimal(dr["outcount"]) * (Convert.ToDecimal(dr["outprice"]) - Convert.ToDecimal(dr["fixprice"]));
                //profitAll += profit;
                CountAll += Convert.ToInt32(dr["outcount"]);
                this.lvSell.Items.Add(new ListViewItem(new string[] { (this.lvSell.Items.Count + 1).ToString().PadLeft(3,' '),
                dr["outtime"].ToString(),
                dr["goodsname"].ToString(), 
                dr["outcount"].ToString(), 
                dr["inprice"].ToString(), 
                dr["fixprice"].ToString(),
                dr["outprice"].ToString(), 
                dr["outstat"].ToString() }));
            }
                
            string strSell = Foundation.SellTotal(m_ID);
            if (strSell != string.Empty)
            {
                this.lvSell.Items.Add(new ListViewItem(new string[] { "合计", "", "", CountAll.ToString(), "", "", "", strSell }));
            }
            #endregion

            #region Stock
            DataSet dsStock = Foundation.GetStockGoods(m_ID);
            this.lvStock.Items.Clear();                
            foreach (DataRow dr in dsStock.Tables[0].Rows)
            {
                this.lvStock.Items.Add(new ListViewItem(new string[] { 
                dr["intime"].ToString(),
                dr["goodsname"].ToString(), 
                dr["stockcount"].ToString(),
                dr["inprice"].ToString(), 
                dr["fixprice"].ToString(),
                dr["instat"].ToString() }));//库存金额
            }
            #endregion
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
