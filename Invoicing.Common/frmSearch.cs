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
    public partial class frmSearch : Form
    {
        private ModeType m_ModeType;
        public frmSearch(ModeType modeType)
        {
            InitializeComponent();
            m_ModeType = modeType;
        }
        public string GoodsName
        {
            get { return this.txtGoodsName.Text.Trim(); }
        }
        public string GoodsCode
        {
            get { return this.txtGoodsCode.Text.Trim(); }
        }
        public bool IsFuzzy
        {
            get { return this.rbFuzzy.Checked; }
        }
        private void frmSearch_Load(object sender, EventArgs e)
        {
            this.txtGoodsCode.Visible = false;
            this.labelGoodscode.Visible = false;

            if (m_ModeType == ModeType.Purchas)
            {
                SearchPurchas();
            }
            else if (m_ModeType == ModeType.Sell)
            {
                SearchSell();

                this.txtGoodsCode.Visible = true;
                this.labelGoodscode.Visible = true;

                this.txtGoodsName.Top = this.txtGoodsName.Top - this.txtGoodsName.Height;
                this.labelGoodsname.Top = this.labelGoodsname.Top - this.txtGoodsName.Height;
            }
            else if (m_ModeType == ModeType.Stock)
            {
                SearchStock();                
            }

            this.txtGoodsName.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtGoodsName.Text.Trim() == string.Empty && this.txtGoodsCode.Text.Trim() == string.Empty)
            {
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void SearchPurchas()
        {

        }
        private void SearchSell()
        {

        }
        private void SearchStock()
        {

        }

        private void txtGoodsName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.txtGoodsCode.Visible)
                {
                    this.txtGoodsCode.Focus();
                }
                else
                {
                    this.btnSearch_Click(null, null);
                }
            }
            
        }

        private void txtGoodsCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btnSearch_Click(null, null);
            }
        }
    }
}
