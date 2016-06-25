using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Invoicing.Common;

namespace Invoicing.Sell
{
    public partial class ucLatelySell : UserControl
    {
        SystemUser m_SystemUser;
        public ucLatelySell(SystemUser _SystemUser)
        {
            InitializeComponent();
            m_SystemUser = _SystemUser;
        }

        public void LoadLatelySell()
        {
            DataSet ds = Foundation.LatelyAllSell(m_SystemUser.SellDay);
            this.LatelySellTree.Nodes.Clear();
            TreeNode tnall = new TreeNode("最近销售") { Tag = "0" };                           
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                tnall.Nodes.Add(new TreeNode(dr["outtime"].ToString()) { Tag = string.Empty });                   
            }            
            this.LatelySellTree.Nodes.Add(tnall);

            //if (this.LatelySellTree.Nodes[0].Nodes.Count > 0)
            //{
            //    this.LatelySellTree.SelectedNode = this.LatelySellTree.Nodes[0].Nodes[0];
            //}
            //else
            //{
            //    this.LatelySellTree.SelectedNode = this.LatelySellTree.Nodes[0];
            //}
            //this.LatelySellTree.Nodes[0].Collapse(false);
        }
    }
}
