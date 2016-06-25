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
    public partial class ucProvodeType : UserControl, ISystemSet
    {
        public ucProvodeType()
        {
            InitializeComponent();
            Providers.LoadProviderType(this.lvType);
        }       

        public bool Save()
        {
            if (this.txtType.Text.Trim() == string.Empty)
            {
                return false;
            }
            int iR = Providers.AddProviderType(this.txtType.Text.Trim());
            if (iR > 0)
            {
                this.lvType.Items.Add(new ListViewItem(new string[] { Convert.ToString(this.lvType.Items.Count + 1).PadLeft(3, ' '), this.txtType.Text.Trim() }) { Tag = iR });
                this.txtType.Text = string.Empty;
                return true;
            }
            return false;
        }

        public bool Modify()
        {
            if (this.txtType.Text.Trim() == string.Empty)
            {
                return false;
            }
            if (this.lvType.SelectedItems == null || this.lvType.SelectedItems.Count == 0)
            {
                return false;
            }
            if (Providers.ModifyProviderType(this.lvType.SelectedItems[0].Tag.ToString(), this.txtType.Text.Trim()))
            {
                this.lvType.SelectedItems[0].SubItems[1].Text = this.txtType.Text.Trim();
                this.txtType.Text = string.Empty;
                return true;
            }
            return false;
        }

        public bool Delete()
        {
            if (this.lvType.SelectedItems == null || this.lvType.SelectedItems.Count == 0)
            {
                return false;
            }

            if (Providers.DeleteProviderType(this.lvType.SelectedItems[0].Tag.ToString()))
            {
                this.lvType.Items.Remove(this.lvType.SelectedItems[0]);
                this.txtType.Text = string.Empty;
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
            get { return "供应商类别"; }//其它信息
        }
        private void lvType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvType.SelectedItems == null || this.lvType.SelectedItems.Count == 0)
            {
                return ;
            }
            this.txtType.Text = this.lvType.SelectedItems[0].SubItems[1].Text;
        }
       
    }
}
