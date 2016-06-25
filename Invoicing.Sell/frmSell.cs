using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Invoicing.Common;

namespace Invoicing.Sell
{
    public partial class frmSell : Form
    {
        private SystemUser m_SystemUser;
        ucSell m_Sell;
        public frmSell(SystemUser _SystemUser)
        {
            InitializeComponent();
            m_SystemUser =_SystemUser;
            
            m_Sell = new ucSell(this.m_SystemUser);
            this.m_Sell.InitTree();
            this.m_Sell.LatelySell();
            m_Sell.Dock = DockStyle.Fill;
            this.Controls.Add(m_Sell);
            
        }
        public IOutput IOutput
        {
            get { return m_Sell; }
        }
        public ISearchGoods ISearchGood
        {
            get { return m_Sell; }
        }
    }
}
