using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Invoicing.Common;

namespace Invoicing.Purchas
{
    public partial class frmPurchasGoods : Form
    {
        OperationType m_OperationType;
        public Purchas Purcha { get; set; }
        public event EventHandler<Purchas> AddedPurcha;
        public frmPurchasGoods(OperationType operationType)
        {
            InitializeComponent();
            m_OperationType = operationType;
            if (m_OperationType == OperationType.Add)
            {
                this.tabControl1.TabPages[0].Text = "添加";
            }
            else if (m_OperationType == OperationType.Modify)
            {
                this.tabControl1.TabPages[0].Text = "修改";
                this.cbAdds.Visible = false;
            }
        }

        private void frmPurchasGoods_Load(object sender, EventArgs e)
        {
            ShopUnit.ListUnit(this.cbbUnit);
            Providers.ListProviders(this.cbbProvider);
            GoodsType.ListType(this.cbbType);
            if (m_OperationType == OperationType.Modify)
            {
                this.txtGoodsname.Text = this.Purcha.GoodsName;
                this.txtGoodscode.Text = this.Purcha.GoodsCode;
                this.cbbUnit.SelectedIndex = this.cbbUnit.FindString(this.Purcha.UnitName);
                this.numCount.Value = this.Purcha.InCount;
                this.numPrice.Value = this.Purcha.InPrice;
                this.numFixPrice.Value = this.Purcha.FixPrice;
                this.cbbType.SelectedIndex = this.cbbType.FindString(this.Purcha.TypeName);
                this.cbbProvider.SelectedIndex = this.cbbProvider.FindString(this.Purcha.ProviderName);
                this.txtRemarks.Text = this.Purcha.Remarks;
                this.dtpInTime.Value = Convert.ToDateTime(this.Purcha.InTime);
            }
        }

        private void ClearInput()
        {
            this.txtGoodsname.Text = string.Empty; 
            this.txtGoodscode.Text = string.Empty;
            this.numCount.Value = 1;
            this.numPrice.Value = 1;
            this.numFixPrice.Value = 1;
            this.txtRemarks.Text = string.Empty;
            this.dtpInTime.Value = DateTime.Now;
            this.txtGoodsname.Focus();
        }
        private bool CheckData()
        {
            if (this.txtGoodsname.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this.ParentForm, "请输入商品名称！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (this.cbbProvider.SelectedIndex == -1 ||
                this.cbbType.SelectedIndex == -1 ||
                this.cbbUnit.SelectedIndex == -1)
            {
                MessageBox.Show(this.ParentForm, "请选择好单位、商品类别、供应商！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (m_OperationType == OperationType.Modify)
            {
                if (this.Purcha.InCount < this.Purcha.OutCount)
                {
                    MessageBox.Show(this.ParentForm, "商品进货数量不能少于已销售数量！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!CheckData())
                return;                       
            
            
            this.Purcha.GoodsName = this.txtGoodsname.Text;
            this.Purcha.GoodsCode = this.txtGoodscode.Text;
            
            this.Purcha.UnitNO = Convert.ToInt32((this.cbbUnit.SelectedItem as ComboBoxItem).Value);
            this.Purcha.TypeNO = Convert.ToInt32((this.cbbType.SelectedItem as ComboBoxItem).Value);
            this.Purcha.ProviderNO = Convert.ToInt32((this.cbbProvider.SelectedItem as ComboBoxItem).Value);

            this.Purcha.UnitName = Common.Foundation.GetDictName(DictType.GoodsUnit, this.Purcha.UnitNO.ToString());
            this.Purcha.TypeName = Common.Foundation.GetDictName(DictType.GoodsType, this.Purcha.TypeNO.ToString());
            this.Purcha.ProviderName = Common.Foundation.GetDictName(DictType.Providers, this.Purcha.ProviderNO.ToString());

            this.Purcha.FixPrice = this.numFixPrice.Value;
            this.Purcha.InCount = Convert.ToInt32(this.numCount.Value);
            this.Purcha.InPrice = this.numPrice.Value;
            this.Purcha.Remarks = this.txtRemarks.Text;
            this.Purcha.InTime = this.dtpInTime.Value.ToString("yyyy-MM-dd HH:mm:ss");

            if (m_OperationType == OperationType.Add)
            {
                if (!this.Purcha.Save())
                {
                    MessageBox.Show(this.ParentForm, "进货添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (AddedPurcha != null)
                {
                    AddedPurcha(this, this.Purcha);
                }
                if (this.cbAdds.Checked)
                {
                    this.Purcha = new Purchas();
                    this.txtGoodsname.Text = string.Empty;
                    this.txtGoodscode.Text = string.Empty;
                    this.cbbUnit.SelectedIndex = -1;
                    this.cbbProvider.SelectedIndex = -1;
                    this.cbbType.SelectedIndex = -1;
                    this.numCount.Value = 1;
                    this.numPrice.Value = 1;
                    this.numFixPrice.Value = 1;
                    this.txtRemarks.Text = string.Empty;

                }
                else
                {
                    this.Close();
                }
            }
            else if (m_OperationType == OperationType.Modify)
            {
                if (this.Purcha.Update())
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this.ParentForm, "进货修改失败！", "提示", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }            
        }
        private void txtGoodsname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtGoodscode.Focus();
                this.txtGoodscode.Select(0, this.txtGoodscode.Text.Length);
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
            }
        }
        private void txtGoodscode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.numCount.Focus();
                this.numCount.Select(0, this.numCount.Value.ToString().Length);
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
            }
        }
        private void numCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.numPrice.Focus();
                this.numPrice.Select(0, this.numPrice.Value.ToString().Length);
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
            }
        }

        private void numPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.numFixPrice.Focus();
                this.numFixPrice.Select(0, this.numFixPrice.Value.ToString().Length);
            }
        }
        private void numFixPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtRemarks.Focus();
                this.txtRemarks.Select(0, this.txtRemarks.Text.Length);
            }
        }
        private void txtRemarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btnOK.Focus();
            }
        }
        
    }
}
