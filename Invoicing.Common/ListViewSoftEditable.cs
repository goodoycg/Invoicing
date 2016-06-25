using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Invoicing.Common
{
    /// <summary>
    /// �ɱ༭��������,���һ���Զ���Ӧ���
    /// </summary>
    public partial class ListViewSoftEditable : System.Windows.Forms.ListView
    {
        private List<int> m_ListDecimalColumnIndex=new List<int>();
        public List<int> ListDecimalColumnIndex
        {
            get { return m_ListDecimalColumnIndex; }
            set { m_ListDecimalColumnIndex=value;}
        }
        public ListViewSoftEditable()
        {
            InitializeComponent();
            this.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(ListViewExSoft_ColumnClick);           
            this.GridLines = true;           
            this.FullRowSelect = true;
        }
        public ListViewSoftEditable(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            this.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(ListViewExSoft_ColumnClick);
            this.GridLines = true;
            this.FullRowSelect = true;
        }
        
       
        private void ListViewExSoft_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (this.Columns[e.Column].Tag == null)
            {
                this.Columns[e.Column].Tag = true;
            }
            bool tabK = (bool)this.Columns[e.Column].Tag;
            if (tabK)
            {
                this.Columns[e.Column].Tag = false;
            }
            else
            {
                this.Columns[e.Column].Tag = true;
            }
            this.ListViewItemSorter = new ListViewSort(e.Column, this.Columns[e.Column].Tag, ListDecimalColumnIndex.Exists(i => i == e.Column));
            //ָ����������������������������ؼ���
            this.Sort();//���б�����Զ�������
        }            

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
        }
        
    }
}
