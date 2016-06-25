using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Invoicing.Common
{
    public class Foundation
    {
        /// <summary>
        /// 所有库存商品
        /// </summary>
        public const string AllGoodsName = "所有库存商品";
        /// <summary>
        /// 为路经添加后缀
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public static string PathAdd( string Path)
        {
            string _path = Path;
            if (!_path.EndsWith("\\") && !_path.EndsWith("/"))
            {
                _path = _path + "\\";
            }
            return _path;
        }
        /// <summary>
        /// 获取运行路经
        /// </summary>
        /// <returns></returns>
        public static string Runpath()
        {
            return PathAdd(Application.StartupPath);
        }

        public static string ConnString()
        {
           return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Runpath()
                 + "db.mdb;Persist Security Info=False;Jet OLEDB:Database Password=;";
        }
        public static string GetDictName(DictType dictType,string DictNO)
        {
            if (dictType == DictType.GoodsType)
            {
                return Common.Foundation.ReadObject("select TypeName from GoodsType where TypeNO=" + DictNO).ToString();
            }
            else if (dictType == DictType.GoodsUnit)
            {
                return Common.Foundation.ReadObject("select UnitName from GoodsUnit where UnitNO=" + DictNO).ToString();            
            }
            else if (dictType == DictType.Providers)
            {
                return Common.Foundation.ReadObject("select ProviderName from Providers where ProviderNO=" + DictNO).ToString();            
            }
            else if (dictType == DictType.ProviderType)
            {
                return Common.Foundation.ReadObject("select TypeDesc from ProviderType where TypeNO=" + DictNO).ToString();
            }
            return string.Empty;
        }
        private static List<OleDbConnection> listConn = new List<OleDbConnection>();
        public static OleDbConnection CreateInstance()
        {
            if (listConn.Count == 0)
            {
                OleDbConnection conn = new OleDbConnection(ConnString());
                conn.Open();
                listConn.Add(conn);
            }
            return listConn[0];
        }

        public static void OutputCSV(ListView lvOutput,string FileName,params string[] otherinfo)
        {
            StringBuilder s = new StringBuilder(string.Empty);
            foreach (ColumnHeader c in lvOutput.Columns)
            {
                s.Append(c.Text + "\t");
            }
            s.Append("\r\n");

            foreach (ListViewItem r in lvOutput.Items)
            {
                for (int i = 0; i < lvOutput.Columns.Count; i++)
                {
                    s.Append(r.SubItems[i].Text + "\t");
                }
                s.Append("\r\n");
            }
            if (otherinfo != null && otherinfo.Length > 0)
            {
                foreach (string s2 in otherinfo)
                {
                    s.Append(s2 + "\t");
                }
                s.Append("\r\n");
            }
            SaveFileDialog save = new SaveFileDialog()
            {
                Filter = "CSV(逗号分隔)(*.csv)|*.csv",
                CheckPathExists = true,
                FileName = FileName,
            };
            if (save.ShowDialog() == DialogResult.OK)
            {
                using(Stream stream = save.OpenFile())
                {
                    using (StreamWriter w = new StreamWriter(stream, System.Text.UnicodeEncoding.Unicode))
                    {
                        w.Write(s.ToString());
                        w.Close();
                    }
                    stream.Close();
                }
            }
        }

        public static string GetMD5String(string InputString)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            string result = string.Empty;
            byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(InputString));
            for (int i = 0; i < data.Length; i++)
            {
                result += data[i].ToString("x2");
            }
            return result;
        }
        
        public static bool RunSql(string sql)
        {
            OleDbCommand cmd1 = new OleDbCommand(sql, Foundation.CreateInstance());
            return cmd1.ExecuteNonQuery() > 0;
        }
        public static DataSet ReadDataSet(string sql)
        {
            OleDbCommand cmd = new OleDbCommand(sql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        public static Object ReadObject(string sql)
        {
            OleDbCommand cmd = new OleDbCommand(sql, Foundation.CreateInstance());
            return cmd.ExecuteScalar();            
        }
        #region Purchas
        public static DataSet GetDatetimeData(string DataTimeString)
        {
            string strSql = @"select Purchas.*,round(incount * inprice,2) as instat,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
            strSql += "from Purchas,Providers,goodsunit,GoodsType ";
            strSql += "where Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno and GoodsType.typeno=purchas.typeno and intime like '" + DataTimeString + "%' order by intime desc";

            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        
        public static DataSet GetProviderData(string ProviderNO)
        {
            string strSql = @"select Purchas.*,round(incount * inprice,2) as instat,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
            strSql += "from Purchas,Providers,goodsunit,GoodsType ";
            strSql += "where Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno and GoodsType.typeno=purchas.typeno and Purchas.ProviderNO =" + ProviderNO + "  order by intime desc";

            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        public static string PurchasTotal(string DataTimeString)
        {
            string strSql = @"select sum(round(incount * inprice,2)) from Purchas where intime like '" + DataTimeString + "%'";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            object o = cmd.ExecuteScalar();
            return (o == null ? string.Empty : o.ToString());
        }
        public static DataSet GetGoodsPurchas(int GoodsNO)
        {
            string strSql = @"select *,round(incount * inprice,2) as instat from Purchas where GoodsNO=@GoodsNO";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@GoodsNO", GoodsNO);
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        #endregion

        #region Sell
        public static bool ResetSellNO(string SellNO)
        {
            DataSet dsSell = Foundation.ReadDataSet("select * from Sell where sellno=" + SellNO);
            OleDbConnection conn = Foundation.CreateInstance();
            OleDbTransaction trans = conn.BeginTransaction();

            string strSql = @"update Sell set useing = 1 where sellno=@sellno;";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@sellno", SellNO);
            cmd.Transaction = trans;
            List<OleDbCommand> listCommand = new List<OleDbCommand>();
            foreach (DataRow row in dsSell.Tables[0].Rows)
            {
                string strSql2 = @"update purchas set outcount = outcount + @outcount where goodsno=@goodsno;";
                OleDbCommand cmdUpdate = new OleDbCommand(strSql2, conn);
                cmdUpdate.Parameters.AddWithValue("@outcount", row["OutCount"].ToString());
                cmdUpdate.Parameters.AddWithValue("@goodsno", row["GoodsNO"].ToString());
                cmdUpdate.Transaction = trans;
                listCommand.Add(cmdUpdate);
            }
            try
            {
                cmd.ExecuteNonQuery();
                listCommand.ForEach(c => c.ExecuteNonQuery());
                trans.Commit();
                return true;
            }
            catch (Exception er)
            {
                Console.Write(er.Message + er.StackTrace);
                trans.Rollback();
                return false;
            }
        }
        public static bool CancelSellNO(string SellNO)
        {
            DataSet dsSell = Foundation.ReadDataSet("select * from Sell where sellno=" + SellNO);
            OleDbConnection conn = Foundation.CreateInstance();
            OleDbTransaction trans = conn.BeginTransaction();

            string strSql = @"update Sell set useing = 0 where sellno=@sellno;";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@sellno", SellNO);
            cmd.Transaction = trans;
            List<OleDbCommand> listCommand = new List<OleDbCommand>();
            foreach (DataRow row in dsSell.Tables[0].Rows)
            {
                string strSql2 = @"update purchas set outcount = outcount - @outcount where goodsno=@goodsno;";
                OleDbCommand cmdUpdate = new OleDbCommand(strSql2, conn);
                cmdUpdate.Parameters.AddWithValue("@outcount", row["OutCount"].ToString());
                cmdUpdate.Parameters.AddWithValue("@goodsno", row["GoodsNO"].ToString());
                cmdUpdate.Transaction = trans;
                listCommand.Add(cmdUpdate);
            }
            try
            {
                cmd.ExecuteNonQuery();
                listCommand.ForEach(c => c.ExecuteNonQuery());
                trans.Commit();
                return true;
            }
            catch (Exception er)
            {
                Console.Write(er.Message + er.StackTrace);
                trans.Rollback();
                return false;
            }
        }
        public static bool CancelSellDateTime(string DateTimeString)
        {
            DataSet dsSell = Foundation.ReadDataSet("select * from Sell where outtime='" + DateTimeString + "'");
            OleDbConnection conn = Foundation.CreateInstance();
            OleDbTransaction trans = conn.BeginTransaction();

            string strSql = @"update Sell set useing = 0 where Outtime=@Outtime;";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@Outtime", DateTimeString);
            cmd.Transaction = trans;
            List<OleDbCommand> listCommand = new List<OleDbCommand>();
            foreach (DataRow row in dsSell.Tables[0].Rows)
            {
                string strSql2 = @"update purchas set outcount = outcount - @outcount where goodsno=@goodsno;";
                OleDbCommand cmdUpdate = new OleDbCommand(strSql2, conn);
                cmdUpdate.Parameters.AddWithValue("@outcount", row["OutCount"].ToString());
                cmdUpdate.Parameters.AddWithValue("@goodsno", row["GoodsNO"].ToString());
                cmdUpdate.Transaction = trans;
                listCommand.Add(cmdUpdate);
            }
            try
            {
                cmd.ExecuteNonQuery();
                listCommand.ForEach(c => c.ExecuteNonQuery());
                trans.Commit();
                return true;
            }
            catch (Exception er)
            {
                Console.Write(er.Message + er.StackTrace);
                trans.Rollback();
                return false;
            }
        }
        
        public static bool DeleteSellNO(string SellNO)
        {//删除销售单
            DataSet dsSell = Foundation.ReadDataSet("select * from Sell where sellno=" + SellNO);
            OleDbConnection conn = Foundation.CreateInstance();
            OleDbTransaction trans = conn.BeginTransaction();

            string strSql = @"delete from Sell where sellno=@sellno;";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@sellno", SellNO);
            cmd.Transaction = trans;
            List<OleDbCommand> listCommand = new List<OleDbCommand>();
            foreach (DataRow row in dsSell.Tables[0].Rows)
            {//要减去销售数量 (已作废的不要再减数量了)
                if (row["useing"].ToString() == "1")
                {
                    string strSql2 = @"update purchas set outcount = outcount - @outcount where goodsno=@goodsno;";
                    OleDbCommand cmdUpdate = new OleDbCommand(strSql2, conn);
                    cmdUpdate.Parameters.AddWithValue("@outcount", row["OutCount"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@goodsno", row["GoodsNO"].ToString());
                    cmdUpdate.Transaction = trans;
                    listCommand.Add(cmdUpdate);
                }
            }
            try
            {
                cmd.ExecuteNonQuery();
                listCommand.ForEach(c => c.ExecuteNonQuery());
                trans.Commit();
                return true;
            }
            catch (Exception er)
            {
                Console.Write(er.Message + er.StackTrace);
                trans.Rollback();
                return false;
            }

        }
        

        public static bool DeleteSellDateTime(string DateTimeString)
        {
            DataSet dsSell = Foundation.ReadDataSet("select * from Sell where outtime='" + DateTimeString + "'");
            OleDbConnection conn = Foundation.CreateInstance();
            OleDbTransaction trans = conn.BeginTransaction();

            string strSql = @"delete from Sell where Outtime=@Outtime;";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@Outtime", DateTimeString);
            cmd.Transaction = trans;
            List<OleDbCommand> listCommand = new List<OleDbCommand>();
            foreach (DataRow row in dsSell.Tables[0].Rows)
            {
                string strSql2 = @"update purchas set outcount = outcount - @outcount where goodsno=@goodsno;";
                OleDbCommand cmdUpdate = new OleDbCommand(strSql2, conn);
                cmdUpdate.Parameters.AddWithValue("@outcount", row["OutCount"].ToString());
                cmdUpdate.Parameters.AddWithValue("@goodsno", row["GoodsNO"].ToString());
                cmdUpdate.Transaction = trans;
                listCommand.Add(cmdUpdate);
            }
            try
            {
                cmd.ExecuteNonQuery();
                listCommand.ForEach(c => c.ExecuteNonQuery());
                trans.Commit();
                return true;
            }
            catch (Exception er)
            {
                Console.Write(er.Message + er.StackTrace);
                trans.Rollback();
                return false;
            }

        }

        public static DataSet GetSellDataOuttime(string DataTimeString, int InDaycount)
        {
            string strSql = @"select sell.*,round(sell.outcount * sell.outprice,2) as outstat,round(sell.outcount * (sell.outprice-purchas.inprice),2) as profit,";
            strSql += "purchas.goodsname,purchas.goodscode,purchas.fixprice,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
            strSql += "from Sell,purchas,goodsunit,Providers,GoodsType where Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno ";
            strSql += "and GoodsType.typeno=purchas.typeno and Sell.goodsno=purchas.goodsno and outtime like @outtime";
            // -1, 0, 1, 5
            if (InDaycount > 0)
            {
                strSql += " and datediff('d',sell.outtime,now) < " + InDaycount.ToString();
            }
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@outtime", DataTimeString + "%");
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        public static DataSet GetGoodsTypeData(string TypeNO)
        {
            string strSql = @"select Purchas.*,round(incount * inprice,2) as instat,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
            strSql += "from Purchas,Providers,goodsunit,GoodsType ";
            strSql += "where Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno ";
            strSql += "and GoodsType.typeno=purchas.typeno and Purchas.typeno =" + TypeNO + "  order by intime desc";

            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        
        public static DataSet SellGetGoodsTypeData(string TypeNO, int InDaycount)
        {
            string strSql = @"select sell.*,round(sell.outcount * sell.outprice,2) as outstat,round(sell.outcount * (sell.outprice-purchas.inprice),2) as profit,";
            strSql += "purchas.goodsname,purchas.goodscode,purchas.fixprice,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
            strSql += "from Sell,purchas,goodsunit,Providers,GoodsType where Purchas.unitno = goodsunit.UnitNO and ";
            strSql += "Providers.ProviderNO=purchas.providerno and GoodsType.typeno=purchas.typeno and Sell.goodsno=purchas.goodsno and purchas.typeno=" + TypeNO;
            // -1, 0, 1, 5
            if (InDaycount > 0)
            {
                strSql += " and datediff('d',sell.outtime,now) < " + InDaycount.ToString();
            }
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        public static DataSet SellGetProviderData(string ProviderNO,int InDaycount)
        {//
            string strSql = @"select sell.*,round(sell.outcount * sell.outprice,2) as outstat,round(sell.outcount * (sell.outprice-purchas.inprice),2) as profit,";
            strSql += "purchas.goodsname,purchas.goodscode,purchas.fixprice,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
            strSql += " from Sell,purchas,goodsunit,Providers,GoodsType where Purchas.unitno = goodsunit.UnitNO and ";
            strSql += "Providers.ProviderNO=purchas.providerno and GoodsType.typeno=purchas.typeno and Sell.goodsno=purchas.goodsno and purchas.typeno=" + ProviderNO;           
            // -1, 0, 1, 5
            if (InDaycount > 0)
            {
                strSql += " and datediff('d',sell.outtime,now) < "+InDaycount.ToString();
            }            
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        public static DataSet GetMultiSellNOData(List<int> MultiSellNO)
        {
            string strSql = @"select sell.*,round(sell.outcount * sell.outprice,2) as outstat,round(sell.outcount * (sell.outprice-purchas.inprice),2) as profit,";
            strSql += "purchas.goodsname,purchas.fixprice,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
            strSql += " from Sell,purchas,goodsunit,Providers,GoodsType where Purchas.unitno = goodsunit.UnitNO and ";
            strSql += "Providers.ProviderNO=purchas.providerno and GoodsType.typeno=purchas.typeno and Sell.goodsno=purchas.goodsno ";
            if (MultiSellNO.Count == 1)
            {
                strSql += "and Sell.SellNO = " + MultiSellNO[0].ToString();
            }
            else
            {
                strSql += "and (";
                foreach (int ii in MultiSellNO)
                {
                    strSql += "Sell.SellNO = " + ii.ToString() + " or ";
                }
                strSql = strSql.Substring(0, strSql.Length - 4);
                strSql += ")";
            }
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
       
        public static string GetGoodsName(string GoodsNO)
        {
            string strSql = "select goodsname from purchas where goodsno = @goodsno";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@goodsno", GoodsNO);
            object o = cmd.ExecuteScalar();
            return (o == null ? string.Empty : o.ToString());
        }
        public static decimal GetGoodsStock(int GoodsNO)
        {
            string strSql = "select (incount-outcount) from purchas where goodsno = @goodsno";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@goodsno", GoodsNO);
            return Convert.ToDecimal(cmd.ExecuteScalar().ToString());
        }
        public static OtherInfo GetOtherInfo()
        {
            OtherInfo other = new Common.OtherInfo();
            DataSet ds = Foundation.OtherInfo();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if ("Sell2Print" == dr["itemname"].ToString())
                {
                    other.Sell2Print = dr["itemvalue"].ToString() == "1";
                }
                else if ("Notethings" == dr["itemname"].ToString())
                {
                    other.Notethings = dr["itemvalue"].ToString();
                }
            }
            return other;

        }
       
        public static DataSet GetGoodsSell(int GoodsNO)
        {
            string strSql = "select Sell.*,round(sell.outcount * sell.outprice,2) as outstat,";
            strSql += "round(sell.outcount * (sell.outprice-purchas.inprice),2) as profit,";
            strSql += "(select fixprice from purchas where sell.goodsno = purchas.goodsno) as fixprice,";
            strSql += "(select inprice from purchas where sell.goodsno = purchas.goodsno) as inprice,";
            strSql += "(select goodsname from purchas ";
            strSql += "where sell.goodsno = purchas.goodsno) as goodsname from Sell,purchas where sell.goodsno=purchas.goodsno and purchas.goodsno = @goodsno";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@goodsno", GoodsNO);
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        public static string SellTotal(string DataTimeString)
        {
            string strSql = @"select sum(round(outcount * outprice,2)) from Sell where outtime like @outtime";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@outtime", DataTimeString + "%");
            object o = cmd.ExecuteScalar();
            return (o == null ? string.Empty : o.ToString());
        }
        public static string SellTotal(int GoodsNO)
        {
            string strSql = @"select sum(round(outcount * outprice,2)) from Sell where goodsno = @goodsno";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@goodsno", GoodsNO);
            object o = cmd.ExecuteScalar();
            return (o == null ? string.Empty : o.ToString());
        }
        public static DataSet GetSellTimeData(string SellTime, int InDaycount)
        {
            string strSql = @"select sell.*,round(sell.outcount * sell.outprice,2) as outstat,round(sell.outcount * (sell.outprice-purchas.inprice),2) as profit,";
            strSql += "purchas.goodsname,purchas.goodscode,purchas.fixprice,purchas.fixprice,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
            strSql += " from Sell,purchas,goodsunit,Providers,GoodsType where Purchas.unitno = goodsunit.UnitNO and ";
            strSql += "Providers.ProviderNO=purchas.providerno and GoodsType.typeno=purchas.typeno and Sell.goodsno=purchas.goodsno and sell.outtime='" + SellTime + "'";
            // -1, 0, 1, 5
            if (InDaycount > 0)
            {
                strSql += " and datediff('d',sell.outtime,now) < " + InDaycount.ToString();
            } 
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        public static DataSet GetOrderNOData(string OrderNO)
        {
            string strSql = @"select sell.*,round(sell.outcount * sell.outprice,2) as outstat,round(sell.outcount * (sell.outprice-purchas.inprice),2) as profit,";
            strSql += "purchas.goodsname,purchas.fixprice,purchas.fixprice,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
            strSql += " from Sell,purchas,goodsunit,Providers,GoodsType where Purchas.unitno = goodsunit.UnitNO and ";
            strSql += "Providers.ProviderNO=purchas.providerno and GoodsType.typeno=purchas.typeno and Sell.goodsno=purchas.goodsno and sell.orderno=" + OrderNO;

            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        /// <summary>
        /// 销售新的单号
        /// </summary>
        /// <returns></returns>
        public static int GetNewOrderNO()
        {
            string strSql = @"select max(OrderNO) from Sell;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            object o = cmd.ExecuteScalar();
            if (o == DBNull.Value)
            {
                return 1;
            }
            else
            {
                return 1 + Convert.ToInt32(o);
            }
        }
        public static DataSet OtherInfo()
        {
            string strSql = @"select * from otherInfo;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        public static string OtherInfo(string ItemName)
        {
            string strSql = @"select itemvalue from otherInfo where itemname='"+ItemName+"';";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            object o = cmd.ExecuteScalar();
            return (o == null ? string.Empty : o.ToString());
        }
        
        public static DataSet LatelyAllSell(int InDaycount)
        {
            string strSql = @"select sell.*,round(sell.outcount * sell.outprice,2) as outstat,round(sell.outcount * (sell.outprice-purchas.inprice),2) as profit,";
            strSql += "purchas.goodsname,purchas.goodscode,purchas.fixprice,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
            strSql += " from Sell,purchas,goodsunit,Providers,GoodsType ";
            strSql += " where Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno ";
            strSql += " and GoodsType.typeno=purchas.typeno and Sell.goodsno=purchas.goodsno";            
            // -1, 0, 1, 5
            if (InDaycount > 0)
            {
                strSql += " and datediff('d',sell.outtime,now) < " + InDaycount.ToString();
            }
            strSql += " order by sell.Outtime desc";
            DataSet ds2 = Foundation.ReadDataSet(strSql);
            return ds2;
        }
        #endregion

        #region Stock
        public static DataSet GetAllStockGoodsName()
        {
            string strSql = @"select distinct goodsname  from Purchas where incount > outcount";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        public static DataSet GetStockGoods(int GoodsNO)
        {
            string strSql = @"select Purchas.*,(incount - outcount) as stockcount,round(stockcount * inprice,2) as instat,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
            strSql += @"from Purchas,Providers,goodsunit,GoodsType where Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno ";
            strSql += "and GoodsType.typeno=purchas.typeno and goodsno=" + GoodsNO;
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        public static DataSet GetStockGoods(string GoodsName)
        {
            return GetStockGoods(GoodsName, true);
        }
        public static DataSet GetStockGoods(string GoodsName, bool ShowZeroStock)
        {
            string strSql;
            if (GoodsName == Foundation.AllGoodsName)
            {
                strSql = @"select Purchas.*,(incount - outcount) as stockcount,round(stockcount * inprice,2) as instat,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
                strSql += @"from Purchas,Providers,goodsunit,GoodsType ";
                strSql += @"where Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno and GoodsType.typeno=purchas.typeno";

            }
            else
            {
                strSql = @"select Purchas.*,(incount - outcount) as stockcount,round(stockcount * inprice,2) as instat,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
                strSql += @"from Purchas,Providers,goodsunit,GoodsType ";
                strSql += @"where Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno and GoodsType.typeno=purchas.typeno and goodsname='" + GoodsName + "'";
            }
            if (ShowZeroStock == false)
            {
                strSql += " and Purchas.incount > Purchas.outcount";
            }
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }



        public static DataSet GetStockGoodsProviderData(string ProviderNO)
        {
            return GetStockGoodsProviderData(ProviderNO, true);
        }
        public static DataSet GetStockGoodsProviderData(string ProviderNO, bool ShowZeroStock)
        {
            string strSql = @"select Purchas.*,(incount - outcount) as stockcount,round(stockcount * inprice,2) as instat,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
            strSql += @"from Purchas,Providers,goodsunit,GoodsType ";

            if (ShowZeroStock)
            {
                strSql += "where Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno ";
            }
            else
            {
                strSql += "where Purchas.incount > Purchas.outcount and Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno ";
            }
            strSql += "and GoodsType.typeno=purchas.typeno and Purchas.ProviderNO=" + ProviderNO;
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }

        public static DataSet GetStockGoodsTypeData(string TypeNO)
        {
            return GetStockGoodsTypeData(TypeNO, true);
        }
        public static DataSet GetStockGoodsTypeData(string TypeNO, bool ShowZeroStock)
        {
            string strSql = @"select Purchas.*,(incount - outcount) as stockcount,round(stockcount * inprice,2) as instat,goodsunit.UnitName,GoodsType.TypeName,Providers.ProviderName ";
            strSql += @"from Purchas,Providers,goodsunit,GoodsType ";
            if (ShowZeroStock)
            {
                strSql += "where Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno ";
            }
            else
            {
                strSql += "where Purchas.incount > Purchas.outcount and Purchas.unitno = goodsunit.UnitNO and Providers.ProviderNO=purchas.providerno ";
            }
            strSql += "and GoodsType.typeno=purchas.typeno and Purchas.TypeNO=" + TypeNO;
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        #endregion

        /// <summary>
        /// 没有版本记录时返回 1.0
        /// </summary>
        /// <returns></returns>
        public static decimal GetAppVersion()
        {
            string strSql = @"select itemvalue from OtherInfo where itemname = 'AppVersion'";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            object o = cmd.ExecuteScalar();
            if (o == null)
            {
                OleDbCommand cmdMax = new OleDbCommand("select max(itemno) from otherinfo", Foundation.CreateInstance());
                o = cmdMax.ExecuteScalar();
                int i = Convert.ToInt32(o.ToString());
                i = i + 1;
                cmdMax = new OleDbCommand("insert into otherinfo values(" + i.ToString() + ",'AppVersion','1.0')", Foundation.CreateInstance());
                cmdMax.ExecuteNonQuery();
                return 1.0M;
            }
            else
            {
                return Convert.ToDecimal(o.ToString());
            }            
        }
        /// <summary>
        /// 设置软件版本号
        /// </summary>
        /// <param name="ver"></param>
        /// <returns></returns>
        public static bool SetAppVersion(decimal ver)
        {
            OleDbCommand cmdMax = new OleDbCommand("update otherinfo set itemvalue='" + ver.ToString() + "' where itemname = 'AppVersion'", Foundation.CreateInstance());
           return cmdMax.ExecuteNonQuery() > 0;
        }        
    }
   
    public enum CurrentState
    {
        Lock,Login
    }
    
    public enum DatetimeType
    {
        Year,Month,Day
    }
    public enum OperationType
    {
        Add,Modify,Delete
    }
    public enum ModeType
    {
        Purchas,Sell,Stock
    }
    public enum DictType
    {
        GoodsType, GoodsUnit, ProviderType, Providers
    }
    public class DatetimeTreeEventArgs:EventArgs
    {
        public DatetimeType dateTimeType { get; set; }
        public string DatatimeString { get; set; }
    }
    public class GoodsSelledEventArgs : EventArgs
    {
        List<int> m_listSellNO = new List<int>();
        public List<int> listSellNO
        {
            get { return m_listSellNO; }
            set { m_listSellNO = value; }
        }
        private string m_SellTime = string.Empty;
        public string SellTime
        {
            get { return m_SellTime; }
            set { m_SellTime = value; }
        }
    }
    public class SelectGoodsEventArgs : EventArgs
    {
        public string GoodsName { get; set; }
    }
}
