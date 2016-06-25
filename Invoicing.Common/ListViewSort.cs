using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Invoicing.Common
{
    public class ListViewSort : IComparer
    {        
        private int col;
        private bool descK;
        private bool IsDecimal;
        
        public ListViewSort()
        {
            this.col = 0;
        }

        public ListViewSort(int column, object Desc, bool Decimal)
        {
            this.descK = (bool)Desc;
            this.col = column;
            this.IsDecimal = Decimal;
        }

        public int Compare(object x, object y)
        {
            int num;
            if (IsDecimal)
            {
                num = decimal.Compare(Convert.ToDecimal(((ListViewItem)x).SubItems[this.col].Text.Trim()),
                    Convert.ToDecimal(((ListViewItem)y).SubItems[this.col].Text.Trim()));
            }
            else
            {
                num = string.Compare(((ListViewItem)x).SubItems[this.col].Text,
                    ((ListViewItem)y).SubItems[this.col].Text);                 
            }
            if (this.descK)
            {
                return -num;
            }
            return num;
        }
    }
}