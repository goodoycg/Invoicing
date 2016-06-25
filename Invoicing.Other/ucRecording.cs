using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Invoicing.Common;

namespace Invoicing.Other
{
    public partial class ucRecording : UserControl,IOutput
    {
        public ucRecording()
        {
            InitializeComponent();
        }

        public void Output()
        {
            Foundation.OutputCSV(this.lvRecording, "记帐" + System.DateTime.Now.ToString("yyyyMMddHHssmm") + ".csv");
        }
        ucDateTime m_DataTime;
        private void ucRecording_Load(object sender, EventArgs e)
        {
            if (m_DataTime == null)
            {
                m_DataTime = new ucDateTime();
                m_DataTime.Dock = DockStyle.Fill;
                m_DataTime.DatetimeChanged += new EventHandler<DatetimeTreeEventArgs>(m_DataTime_DatetimeChanged);
                this.panelLeft.Controls.Add(m_DataTime);
            }
        }

        string m_DataTimeString;
        void m_DataTime_DatetimeChanged(object sender, DatetimeTreeEventArgs e)
        {
            m_DataTimeString = e.DatatimeString;
            LoadData(m_DataTimeString);           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRecord f = new frmRecord(OperationType.Add, "0");
            if (f.ShowDialog(this.ParentForm) == DialogResult.OK)
            {
                LoadData(m_DataTimeString);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lvRecording.SelectedItems == null || this.lvRecording.SelectedItems.Count < 1)
                return;
            frmRecord f = new frmRecord(OperationType.Modify,this.lvRecording.SelectedItems[0].Tag.ToString());
            if (f.ShowDialog(this.ParentForm) == DialogResult.OK)
            {
                LoadData(m_DataTimeString);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvRecording.SelectedItems == null || this.lvRecording.SelectedItems.Count < 1)
                return;
            DialogResult dr = MessageBox.Show(this.ParentForm, "将删除所选择的记帐数据，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                Recording r = new Recording();
                r.RecordNO = Convert.ToInt32(this.lvRecording.SelectedItems[0].Tag.ToString());
                if (r.Delete())
                {
                    this.labelTotal_.Text = (Convert.ToDecimal(this.labelTotal_.Text) - Convert.ToDecimal(this.lvRecording.SelectedItems[0].SubItems[1].Text)).ToString();
                    this.lvRecording.Items.Remove(this.lvRecording.SelectedItems[0]);
                }
            }
        }
        
        private void LoadData(string Datetime)
        {
            DataSet ds = Foundation.ReadDataSet("select * from recording where recorddatetime like '" + Datetime + "%'");
            this.lvRecording.Items.Clear();
            decimal m_dTotal = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.lvRecording.Items.Add(new ListViewItem(new string[] {
                    dr["RecordDateTime"].ToString(),
                dr["Charge"].ToString(), 
                dr["Operman"].ToString(), 
                dr["remarks"].ToString()}) { Tag = dr["recordno"].ToString(), });
                m_dTotal += Convert.ToDecimal(dr["Charge"].ToString());
            }
            this.labelTotal_.Text = m_dTotal.ToString();
        }
    }
}
