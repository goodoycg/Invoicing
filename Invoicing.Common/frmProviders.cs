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
    public partial class frmProviders : Form
    {
        public frmProviders()
        {
            InitializeComponent();
        }
        public IOutput IOutput
        {
            get { return m_Providers; }
        }
        ucProviders m_Providers;
        private void frmProviders_Load(object sender, EventArgs e)
        {            
            if (m_Providers == null)
            {
                m_Providers = new ucProviders();
                m_Providers.RefreshListProviders += new EventHandler<EventArgs>(m_Providers_RefreshListProviders);
                m_Providers.Dock = DockStyle.Fill;
                this.Controls.Add(m_Providers);
            }           

            m_Providers.LoadProviders();
        }
        void m_Providers_RefreshListProviders(object sender, EventArgs e)
        {
            //this.m_Purchas.RefreshListProviders();
        }
        public void RefreshListProvidersType()
        {
            m_Providers.RefreshListProvidersType();
        }
    }
}
