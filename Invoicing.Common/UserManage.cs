using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Invoicing.Common;


namespace Invoicing.Common
{
    public partial class UserManage : Form,IOutput
    {
        public UserManage()
        {
            InitializeComponent();
        }
        
        private bool CheckData(OperationType operation)
        {            
            if (this.txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this.ParentForm, "请输入用户名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (operation == OperationType.Add && this.txtPW.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this.ParentForm, "请输入密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (operation == OperationType.Add && this.txtRePW.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this.ParentForm, "请输入重复密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (operation == OperationType.Add && this.txtRePW.Text.Trim() != this.txtPW.Text.Trim())
            {
                MessageBox.Show(this.ParentForm, "密码与重复密码必须相同！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            
            if (operation == OperationType.Add)
            {
                if ((new SystemUser()).ExistUser(this.txtUsername.Text.Trim()))
                {
                    MessageBox.Show(this.ParentForm, "此用户已经存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else if (operation == OperationType.Modify)
            {
                SystemUser su = new SystemUser();
                if (su.ExistUser(Convert.ToInt32(this.lvUser.SelectedItems[0].Tag.ToString()),this.txtUsername.Text.Trim()))
                {
                    MessageBox.Show(this.ParentForm, "此用户已经存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckData(OperationType.Add) == false)
                return;
            SystemUser su = new SystemUser();

            su.Username = this.txtUsername.Text.Trim();
            su.PW = this.txtPW.Text.Trim();            
            su.Purchas = this.cbPurchas.Checked;
            su.SellDay = this.cbSell.Checked ? (this.rbSellAll.Checked ? 0 : (this.rbSellSomedays.Checked ? 5 : 1)) : -1;
            su.Stock = this.cbStock.Checked;
            su.Usermanage = this.cbUser.Checked;
            su.Providers = this.cbProvider.Checked;
            su.SystemSet = this.cbSystemSet.Checked;
            su.CancelSell = this.cbSell.Checked ? this.cbCancelSell.Checked : this.cbSell.Checked;
            su.DeleteSell = this.cbSell.Checked ? this.cbDeleteSell.Checked : this.cbSell.Checked;
            su.SellInprice = this.cbSell.Checked ? this.cbSellInprice.Checked : this.cbSell.Checked;
            su.Record = this.cbRecord.Checked;
            su.ShowProfit = this.cbShowProfit.Checked;
            su.Remarks = this.txtRemarks.Text.Trim();
            if (su.Add())
            {
                this.lvUser.Items.Add(new ListViewItem(new string[] { 
                    su.Username, 
                    su.Purchas ? "√" : "×",                      
                    su.SellDay == -1 ? "×" : (su.SellDay == 0 ? "√" : su.SellDay.ToString()),
                    su.Stock ? "√" : "×", 
                    su.Usermanage ? "√" : "×", 
                    su.Providers ? "√" : "×", 
                    su.SystemSet ? "√" : "×", 
                    su.CancelSell ? "√" : "×", 
                    su.DeleteSell ? "√" : "×", 
                    su.Record ? "√" : "×",
                    su.ShowProfit ? "√" : "×",
                    su.SellInprice ? "√" : "×",
                    su.Remarks }) { Tag = su.UserNO });
                    
            }
            else
            {
                MessageBox.Show(this.ParentForm, "用户添加失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (CheckData(OperationType.Modify) == false)
                return;
            SystemUser su = new SystemUser(Convert.ToInt32(this.lvUser.SelectedItems[0].Tag.ToString()));

            su.Username = this.txtUsername.Text.Trim();
            //su.PW = this.txtPW.Text.Trim();
            su.Remarks = this.txtRemarks.Text.Trim();
            su.Purchas = this.cbPurchas.Checked;
            su.SellDay = this.cbSell.Checked ? (this.rbSellAll.Checked ? 0 : (this.rbSellSomedays.Checked ? 5 : 1)) : -1;
            su.Stock = this.cbStock.Checked;
            su.Usermanage = this.cbUser.Checked;
            su.Providers = this.cbProvider.Checked;
            su.SystemSet = this.cbSystemSet.Checked;
            su.CancelSell = this.cbSell.Checked ? this.cbCancelSell.Checked : this.cbSell.Checked;
            su.DeleteSell = this.cbSell.Checked ? this.cbDeleteSell.Checked : this.cbSell.Checked;
            su.ShowProfit = this.cbShowProfit.Checked;
            su.Record = this.cbRecord.Checked;
            su.SellInprice = this.cbSellInprice.Checked;
            if (su.Modify())
            {
                this.lvUser.SelectedItems[0].SubItems[0].Text = su.Username;
                this.lvUser.SelectedItems[0].SubItems[1].Text = su.Purchas ? "√" : "×";
                this.lvUser.SelectedItems[0].SubItems[2].Text = su.SellDay != -1 ? (su.SellDay == 0 ? "√" : su.SellDay.ToString()) : "×";
                this.lvUser.SelectedItems[0].SubItems[3].Text = su.Stock ? "√" : "×";
                this.lvUser.SelectedItems[0].SubItems[4].Text = su.Usermanage ? "√" : "×";

                this.lvUser.SelectedItems[0].SubItems[5].Text = su.Providers ? "√" : "×";
                this.lvUser.SelectedItems[0].SubItems[6].Text = su.SystemSet ? "√" : "×";
                this.lvUser.SelectedItems[0].SubItems[7].Text = su.CancelSell ? "√" : "×";
                this.lvUser.SelectedItems[0].SubItems[8].Text = su.DeleteSell ? "√" : "×";
                this.lvUser.SelectedItems[0].SubItems[9].Text = su.Record ? "√" : "×";

                this.lvUser.SelectedItems[0].SubItems[10].Text = su.ShowProfit ? "√" : "×";
                this.lvUser.SelectedItems[0].SubItems[11].Text = su.SellInprice ? "√" : "×";
                this.lvUser.SelectedItems[0].SubItems[12].Text = su.Remarks;

                MessageBox.Show(this.ParentForm, "用户修改成功!\r\n用户修改时不修改用户密码，要修改用户密码请以此用户登录，用工具栏“密码”功能来修改密码！", 
                    "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this.ParentForm, "用户修改失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lvUser.SelectedItems == null || this.lvUser.SelectedItems.Count < 1)
            {
                MessageBox.Show(this.ParentForm, "你选择一个用户！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show(this.ParentForm, "选择的用户将被删除,请确认！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == System.Windows.Forms.DialogResult.Cancel)
                return;

            SystemUser su = new SystemUser(Convert.ToInt32(this.lvUser.SelectedItems[0].Tag.ToString()));
            if (su.Delete())
            {
                this.lvUser.Items.Remove(this.lvUser.SelectedItems[0]);
                this.txtUsername.Text = string.Empty;

                this.cbPurchas.Checked = false;
                this.rbSellToday.Checked = false;
                this.cbStock.Checked = false;

                this.cbUser.Checked = false;
                this.cbProvider.Checked = false;
                this.cbSystemSet.Checked = false;
                this.cbCancelSell.Checked = false;
                this.cbDeleteSell.Checked = false;
                this.cbRecord.Checked = false;
                this.cbShowProfit.Checked = false;

                this.cbCancelSell.Enabled = false;
                this.cbDeleteSell.Enabled = false;
                this.cbSellInprice.Enabled = false;
                this.panelSell.Enabled = false;

                this.txtRemarks.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(this.ParentForm, "用户删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void UserManage_Load(object sender, EventArgs e)
        {
            SystemUser.ListUser(this.lvUser);
        }

        private void lvUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvUser.SelectedItems == null || this.lvUser.SelectedItems.Count < 1)
            {
                return;
            }
           this.txtUsername.Text = this.lvUser.SelectedItems[0].SubItems[0].Text;

           this.cbPurchas.Checked = this.lvUser.SelectedItems[0].SubItems[1].Text == "√";

           this.cbSell.Checked = this.lvUser.SelectedItems[0].SubItems[2].Text != "×";
           this.panelSell.Enabled = this.cbSell.Checked;
           if (this.lvUser.SelectedItems[0].SubItems[2].Text == "√")
           {               
               this.rbSellAll.Checked = true;
           }
           else if (this.lvUser.SelectedItems[0].SubItems[2].Text == "1")
           {
               this.rbSellToday.Checked = true;
           }
           else
           {
               this.rbSellSomedays.Checked = true;
           }
           this.cbStock.Checked = this.lvUser.SelectedItems[0].SubItems[3].Text == "√";
           this.cbUser.Checked = this.lvUser.SelectedItems[0].SubItems[4].Text == "√";

           this.cbProvider.Checked = this.lvUser.SelectedItems[0].SubItems[5].Text == "√";
           this.cbSystemSet.Checked = this.lvUser.SelectedItems[0].SubItems[6].Text == "√";

           this.cbCancelSell.Checked = this.lvUser.SelectedItems[0].SubItems[7].Text == "√";
           this.cbDeleteSell.Checked = this.lvUser.SelectedItems[0].SubItems[8].Text == "√";
           this.cbRecord.Checked = this.lvUser.SelectedItems[0].SubItems[9].Text == "√";

           this.cbShowProfit.Checked = this.lvUser.SelectedItems[0].SubItems[10].Text == "√";
           this.cbSellInprice.Checked = this.lvUser.SelectedItems[0].SubItems[11].Text == "√";
           this.txtRemarks.Text = this.lvUser.SelectedItems[0].SubItems[12].Text;

           this.txtPW.Text = string.Empty;
           this.txtRePW.Text = string.Empty;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        public void Output()
        {
            Foundation.OutputCSV(this.lvUser, "用户" + System.DateTime.Now.ToString("yyyyMMddHHssmm") + ".csv");
        }

        private void cbSell_CheckedChanged(object sender, EventArgs e)
        {
            this.panelSell.Enabled = cbSell.Checked;
            this.cbCancelSell.Enabled = cbSell.Checked;
            this.cbDeleteSell.Enabled = cbSell.Checked;
            this.cbSellInprice.Enabled = cbSell.Checked;
            if (!cbSell.Checked)
            {
                this.cbCancelSell.Checked = false;
                this.cbDeleteSell.Checked = false;
                this.cbSellInprice.Checked = false;
            }
            
        }
    }
}
