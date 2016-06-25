using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Invoicing.Common;
using Invoicing.Stock;
using Invoicing.Sell;
using Invoicing.Purchas;
using Invoicing.Other;
using Invoicing.Update;

namespace Invoicing
{
    public partial class mainFrame : Form
    {
        #region 变量
        private IOutput m_iOutput = null;
        private Splash SplashForm;
        //private Thread thSplash;
        public bool _IsShow { get; set; }
        public SystemUser _SystemUser { get; set; }
        public ISearchGoods _SearchGood { get; set; }
        #endregion

        #region 构造函数
        public mainFrame()
        {
            InitializeComponent();

            Login frmLogin = new Login();
            if (frmLogin.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
            {
                this._IsShow = false;
                return;
            }
            this._IsShow = true;
            this._SystemUser = frmLogin._SystemUser;
            CheckRight(this._SystemUser);
            //thSplash = new Thread(new ThreadStart(ShowSplashForm));
            //thSplash.Start();
        }
        #endregion

        #region 窗体加载与关闭
        private void mainFrame_Load(object sender, EventArgs e)
        {
            this.tsslStaartTime.Text = "系统开始时间：" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");            
            //if (thSplash != null)
            //{
            //    thSplash.Abort();
            //    thSplash = null;
            //} 
            UpdateDB db = new UpdateDB();
            db.Updateed += new EventHandler((s2, e2) => { tsslAppVer.Text = s2.ToString(); });
            db.Update();
            tsslAppVer.Text = "I-SOFT 版本 " + db.AppVer.ToString();
        }
        private void mainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateDB db = new UpdateDB();
            db.BackupDB();
        }
        #endregion
        
        #region 记账
        frmRecording m_frmRecodrd = null;
        private void tsbRecording_Click(object sender, EventArgs e)
        {
            if (m_frmRecodrd == null || m_frmRecodrd.IsDisposed)
            {
                m_frmRecodrd = new frmRecording();
                m_frmRecodrd.MdiParent = this;
            }
            m_frmRecodrd.Visible = false;
            m_frmRecodrd.Activate();
            m_frmRecodrd.WindowState = FormWindowState.Maximized;
            m_frmRecodrd.Show();
            this.tsslCurrent.Text = "当前操作：记账";//
            m_iOutput = m_frmRecodrd.IOutput;
            this._SearchGood = null;
        }
        #endregion

        #region 查找
        private void tsbSearch_Click(object sender, EventArgs e)
        {
            if (this._SearchGood != null)
            {
                this._SearchGood.Search();
            }            
        }
        #endregion

        #region 进货
        frmPurchas m_frmPurchas = null;
        private void tsbPurchas_Click(object sender, EventArgs e)
        {
            if (m_frmPurchas == null || m_frmPurchas.IsDisposed)
            {
                m_frmPurchas = new frmPurchas(this._SystemUser);
                m_frmPurchas.MdiParent = this;                
            }
            this._SearchGood = m_frmPurchas.ISearchGood;
            m_frmPurchas.Visible = false;
            m_frmPurchas.Activate();
            m_frmPurchas.WindowState = FormWindowState.Maximized;
            m_frmPurchas.Show();
            this.tsslCurrent.Text = "当前操作：进货管理";//
            m_iOutput = m_frmPurchas.IOutput;
            
        }
        #endregion

        #region 销售
        frmSell m_frmSell;
        private void tsbSell_Click(object sender, EventArgs e)
        {
            if (m_frmSell == null || m_frmSell.IsDisposed)
            {
                m_frmSell = new frmSell(_SystemUser);
                m_frmSell.MdiParent = this;                
            }
            this._SearchGood = m_frmSell.ISearchGood;
            m_frmSell.Visible = false;
            m_frmSell.Activate();
            m_frmSell.WindowState = FormWindowState.Maximized;
            m_frmSell.Show();
            this.tsslCurrent.Text = "当前操作：销售管理";
            m_iOutput = m_frmSell.IOutput;
        }
        #endregion

        #region 库存
        frmStock m_frmStock;
        private void tsbStock_Click(object sender, EventArgs e)
        {
            if (m_frmStock == null || m_frmStock.IsDisposed)
            {
                m_frmStock = new frmStock(this._SystemUser);
                m_frmStock.MdiParent = this;                
            }
            this._SearchGood = m_frmStock.ISearchGood;
            m_frmStock.Visible = false;
            m_frmStock.Activate();
            m_frmStock.WindowState = FormWindowState.Maximized;
            m_frmStock.Show();
            this.tsslCurrent.Text = "当前操作：库存管理";
            m_iOutput = m_frmStock.IOutput;
        }
        #endregion

        #region 供应商
        frmProviders m_frmProviders;
        private void tsbProviders_Click(object sender, EventArgs e)
        {
            if (m_frmProviders == null || m_frmProviders.IsDisposed)
            {
                m_frmProviders = new frmProviders();
                m_frmProviders.MdiParent = this;
            }
            m_frmProviders.Visible = false;
            m_frmProviders.Activate();
            m_frmProviders.WindowState = FormWindowState.Maximized;
            m_frmProviders.Show();
            this.tsslCurrent.Text = "当前操作：供应商管理";
            m_iOutput = m_frmProviders.IOutput;
            this._SearchGood = null;
        }
        #endregion

        #region 用户
        UserManage m_frmUserManage;
        private void tsbUser_Click(object sender, EventArgs e)
        {
            if (m_frmUserManage == null || m_frmUserManage.IsDisposed)
            {
                m_frmUserManage = new UserManage();
                m_frmUserManage.MdiParent = this;
            }
            m_frmUserManage.Visible = false;
            m_frmUserManage.Activate();
            m_frmUserManage.WindowState = FormWindowState.Maximized;
            m_frmUserManage.Show();            
            this.tsslCurrent.Text = "当前操作：用户管理";
            m_iOutput = m_frmUserManage;
            this._SearchGood = null;
        }
        #endregion

        #region 图表
        private void tsbImageTable_Click(object sender, EventArgs e)
        {//tsbImageTable
            //
        }
        #endregion

        #region 关于
        private void tsbAbout_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog(this);
        }
        #endregion

        #region 导出
        private void tsbOutput_Click(object sender, EventArgs e)
        {
            if (m_iOutput == null)
                return;
            m_iOutput.Output();
        }
        #endregion

        #region 密码
        private void tsbModifyPW_Click(object sender, EventArgs e)
        {
            ModifyPW pw = new ModifyPW();
            pw._SystemUser = this._SystemUser;
            string s = this.tsslCurrent.Text;
            this.tsslCurrent.Text = "当前操作：修改密码";
            pw.ShowDialog(this);
            this.tsslCurrent.Text = s;
        }
        #endregion       

        #region 配置
        private void tsbSystemSet_Click(object sender, EventArgs e)
        {
            SystemSet s = new SystemSet();
            s.RefreshList += new EventHandler<EventArgs>(s_RefreshList);
            string str = this.tsslCurrent.Text;
            this.tsslCurrent.Text = "当前操作：系统配置";
            s.ShowDialog(this);
            this.tsslCurrent.Text = str;
        }
        #endregion

        #region 权限
        private void CheckRight(SystemUser sysUser)
        {
            this.tsbPurchas.Visible = this.tsmiPurchas.Enabled = sysUser.Purchas;
            this.tsbSell.Visible = this.tsmiSell.Enabled = sysUser.SellDay > -1;
            this.tsbStock.Visible = this.tsmiStock.Enabled = sysUser.Stock;
            this.tsbUser.Visible = this.tsmiUser.Enabled = sysUser.Usermanage;
            this.tsbProviders.Visible = this.tsmiProviders.Enabled = sysUser.Providers;
            this.tsbSystemSet.Visible = this.tsmiSystemSet.Enabled = sysUser.SystemSet;
            this.tsbRecording.Visible = this.tsmiRecording.Enabled = sysUser.Record;
            this.tsslUsername.Text = "当前用户：" + sysUser.Username;
            tssBeforeUsers.Visible = tssBeforeOutput.Visible = tssBeforeProvider.Visible = tsbOutput.Visible = sysUser.Purchas && sysUser.SellDay > -1 && sysUser.Stock && sysUser.Usermanage;
        }
        #endregion

        #region 锁定
        private void tsbLock_Click(object sender, EventArgs e)
        {            
            this.toolStripTop.Visible = false;
            this.MainMenuStrip.Visible = false;
            this.StatusBarBottom.Visible = false;

            if (m_frmPurchas != null && !m_frmPurchas.IsDisposed)
            {
                m_frmPurchas.Visible = !m_frmPurchas.Visible;
            }
            if (m_frmSell != null && !m_frmSell.IsDisposed)
            {
                m_frmSell.Visible = !m_frmSell.Visible;
            }
            if (m_frmStock != null && !m_frmStock.IsDisposed)
            {
                m_frmStock.Visible = !m_frmStock.Visible;
            }
            if (m_frmProviders != null && !m_frmProviders.IsDisposed)
            {
                m_frmProviders.Visible = !m_frmProviders.Visible;
            }            
            if (m_frmUserManage != null && !m_frmUserManage.IsDisposed)
            {
                m_frmUserManage.Visible = !m_frmUserManage.Visible;
            }
            if (m_frmRecodrd != null && !m_frmRecodrd.IsDisposed)
            {
                m_frmRecodrd.Visible = !m_frmRecodrd.Visible;
            }
            Login l = new Login();
            l._CurrentState = CurrentState.Lock;
            if (l.ShowDialog(this) == DialogResult.OK)
            {
                this.toolStripTop.Visible = true;
                this.StatusBarBottom.Visible = true;
                this.MainMenuStrip.Visible = true;

                CheckRight(l._SystemUser);
                if (this._SystemUser.UserNO == l._SystemUser.UserNO)
                {
                    #region 同一用户
                    if (m_frmPurchas != null && !m_frmPurchas.IsDisposed)
                    {
                        m_frmPurchas.Visible = !m_frmPurchas.Visible;
                    }
                    if (m_frmSell != null && !m_frmSell.IsDisposed)
                    {
                        m_frmSell.Visible = !m_frmSell.Visible;
                    }
                    if (m_frmStock != null && !m_frmStock.IsDisposed)
                    {
                        m_frmStock.Visible = !m_frmStock.Visible;
                    }
                    if (m_frmProviders != null && !m_frmProviders.IsDisposed)
                    {
                        m_frmProviders.Visible = !m_frmProviders.Visible;
                    }
                    if (m_frmUserManage != null && !m_frmUserManage.IsDisposed)
                    {
                        m_frmUserManage.Visible = !m_frmUserManage.Visible;
                    }
                    if (m_frmRecodrd != null && !m_frmRecodrd.IsDisposed)
                    {
                        m_frmRecodrd.Visible = !m_frmRecodrd.Visible;
                    }
                    #endregion
                }
                else
                {
                    #region 其它用户
                    m_frmPurchas = null; 
                    m_frmSell = null; 
                    m_frmStock = null; 
                    m_frmProviders = null; 
                    m_frmUserManage = null; 
                    m_frmRecodrd = null;
                    #endregion
                    this._SystemUser = l._SystemUser;
                }
            }            
        }
        private void ShowSplashForm()
        {
            SplashForm = new Splash();
            SplashForm.ShowDialog();
        }              

        void s_RefreshList(object sender, EventArgs e)
        {            
            if (sender.ToString() == "供应商类别" && this.m_frmProviders != null)
            {
                this.m_frmProviders.RefreshListProvidersType();
            }
            else if (sender.ToString() == "店铺信息")
            {

            }
            else if (sender.ToString() == "其它信息")
            {

            }
        }
        #endregion

        #region 窗体排列
        private void tsmiCascade_Click(object sender, EventArgs e)
        { // MDI窗体的层叠操作
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmiTileH_Click(object sender, EventArgs e)
        {// MDI窗体的水平平铺操作
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmiTileV_Click(object sender, EventArgs e)
        {// MDI窗体的垂直平铺操作 
            this.LayoutMdi(MdiLayout.TileVertical); 
        }

        private void tsmiArrangeIcon_Click(object sender, EventArgs e)
        {// MDI窗体排列图标操作 
            this.LayoutMdi(MdiLayout.ArrangeIcons); 
        }
        #endregion

        #region 退出
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        #endregion

        #region 工具栏
        private void tsmiToolsBar_Click(object sender, EventArgs e)
        {
            this.toolStripTop.Visible = !this.toolStripTop.Visible;
            this.tsmiToolsBar.Checked = !this.tsmiToolsBar.Checked;
        }
        #endregion

        






    }
}
