using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Invoicing.Common;

namespace Invoicing.Purchas
{
    public partial class frmPurchas : Form
    {
        ucPurchas m_Purchas;
        SystemUser m_SystemUser;
        public frmPurchas(SystemUser _SystemUser)
        {
            InitializeComponent();
            m_SystemUser = _SystemUser;
            m_Purchas = new ucPurchas(m_SystemUser);
            this.m_Purchas.InitTree();
            m_Purchas.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(m_Purchas);
            m_Purchas.PurchasChanged += new EventHandler<EventArgs>(m_Purchas_PurchasChanged);
        }
        public IOutput IOutput
        {
            get { return m_Purchas; }
        }
        public ISearchGoods ISearchGood
        {
            get { return m_Purchas; }
        }
        
        void m_Purchas_PurchasChanged(object sender, EventArgs e)
        {
            
        }

        private void frmPurchas_Load(object sender, EventArgs e)
        {
            m_Purchas.RefreshChart();
        }
        
    }
}
