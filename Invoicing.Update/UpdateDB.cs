using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using Invoicing.Common;

namespace Invoicing.Update
{
    public class UpdateDB
    {
        private decimal m_appVer = 1.0M;
        public decimal AppVer
        {
            get { return m_appVer; }
            set { m_appVer = value; }
        }
        public event EventHandler Updateed;
        public UpdateDB()
        {
            m_appVer = Foundation.GetAppVersion();
        }
        public bool BackupDB()
        {
            try
            {
                File.Copy(Foundation.Runpath() + "db.mdb",
                    Foundation.PathAdd(Foundation.OtherInfo("backup")) + "db" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".mdb");
                return true;
            }
            catch(System.Exception err)
            {
                Console.Write(err.Message + err.StackTrace);
                return false;
            }
           
        }
        public void Update()
        {//以后要更新DB，就在下面按顺序写代码            
            if (m_appVer < 1.1M)
            {                //---------开始------2013-01-19-----------------------
                //向OthenInfo 表添加数据库备份位置的记录
                Foundation.RunSql("insert into otherinfo(itemno,itemname,itemvalue) select max(ItemNO)+1,'backup','c:\\' from otherinfo");
                //---------结束-------------------------------
                Foundation.SetAppVersion(1.1M);
                m_appVer = 1.1M;
                if (Updateed != null)
                {
                    Updateed("向OthenInfo 表添加数据库备份位置的记录", null);
                }
            }

        }
    }
}
