using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Invoicing.Common;


namespace Invoicing
{
    public partial class ucDateTime : UserControl
    {
        private string m_strData = System.DateTime.Today.ToString("yyyy-MM-dd");
        public event EventHandler<DatetimeTreeEventArgs> DatetimeChanged;
        public ucDateTime()
        {
            InitializeComponent();
            for (int i = 2010; i <= DateTime.Now.Year; i++)
            {
                this.cbbYear.Items.Add(i.ToString());
            }
            if (this.cbbYear.Items.Count > 0)
            {
                this.cbbYear.SelectedIndex = this.cbbYear.Items.Count - 1;
            }
        }

        public void InitTree()
        {
            this.tvDatetime.Nodes.Clear();
            int y;
            int m;
            int d;
            int startYear = Convert.ToInt32(this.cbbYear.SelectedItem.ToString());
            int endYear = DateTime.Today.Year;

            Application.DoEvents();

            #region 构建树
            for (y = startYear; y <= endYear; y++)
            {
                TreeNode Ynode = new TreeNode();
                Ynode.Text = y.ToString();
                Ynode.Tag = y.ToString();
                Ynode.ImageIndex = 0;
                Ynode.SelectedImageIndex = 1;
                Ynode.Name = y.ToString();
                tvDatetime.Nodes.Add(Ynode);
                if (y == DateTime.Now.Year)
                {
                    for (m = 1; m <= 12; m++)
                    {
                        TreeNode Mnode = new TreeNode();
                        Mnode.Text = m.ToString("D2");
                        Mnode.Tag = m.ToString("D2");
                        Mnode.ImageIndex = 2;
                        Mnode.SelectedImageIndex = 3;
                        Ynode.Nodes.Add(Mnode);
                        Mnode.Name = y.ToString() + m.ToString("D2");
                        if (m == DateTime.Now.Month)
                        {
                            for (d = 1; d <= System.DateTime.DaysInMonth(y, m); d++)
                            {
                                TreeNode Dnode = new TreeNode();
                                Dnode.Text = d.ToString("D2");
                                Dnode.Tag = d.ToString("D2");
                                Dnode.ImageIndex = 4;
                                Dnode.SelectedImageIndex = 5;
                                Dnode.Name = y.ToString() + m.ToString("D2") + d.ToString("D2");
                                Mnode.Nodes.Add(Dnode);
                            }//d	
                        }
                        else
                        {
                            Mnode.Nodes.Add(new TreeNode());
                        }
                    }//m
                }
                else
                {
                    Ynode.Nodes.Add(new TreeNode());
                }
            }//y
            #endregion

            //查找当天的点           
            TreeNode[] tnToday = this.tvDatetime.Nodes.Find(DateTime.Today.ToString("yyyyMMdd"), true);

            this.tvDatetime.SelectedNode = tnToday[0];

            this.m_strData = tvDatetime.SelectedNode.Parent.Parent.Text + "-"
                + tvDatetime.SelectedNode.Parent.Text + "-"
                + tvDatetime.SelectedNode.Text;

            //在该控件上执行的操作正从错误的线程调用。使用 Control.Invoke 或 Control.BeginInvoke 封送到正确的线程才能执行此操作。

            //Control.CheckForIllegalCrossThreadCalls = false;
            //thread = new System.Threading.Thread(new System.Threading.ThreadStart(AddOtherNode));
            //thread.Start();

            //if (!this.IsHandleCreated)
            //    return;
            //this.BeginInvoke(new Action(() =>
            //{
            //    try
            //    {
                    AddOtherNode();
            //    }
            //    catch (System.Exception err)
            //    {
            //        Console.Write(err.Message + err.StackTrace);
            //    }               
            //}));           
        }
        private void AddOtherNode()
        {
            TreeNode Mnode;
            TreeNode Dnode;
            foreach (TreeNode ytn in this.tvDatetime.Nodes)
            {
                if (ytn.Name != DateTime.Today.ToString("yyyy"))
                {
                    ytn.Nodes.Clear();

                    for (int m = 1; m < 13; m++)
                    {
                        Mnode = new TreeNode();
                        Mnode.Text = m.ToString("D2");
                        Mnode.Tag = m.ToString("D2");
                        Mnode.ImageIndex = 2;
                        Mnode.SelectedImageIndex = 3;
                        ytn.Nodes.Add(Mnode);
                        Mnode.Name = ytn.Name + m.ToString("D2");
                        for (int d = 1; d <= System.DateTime.DaysInMonth(Convert.ToInt32(ytn.Name), m); d++)
                        {
                            Dnode = new TreeNode();
                            Dnode.Text = d.ToString("D2");
                            Dnode.Tag = d.ToString("D2");
                            Dnode.ImageIndex = 4;
                            Dnode.SelectedImageIndex = 5;
                            Dnode.Name = ytn.Name + m.ToString("D2") + d.ToString("D2");
                            Mnode.Nodes.Add(Dnode);
                        }//d                       
                    }//m
                }
                else
                {
                    foreach (TreeNode mtn in ytn.Nodes)
                    {
                        if (mtn.Name != DateTime.Today.ToString("yyyyMM"))
                        {
                            mtn.Nodes.Clear();
                            for (int d = 1; d <= System.DateTime.DaysInMonth(Convert.ToInt32(ytn.Name), Convert.ToInt32(mtn.Name.Replace(ytn.Name, string.Empty))); d++)
                            {
                                Dnode = new TreeNode();
                                Dnode.Text = d.ToString("D2");
                                Dnode.Tag = d.ToString("D2");
                                Dnode.ImageIndex = 4;
                                Dnode.SelectedImageIndex = 5;
                                Dnode.Name = mtn.Name.ToString() + d.ToString("D2");
                                mtn.Nodes.Add(Dnode);
                            }//d 
                        }
                    }
                }
            }
        }

        private void tvDatetime_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (DatetimeChanged != null)
            {
                DatetimeTreeEventArgs e2 = new DatetimeTreeEventArgs();
                if (this.tvDatetime.SelectedNode.Parent == null)
                {
                    e2.dateTimeType = DatetimeType.Year;
                    e2.DatatimeString = this.tvDatetime.SelectedNode.Text;
                }
                else if (this.tvDatetime.SelectedNode.Nodes.Count == 0)
                {
                    e2.dateTimeType = DatetimeType.Day;
                    e2.DatatimeString = this.tvDatetime.SelectedNode.Parent.Parent.Text + "-" + this.tvDatetime.SelectedNode.Parent.Text + "-" + this.tvDatetime.SelectedNode.Text;
                }
                else
                {
                    e2.dateTimeType = DatetimeType.Month;
                    e2.DatatimeString = this.tvDatetime.SelectedNode.Parent.Text + "-" + this.tvDatetime.SelectedNode.Text;
                }
                DatetimeChanged(this.tvDatetime, e2);
            }
        }

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.InitTree();
        }
    }
}
