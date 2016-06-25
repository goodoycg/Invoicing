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
    public partial class ModifyPW : Form
    {
        public SystemUser _SystemUser { get; set; }
        public ModifyPW()
        {
            InitializeComponent();
        }        

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtOldpw.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this,"请输入旧密码！","提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtOldpw.Focus();
                return;
            }
            if (this.txtnewpw.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this,"请输入新密码！","提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtnewpw.Focus();
                return;
            }
            if (this.txtnewpw2.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this,"请再次输入新密码！","提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtnewpw2.Focus();
                return;
            }
            if (this.txtnewpw.Text.Trim() != this.txtnewpw2.Text.Trim())
            {
                MessageBox.Show(this,"两次输入的新密码不相同，请再次输入！","提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtnewpw.Focus();
                return;
            }

            if (this._SystemUser.ResetPW(this.txtOldpw.Text.Trim(), this.txtnewpw.Text.Trim()))
            {
                MessageBox.Show(this, "密码修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
