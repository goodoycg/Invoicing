using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Invoicing.Common
{
    public partial class ucGoodsType : UserControl, ISystemSet
    {
        public ucGoodsType()
        {
            InitializeComponent();
            (new GoodsType()).ListType(this.lvType);
        }

        public bool Save()
        {
            if (this.txtType.Text.Trim().Length == 0)
                return false;

            GoodsType u = new GoodsType();
            u.TypeName = this.txtType.Text.Trim();
            if (u.Save())
            {
                this.lvType.Items.Add(new ListViewItem(new string[] { Convert.ToString(this.lvType.Items.Count + 1).PadLeft(3, ' '), u.TypeName }) { Tag = u.TypeNO });
                this.txtType.Text = string.Empty;
                return true;
            }
            return false;
        }

        public bool Delete()
        {
            if (this.lvType.SelectedItems == null || this.lvType.SelectedItems.Count < 1)
                return false;

            GoodsType u = new GoodsType();
            u.TypeNO = Convert.ToInt32(this.lvType.SelectedItems[0].Tag.ToString());
            if (u.Delete())
            {
                this.lvType.Items.Remove(this.lvType.SelectedItems[0]);
                this.txtType.Text = string.Empty;
                return true;
            }
            return false;
        }

        public bool Modify()
        {
            if (this.lvType.SelectedItems == null || this.lvType.SelectedItems.Count < 1 || 
                this.txtType.Text.Trim().Length == 0)
                return false;

            GoodsType u = new GoodsType();
            u.TypeNO = Convert.ToInt32(this.lvType.SelectedItems[0].Tag.ToString());
            u.TypeName = this.txtType.Text.Trim();
            if (u.Update())
            {
                this.lvType.SelectedItems[0].SubItems[1].Text = u.TypeName;
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
            get { return "商品类别"; }//商品单位供应商类别商品类别店铺信息其它信息
        }
        private void lvType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvType.SelectedItems == null || this.lvType.SelectedItems.Count < 1)
                return;
            this.txtType.Text = this.lvType.SelectedItems[0].SubItems[1].Text;
        }
    }
}
