using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Invoicing.Common
{
    public partial class ucOther : UserControl,ISystemSet
    {
        public ucOther()
        {
            InitializeComponent();
        }
        public bool Save()
        {
            return false;
        }

        public bool Modify()
        {//
           
            bool b2 = Foundation.RunSql("update otherinfo set itemvalue='" + (this.cbSell2Print.Checked ? "1" : "0") + "' where itemname='Sell2Print'");

            OleDbConnection conn = Foundation.CreateInstance();
            string strSql = "update otherinfo set itemvalue=@itemvalue where itemname='Notethings'";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@itemvalue", this.txtNotethings.Text.Trim());

            bool b3 = Foundation.RunSql(@"update otherinfo set itemvalue='" + this.txtBackupDir.Text + "' where itemname='backup'");

           return b3 && b2 && cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete()
        {
            return false;
        }

        public void LoadData()
        {
            DataSet ds = Foundation.OtherInfo();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if ("Sell2Print" == dr["itemname"].ToString())
                {
                    this.cbSell2Print.Checked = dr["itemvalue"].ToString() == "1";
                }
                else if("Notethings" == dr["itemname"].ToString())
                {
                    this.txtNotethings.Text = dr["itemvalue"].ToString();
                }
                else if ("backup" == dr["itemname"].ToString())
                {
                    this.txtBackupDir.Text = dr["itemvalue"].ToString();
                }
            }
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
            get { return "其它信息"; }
        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.ShowNewFolderButton = true;
            if (f.ShowDialog(this.ParentForm) == DialogResult.OK)
            {
                this.txtBackupDir.Text = Foundation.PathAdd(f.SelectedPath);
            }
        }
    }
}
