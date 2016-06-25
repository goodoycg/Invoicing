using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Invoicing.Common;

namespace Invoicing.Stock
{
    public partial class frmStock : Form
    {
        ucStock m_Stock;
        SystemUser m_SystemUser;
        public frmStock(SystemUser _SystemUser)
        {
            InitializeComponent();
            m_SystemUser = _SystemUser;
            m_Stock = new ucStock(m_SystemUser);
            m_Stock.Dock = DockStyle.Fill;
            this.Controls.Add(m_Stock);
        }
        public IOutput IOutput
        {
            get { return m_Stock; }
        }
        public ISearchGoods ISearchGood
        {
            get { return m_Stock; }
        }
        
        private void frmStock_Load(object sender, EventArgs e)
        {  
            m_Stock.LoadStockGoods();
            m_Stock.RefreshChart();
        }
    }
}
