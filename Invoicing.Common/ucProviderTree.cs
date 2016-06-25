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
    public partial class ucProviderTree : UserControl
    {
        public ucProviderTree()
        {
            InitializeComponent();
        }

        public void LoadProvider()
        {
            Providers.ListProviders(this.ProviderTree);
        }
    }
}
