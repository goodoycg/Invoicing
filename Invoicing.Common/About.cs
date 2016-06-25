using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Invoicing.Common
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        private ToolTip tipThans; 
        private void About_Load(object sender, EventArgs e)
        {
            tipThans = new ToolTip();
            // Set up the delays for the ToolTip. 
            tipThans.AutoPopDelay = 5000;
            tipThans.InitialDelay = 500;
            tipThans.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active. 
            tipThans.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox. 
            tipThans.SetToolTip(this.picAppTip, "欢迎使用 电脑耗材进销存管理系统");


            RegistryKey key1 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\");
            object obj1 = key1.GetValue("RegisteredOrganization");
            if (obj1 != null)
            {
                this.labelTo.Text += obj1.ToString() + " ";
                this.labelTo.Text += key1.GetValue("RegisteredOwner").ToString();
                this.labelOS.Text += key1.GetValue("ProductName").ToString();
            }
            else
            {
                RegistryKey key2 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\");
                this.labelTo.Text += key2.GetValue("RegisteredOrganization").ToString() + " ";
                this.labelTo.Text += key2.GetValue("RegisteredOwner").ToString();
                this.labelOS.Text += key2.GetValue("ProductName").ToString();
            }
            this.labelVer.Text = "产品版本：" + Foundation.GetAppVersion().ToString(); // Application.ProductVersion;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picAppTip_Click(object sender, EventArgs e)
        {

        }
    }
}
