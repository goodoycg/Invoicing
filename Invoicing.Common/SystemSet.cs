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
    public partial class SystemSet : Form
    {
        private ISystemSet m_ISystemSet;
        public event EventHandler<EventArgs> RefreshList;        
        public SystemSet()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(m_ISystemSet.Save())
            {
                MessageBox.Show(this, "增加成功!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (RefreshList != null)
                {
                    RefreshList(m_ISystemSet.SetType, e);
                }
            }
            else
            {
                MessageBox.Show(this, "增加失败!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }        
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (m_ISystemSet.Modify())
            {
                MessageBox.Show(this, "修改成功!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (RefreshList != null)
                {
                    RefreshList(m_ISystemSet.SetType, e);
                }
            }
            else
            {
                MessageBox.Show(this, "修改失败!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (m_ISystemSet.Delete())
            {
                MessageBox.Show(this, "删除成功!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (RefreshList != null)
                {
                    RefreshList(m_ISystemSet.SetType, e);
                }
            }
            else
            {
                MessageBox.Show(this, "删除失败!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }  
        }
        private ucShopInfo m_ShopInfo;
        private ucShopUnit m_ShopUnit;
        private ucProvodeType m_ProvodeType;
        private ucGoodsType m_GoodsType;
        private ucOther m_Other;
        private void treeSystemSet_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeSystemSet.SelectedNode == null)
                return;
            this.tabControl1.TabPages[0].Text = this.treeSystemSet.SelectedNode.Text;
            if (this.treeSystemSet.SelectedNode.Text == "商品单位")
            {
                if (m_ShopUnit == null)
                {
                    m_ShopUnit = new ucShopUnit();
                    m_ShopUnit.Dock = DockStyle.Fill;
                }
                m_ISystemSet = m_ShopUnit;
                panelCenter.Controls.Clear();
                panelCenter.Controls.Add(m_ShopUnit);

            }
            else if (this.treeSystemSet.SelectedNode.Text == "供应商类别")
            {
                if (m_ProvodeType == null)
                {
                    m_ProvodeType = new ucProvodeType();
                    m_ProvodeType.Dock = DockStyle.Fill;
                }
                m_ISystemSet = m_ProvodeType;
                panelCenter.Controls.Clear();
                panelCenter.Controls.Add(m_ProvodeType);
            }
            else if (this.treeSystemSet.SelectedNode.Text == "商品类别")
            {
                if (m_GoodsType == null)
                {
                    m_GoodsType = new ucGoodsType();
                    m_GoodsType.Dock = DockStyle.Fill;
                }                
                m_ISystemSet = m_GoodsType;
                panelCenter.Controls.Clear();
                panelCenter.Controls.Add(m_GoodsType);
            }
            else if (this.treeSystemSet.SelectedNode.Text == "店铺信息")
            {
                if (m_ShopInfo == null)
                {
                    m_ShopInfo = new ucShopInfo();
                    m_ShopInfo.Dock = DockStyle.Fill;
                }
                m_ShopInfo.LoadData();
                m_ISystemSet = m_ShopInfo;
                panelCenter.Controls.Clear();
                panelCenter.Controls.Add(m_ShopInfo);
            }            
            else if (this.treeSystemSet.SelectedNode.Text == "其它信息")
            {
                if (m_Other == null)
                {
                    m_Other = new ucOther();
                    m_Other.Dock = DockStyle.Fill;
                }
                m_Other.LoadData();
                m_ISystemSet = m_Other;
                panelCenter.Controls.Clear();
                panelCenter.Controls.Add(m_Other);
            }
            
            if (m_ISystemSet != null)
            {
                this.btnAdd.Enabled = m_ISystemSet.AddButton;
                this.btnModify.Enabled = m_ISystemSet.ModifyButton;
                this.btnDelete.Enabled = m_ISystemSet.DeleteButton;
            }
        }

        private void SystemSet_Load(object sender, EventArgs e)
        {
            this.treeSystemSet.SelectedNode = treeSystemSet.Nodes[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
