using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Invoicing
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainFrame mf = new mainFrame();
            if (mf._IsShow)
            {
                Application.Run(mf);
            }
            
            //Application.Run(new Form1());
            
        }
    }
}
