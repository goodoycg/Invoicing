using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Invoicing.Common
{
    public class ShopInfo
    {
        public string Shopname { get; set; }
        public string Shoptel { get; set; }
        public string Shopaddress { get; set; }
        public ShopInfo()
        {
            string strSql = @"select * from ShopInfo;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
           
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr["ItemName"].ToString() == "shopaddress")
                    {
                        this.Shopaddress = dr["ItemValue"].ToString();
                    }
                    else if (dr["ItemName"].ToString() == "shoptel")
                    {
                        this.Shoptel = dr["ItemValue"].ToString();
                    }
                    else if (dr["ItemName"].ToString() == "shopname")
                    {
                        this.Shopname = dr["ItemValue"].ToString();
                    }
                }
            }
        }
       
        public bool Update()
        {
            string strSql1 = @"update ShopInfo set ItemValue=@shopaddress where ItemName = 'shopaddress';";           
            OleDbCommand cmd1 = new OleDbCommand(strSql1, Foundation.CreateInstance());
            cmd1.Parameters.AddWithValue("@shopaddress", Shopaddress);


            string strSql2 = @"update ShopInfo set ItemValue=@shoptel where ItemName = 'shoptel';";
            OleDbCommand cmd2 = new OleDbCommand(strSql2, Foundation.CreateInstance());
            cmd2.Parameters.AddWithValue("@shoptel", Shoptel);


            string strSql3 = @"update ShopInfo set ItemValue=@shopname where ItemName = 'shopname';";
            OleDbCommand cmd3 = new OleDbCommand(strSql3, Foundation.CreateInstance());
            cmd3.Parameters.AddWithValue("@shopname", Shopname);

            

            return (cmd1.ExecuteNonQuery() > 0 && cmd2.ExecuteNonQuery() > 0 && cmd3.ExecuteNonQuery() > 0);
        }       
        
    }
}
