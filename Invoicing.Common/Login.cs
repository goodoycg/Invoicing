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
    public partial class Login : Form
    {//http://www.newseasoft.com/un_class.asp?id=85
        public SystemUser _SystemUser { get; set; }
        private CurrentState m_CurrentState = CurrentState.Login;
        public CurrentState _CurrentState { get { return m_CurrentState; } set { m_CurrentState = value; } }
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }                

        private void Login_Activated(object sender, EventArgs e)
        {
            this.txtUsername.Focus();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtPW.Focus();
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnLogin_Click(null, null);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {////admin 12345
            if (this.txtUsername.Text.Trim() == string.Empty || this.txtPW.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this,"请输入用户名和密码！","警告",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                if (this.txtUsername.Text.Trim() == string.Empty)
                {
                    this.txtUsername.Focus();
                }
                else
                {
                    this.txtPW.Focus();
                }
                return;
            }
            
            SystemUser User = new SystemUser(this.txtUsername.Text.Trim(),this.txtPW.Text.Trim());
            if (User.Login())
            {
                this.DialogResult = DialogResult.OK;                
                this._SystemUser = User;
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "用户名或密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
