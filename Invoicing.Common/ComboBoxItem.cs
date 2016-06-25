using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invoicing.Common
{
    public class ComboBoxItem
    {
        public ComboBoxItem()
        {

        }
        public ComboBoxItem(string text, string values)
        {
            this.m_Text = text;
            this.m_Value = values;
        }

        private string m_Value = string.Empty;
        public string Value
        {
            set { this.m_Value = value; }
            get { return this.m_Value; }
        }

        private string m_Text = string.Empty;
        public string Text
        {
            set { this.m_Text = value; }
            get { return this.m_Text; }
        }

        private object m_object = null;
        public object Tag
        {
            set { this.m_object = value; }
            get { return this.m_object; }
        }

        public override string ToString()
        {
            return this.m_Text;
        }
    }
}
