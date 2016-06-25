using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Invoicing.Common
{
    public class SystemUser
    {//admin 12345
        public int UserNO { set; get; }
        public string Username { set; get; }
        public string PW { set; get; }
        public bool Purchas { set; get; }
        /// <summary>
        /// -1:无此权限，0：所有,1:当天，5:5天之内
        /// </summary>
        public int SellDay { set; get; }
        public bool Stock { set; get; } 
        public bool Usermanage { set; get; }
        public bool Providers { set; get; }
        public bool SystemSet { set; get; }
        public string Remarks { set; get; }
        public bool CancelSell { set; get; }
        public bool DeleteSell { set; get; }
        public bool Record { set; get; }
        public bool ShowProfit { set; get; }
        /// <summary>
        /// 销售界面的进货单价
        /// </summary>
        public bool SellInprice { set; get; }
        public SystemUser()
        {
            NewUserNO();
        }
        public SystemUser(int UserNO)
        {
            this.UserNO = UserNO;
        }
        public SystemUser(string Username, string PW)
        {
            this.Username = Username;
            this.PW = PW;
        }
        
        private void NewUserNO()
        {
            string strSql = @"select max(userno) from UserManage";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());            
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds == null || ds.Tables.Count < 1 || ds.Tables[0].Rows.Count < 1)
            {
                this.UserNO = 1;
            }
            else
            {
                this.UserNO = 1 + Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            }
        }
        public bool Add()
        {
            string strSql = @"insert into UserManage(userno,username,userpw,purchas,sell,stock,usermanage,remark,cancelsell,deletesell,providers,systemset,record,ShowProfit,SellInprice) ";
            strSql += "values(@userno,@username,@userpw,@purchas,@sell,@stock,@usermanage,@remark,@cancelsell,@deletesell,@providers,@systemset,@record,@ShowProfit,@SellInprice);";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@userno", UserNO);
            cmd.Parameters.AddWithValue("@username", Username);
            cmd.Parameters.AddWithValue("@userpw", Foundation.GetMD5String(PW));
            cmd.Parameters.AddWithValue("@purchas", Purchas ? 1 : 0);
            cmd.Parameters.AddWithValue("@sell", SellDay);
            cmd.Parameters.AddWithValue("@stock", Stock ? 1 : 0);
            cmd.Parameters.AddWithValue("@usermanage", Usermanage ? 1 : 0);
            cmd.Parameters.AddWithValue("@remark", Remarks);
            cmd.Parameters.AddWithValue("@cancelsell", CancelSell ? 1 : 0);
            cmd.Parameters.AddWithValue("@deletesell", DeleteSell ? 1 : 0);
            cmd.Parameters.AddWithValue("@providers", Providers ? 1 : 0);
            cmd.Parameters.AddWithValue("@systemset", SystemSet ? 1 : 0);
            cmd.Parameters.AddWithValue("@record", Record ? 1 : 0);
            cmd.Parameters.AddWithValue("@ShowProfit", ShowProfit ? 1 : 0);
            cmd.Parameters.AddWithValue("@SellInprice", SellInprice ? 1 : 0);
            return cmd.ExecuteNonQuery() > 0;
        }
        public bool Modify()
        {
            string strSql = @"update UserManage set username=@username,purchas=@purchas,sell=@sell,stock=@stock,";
            strSql += "usermanage=@usermanage,remark=@remark,cancelsell=@cancelsell,deletesell=@deletesell,";
            strSql += "providers=@providers,systemset=@systemset,record=@record,ShowProfit=@ShowProfit,SellInprice=@SellInprice where userno=@userno";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());           
            cmd.Parameters.AddWithValue("@username", Username);
            //cmd.Parameters.AddWithValue("@userpw", Common.GetMD5String(PW));
            cmd.Parameters.AddWithValue("@purchas", Purchas ? 1 : 0);
            cmd.Parameters.AddWithValue("@sell", SellDay);
            cmd.Parameters.AddWithValue("@stock", Stock ? 1 : 0);
            cmd.Parameters.AddWithValue("@usermanage", Usermanage ? 1 : 0);
            cmd.Parameters.AddWithValue("@remark", Remarks);
            cmd.Parameters.AddWithValue("@userno", UserNO);
            cmd.Parameters.AddWithValue("@cancelsell", CancelSell ? 1 : 0);
            cmd.Parameters.AddWithValue("@deletesell", DeleteSell ? 1 : 0);
            cmd.Parameters.AddWithValue("@providers", Providers ? 1 : 0);
            cmd.Parameters.AddWithValue("@systemset", SystemSet ? 1 : 0);
            cmd.Parameters.AddWithValue("@record", Record ? 1 : 0);
            cmd.Parameters.AddWithValue("@ShowProfit", ShowProfit ? 1 : 0);
            cmd.Parameters.AddWithValue("@SellInprice", SellInprice ? 1 : 0);
            return cmd.ExecuteNonQuery() > 0;
        }
        public bool Delete()
        {
            OleDbConnection conn = Foundation.CreateInstance();
            string strSql = @"delete from UserManage where UserNO = @UserNO";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@UserNO", UserNO);
            return cmd.ExecuteNonQuery() > 0;
        }
        public bool Login()
        {//登录并获取权限
            string strSql = @"select * from UserManage where Username=@Username and UserPW=@PW";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@PW", Foundation.GetMD5String(PW));
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                this.UserNO = Convert.ToInt32(ds.Tables[0].Rows[0]["UserNO"].ToString());

                this.Purchas = ds.Tables[0].Rows[0]["Purchas"].ToString() == "1";
                this.SellDay = Convert.ToInt32(ds.Tables[0].Rows[0]["Sell"].ToString());                
                this.Stock = ds.Tables[0].Rows[0]["Stock"].ToString() == "1";
                this.Usermanage = ds.Tables[0].Rows[0]["Usermanage"].ToString() == "1";
                this.CancelSell = ds.Tables[0].Rows[0]["cancelsell"].ToString() == "1";
                this.DeleteSell = ds.Tables[0].Rows[0]["deletesell"].ToString() == "1";
                this.Remarks = ds.Tables[0].Rows[0]["Remark"].ToString();
                this.Providers = ds.Tables[0].Rows[0]["providers"].ToString() == "1";
                this.SystemSet = ds.Tables[0].Rows[0]["systemset"].ToString() == "1";
                this.Record = ds.Tables[0].Rows[0]["Record"].ToString() == "1";
                this.ShowProfit = ds.Tables[0].Rows[0]["ShowProfit"].ToString() == "1";
                this.SellInprice = ds.Tables[0].Rows[0]["SellInprice"].ToString() == "1";
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ResetPW(string OldPW, string NewPW)
        {//string strSql2 = @"update Purchas set outcount=outcount+@outcount where goodsno=@goodsno";

            string strSql = @"update UserManage set UserPW=@NewPW where Username=@Username and UserPW=@OldPW";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@NewPW", Foundation.GetMD5String(NewPW));
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@OldPW", Foundation.GetMD5String(OldPW));
            return cmd.ExecuteNonQuery() > 0;
        }
        public bool ExistUser(string NewUsername)
        {
            string strSql = string.Empty;            
            strSql = @"select * from UserManage where Username=@Username";           
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@Username", NewUsername);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0);
        }
        public bool ExistUser(int Userno, string NewUsername)
        {
            string strSql = string.Empty;
            strSql = @"select * from UserManage where Username=@Username and Userno <> "+Userno.ToString();            
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@Username", NewUsername);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0);
        }
        public static void ListUser(ListView listView)
        {
            string strSql = @"select * from UserManage where Username <> 'admin'";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                listView.Items.Add(new ListViewItem(new string[] { 
                    dr["Username"].ToString(), 
                    dr["Purchas"].ToString() == "1" ? "√" : "×", 
                    dr["Sell"].ToString() == "1" ? "√" : "×", 
                    dr["Stock"].ToString() == "1" ? "√" : "×", 
                    dr["Usermanage"].ToString() == "1" ? "√" : "×", 
                    dr["providers"].ToString() == "1" ? "√" : "×", 
                    dr["systemset"].ToString() == "1" ? "√" : "×", 
                    dr["cancelsell"].ToString() == "1" ? "√" : "×", 
                    dr["deletesell"].ToString() == "1" ? "√" : "×", 
                    dr["record"].ToString() == "1" ? "√" : "×",
                    dr["ShowProfit"].ToString() == "1" ? "√" : "×",
                    dr["SellInprice"].ToString() == "1" ? "√" : "×",                    
                    dr["Remark"].ToString() }
                    ) { Tag = dr["Userno"].ToString() });
            }
        }
    }
}
