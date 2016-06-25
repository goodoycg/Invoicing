using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Invoicing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0;i< 5;i++)
            {
                this.listView1.Items.Add(new ListViewItem(new string[] { i.ToString(), i.ToString() }));
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in this.listView1.SelectedItems)
            {
                this.listView1.Items.Remove(lvi);
            }
        }
    }
}
