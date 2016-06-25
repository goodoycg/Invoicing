using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Invoicing.Common;


namespace Invoicing.Other
{
    public partial class frmRecording : Form
    {
        public frmRecording()
        {
            InitializeComponent();
        }
        public IOutput IOutput
        {
            get { return m_Recording; }
        }

        ucRecording m_Recording;
        
        private void frmRecording_Load(object sender, EventArgs e)
        {
            if (m_Recording == null)
            {
                m_Recording = new ucRecording();               
                m_Recording.Dock = DockStyle.Fill;
                this.Controls.Add(m_Recording);
               
            }
        }

        void tvDatetime_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
    }
}
