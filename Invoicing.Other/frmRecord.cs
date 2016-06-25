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
    public partial class frmRecord : Form
    {
        OperationType m_OperationType;
        string m_RecordNO;
        public frmRecord(OperationType _OperationType, string RecordNO)
        {
            InitializeComponent();
            m_OperationType = _OperationType;
            m_RecordNO = RecordNO;
            this.tabControl1.TabPages[0].Text = m_OperationType == OperationType.Add ? "增加" : "修改";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtOperman.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this.ParentForm, "请输入经办人！", "提示", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (this.numCharge.Value == 0)
            {
                MessageBox.Show(this.ParentForm, "请输入费用！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (m_OperationType == OperationType.Add)
            {
                Recording r = new Recording();
                r.RecordDateTime = this.dtpDataTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
                r.Charge = this.numCharge.Value;
                r.Operman = this.txtOperman.Text.Trim();
                r.Remarks = this.txtRemarks.Text.Trim();
                if (r.Save())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(this.ParentForm, "添加费用失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (m_OperationType == OperationType.Modify)
            {
                Recording r = new Recording();
                r.RecordDateTime = this.dtpDataTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
                r.RecordNO = Convert.ToInt32(this.m_RecordNO);
                r.Charge = this.numCharge.Value;
                r.Operman = this.txtOperman.Text.Trim();
                r.Remarks = this.txtRemarks.Text.Trim();
                if (r.Update())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(this.ParentForm, "修改费用失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void frmRecord_Load(object sender, EventArgs e)
        {
            if (m_OperationType == OperationType.Modify)
            {
                Recording r = new Recording();
                r.Query(Convert.ToInt32(m_RecordNO));
                this.dtpDataTime.Value = Convert.ToDateTime(r.RecordDateTime);
                this.numCharge.Value = r.Charge;
                this.txtOperman.Text = r.Operman;
                this.txtRemarks.Text = r.Remarks;
            }
        }
    }
}
