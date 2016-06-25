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
    public partial class ucShopInfo : UserControl, ISystemSet
    {
        public ucShopInfo()
        {
            InitializeComponent();
            
        }
        private ShopInfo s;
        public void LoadData()
        {
            s = new ShopInfo();
            this.txtShopname.Text = s.Shopname;
            this.txtShopaddress.Text = s.Shopaddress;
            this.txtShoptel.Text = s.Shoptel;

        }

        public bool Save()
        {
            return false;
        }

        public bool Modify()
        {
            s.Shopname = this.txtShopname.Text.Trim();
            s.Shoptel = this.txtShoptel.Text.Trim();
            s.Shopaddress = this.txtShopaddress.Text.Trim();
            if(s.Update())
            {
                MessageBox.Show(this.ParentForm, "店铺信息设置成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        public bool Delete()
        {
            return false;
        }
        public bool AddButton
        {
            get { return false; }
        }

        public bool ModifyButton
        {
            get { return true; }
        }

        public bool DeleteButton
        {
            get { return false; }
        }
        public string SetType
        {
            get { return "店铺信息"; }//供应商类别商品类别其它信息
        }
    }
}
