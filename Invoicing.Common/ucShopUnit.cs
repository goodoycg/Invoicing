using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Invoicing.Common
{
    public partial class ucShopUnit : UserControl, ISystemSet
    {
        public ucShopUnit()
        {
            InitializeComponent();
            (new ShopUnit()).ListUnit(this.lvUnit);
        }

        public bool Save()
        {
            if (this.txtUnit.Text.Trim().Length == 0)
                return false;

            ShopUnit u = new ShopUnit();
            u.UnitName = this.txtUnit.Text.Trim();
            if (u.Save())
            {
                this.lvUnit.Items.Add(new ListViewItem(new string[] { Convert.ToString(this.lvUnit.Items.Count + 1).PadLeft(3, ' '), u.UnitName }) { Tag = u.UnitNO });
                this.txtUnit.Text = string.Empty;
                return true;
            }
            return false;
        }

        public bool Delete()
        {
            if (this.lvUnit.SelectedItems == null || this.lvUnit.SelectedItems.Count < 1)
                return false;

            ShopUnit u = new ShopUnit();
            u.UnitNO = Convert.ToInt32(this.lvUnit.SelectedItems[0].Tag.ToString());
            if (u.Delete())
            {
                this.lvUnit.Items.Remove(this.lvUnit.SelectedItems[0]);
                this.txtUnit.Text = string.Empty;
                return true;
            }
            return false;
        }

        public bool Modify()
        {
            if (this.lvUnit.SelectedItems == null || this.lvUnit.SelectedItems.Count < 1 || 
                this.txtUnit.Text.Trim().Length == 0)
                return false;

            ShopUnit u = new ShopUnit();
            u.UnitNO = Convert.ToInt32(this.lvUnit.SelectedItems[0].Tag.ToString());
            u.UnitName = this.txtUnit.Text.Trim();
            if (u.Update())
            {
                this.lvUnit.SelectedItems[0].SubItems[1].Text = u.UnitName;
                return true;
            }
            return false;
        }
        public bool AddButton
        {
            get { return true; }
        }

        public bool ModifyButton
        {
            get { return true; }
        }

        public bool DeleteButton
        {
            get { return true; }
        }
        public string SetType
        {
            get { return "商品单位"; }//供应商类别商品类别店铺信息其它信息
        }
        private void lvUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvUnit.SelectedItems == null || this.lvUnit.SelectedItems.Count < 1)
                return;
            this.txtUnit.Text = this.lvUnit.SelectedItems[0].SubItems[1].Text;
        }
        
    }
}
