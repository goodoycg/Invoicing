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
    public partial class ucProviders : UserControl, IOutput
    {
        public event EventHandler<EventArgs> RefreshListProviders;   
        public ucProviders()
        {
            InitializeComponent();
        }

        public void LoadProviders()
        {
            Providers.ListProviders(this.lvProviders);
        }
        public void RefreshListProvidersType()
        {
            Providers.LoadProviderType(this.cbbType);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtProviderName.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this.ParentForm, "请输入供应商名称！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (this.cbbType.Items.Count == 1 || this.cbbType.SelectedItem == null || this.cbbType.SelectedIndex == this.cbbType.Items.Count - 1)
            {
                MessageBox.Show(this.ParentForm, "请选择或设置好类别！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Providers p = new Providers();

            p.Address = this.txtAddress.Text.Trim();
            p.Code = this.txtCode.Text.Trim();
            p.Email = this.txtEmail.Text.Trim();
            p.Fax = this.txtFax.Text.Trim();
            p.Header = this.txtHeader.Text.Trim();

            p.ProviderName = this.txtProviderName.Text.Trim();
            p.ProviderType = Convert.ToInt32((this.cbbType.SelectedItem as ComboBoxItem).Value);
            p.Remarks = this.txtRemarks.Text.Trim();
            p.Tel = this.txtTel.Text.Trim();
            p.WebSite = this.txtWebsite.Text.Trim();

            if (p.Save())
            {
                this.lvProviders.Items.Add(new ListViewItem(new string[] { Convert.ToString(this.lvProviders.Items.Count + 1),
                    p.ProviderName, 
                    (this.cbbType.SelectedItem as ComboBoxItem).Text, 
                    p.Header, 
                    p.Tel,
                    p.Email,
                    p.WebSite,
                    p.Code,
                    p.Fax,
                    p.Address,
                    p.Remarks }) { Tag = p.ProviderNO });               
                
                ClearInput();
                if (RefreshListProviders != null)
                {
                    RefreshListProviders(null, null);
                }
            }
            else
            {
                MessageBox.Show(this.ParentForm, "供应商添加失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ClearInput()
        {
            this.txtAddress.Text = string.Empty;
            this.txtCode.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtFax.Text = string.Empty;
            this.txtHeader.Text = string.Empty;

            this.txtProviderName.Text = string.Empty;
            this.txtRemarks.Text = string.Empty;
            this.txtTel.Text = string.Empty;
            this.txtWebsite.Text = string.Empty;
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (this.txtProviderName.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this.ParentForm, "请输入供应商名称！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (this.cbbType.Items.Count == 1 || this.cbbType.SelectedItem == null || this.cbbType.SelectedIndex == this.cbbType.Items.Count - 1)
            {
                MessageBox.Show(this.ParentForm, "请选择或设置好类别！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Providers p = new Providers();

            p.ProviderNO = Convert.ToInt32(this.lvProviders.SelectedItems[0].Tag.ToString());

            p.Address = this.txtAddress.Text.Trim();
            p.Code = this.txtCode.Text.Trim();
            p.Email = this.txtEmail.Text.Trim();
            p.Fax = this.txtFax.Text.Trim();
            p.Header = this.txtHeader.Text.Trim();

            p.ProviderName = this.txtProviderName.Text.Trim();
            p.ProviderType = Convert.ToInt32((this.cbbType.SelectedItem as ComboBoxItem).Value);
            p.Remarks = this.txtRemarks.Text.Trim();
            p.Tel = this.txtTel.Text.Trim();
            p.WebSite = this.txtWebsite.Text.Trim();

            if (p.Update())
            {
                int i = 1;
                this.lvProviders.SelectedItems[0].SubItems[i++].Text = p.ProviderName;
                this.lvProviders.SelectedItems[0].SubItems[i++].Text = (this.cbbType.SelectedItem as ComboBoxItem).Text; 
                this.lvProviders.SelectedItems[0].SubItems[i++].Text = p.Header; 
                this.lvProviders.SelectedItems[0].SubItems[i++].Text = p.Tel; 
                this.lvProviders.SelectedItems[0].SubItems[i++].Text = p.Email; 

                this.lvProviders.SelectedItems[0].SubItems[i++].Text = p.WebSite; 
                this.lvProviders.SelectedItems[0].SubItems[i++].Text = p.Code; 
                this.lvProviders.SelectedItems[0].SubItems[i++].Text = p.Fax; 
                this.lvProviders.SelectedItems[0].SubItems[i++].Text = p.Address; 
                this.lvProviders.SelectedItems[0].SubItems[i++].Text = p.Remarks;


                if (RefreshListProviders != null)
                {
                    RefreshListProviders(null, null);
                }
            }
            else
            {
                MessageBox.Show(this.ParentForm, "供应商修改失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {//供应商对应的进货
            if (this.lvProviders.SelectedItems == null || this.lvProviders.SelectedItems.Count < 1)
            {
                MessageBox.Show(this.ParentForm, "请选择要删除的供应商！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show(this.ParentForm, "所选择的供应商将被删除，请确认！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr != DialogResult.OK)
            {
                return;
            }
            Providers p = new Providers();
            p.ProviderNO = Convert.ToInt32(this.lvProviders.SelectedItems[0].Tag.ToString());
            if (p.Delete())
            {
                this.lvProviders.Items.Remove(this.lvProviders.SelectedItems[0]);

                if (RefreshListProviders != null)
                {
                    RefreshListProviders(null, null);
                }
            }
            else
            {
                MessageBox.Show(this.ParentForm, "供应商删除失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ucProviders_Load(object sender, EventArgs e)
        {//ComboBoxItem
             Providers.LoadProviderType(this.cbbType);
            
        }
        public void Output()
        {
            Foundation.OutputCSV(this.lvProviders, "供应商" + System.DateTime.Now.ToString("yyyyMMddHHssmm") + ".csv");
        }
               

        private void lvProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProviders.SelectedItems == null || this.lvProviders.SelectedItems.Count < 1)
                return;
            int iIndex = 1;
            this.txtProviderName.Text = this.lvProviders.SelectedItems[0].SubItems[iIndex++].Text;

            this.cbbType.SelectedIndex = this.cbbType.FindString(this.lvProviders.SelectedItems[0].SubItems[iIndex++].Text);

            this.txtHeader.Text = this.lvProviders.SelectedItems[0].SubItems[iIndex++].Text;
            this.txtTel.Text = this.lvProviders.SelectedItems[0].SubItems[iIndex++].Text;

            this.txtEmail.Text = this.lvProviders.SelectedItems[0].SubItems[iIndex++].Text;
            this.txtWebsite.Text = this.lvProviders.SelectedItems[0].SubItems[iIndex++].Text;
            this.txtCode.Text = this.lvProviders.SelectedItems[0].SubItems[iIndex++].Text;
            this.txtFax.Text = this.lvProviders.SelectedItems[0].SubItems[iIndex++].Text;

            this.txtAddress.Text = this.lvProviders.SelectedItems[0].SubItems[iIndex++].Text;
            this.txtRemarks.Text = this.lvProviders.SelectedItems[0].SubItems[iIndex++].Text;
        }
    }
}
