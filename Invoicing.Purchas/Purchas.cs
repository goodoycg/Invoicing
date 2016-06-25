using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Invoicing.Common;

namespace Invoicing.Purchas
{
    public class Purchas :EventArgs
    {
        public int GoodsNO { get; set; }
        public string InTime { get; set; }
        public string GoodsName { get; set; }
        public string GoodsCode { get; set; }

        public int InCount { get; set; }
        public decimal InPrice { get; set; }
        public decimal FixPrice { get; set; }
        public int OutCount { get; set; }

        public int UnitNO { get; set; }
        public int TypeNO { get; set; }
        public int ProviderNO { get; set; }

        public string UnitName { get; set; }
        public string TypeName { get; set; }
        public string ProviderName { get; set; }

        public string Remarks { get; set; }
        public Purchas()
        {
            GoodsNO = this.MaxGoodsNO() + 1;
        }
        public Purchas(int goodsNO)
        {
            GoodsNO = goodsNO;
            DataSet ds = Common.Foundation.GetGoodsPurchas(goodsNO);
            this.InTime = ds.Tables[0].Rows[0]["InTime"].ToString();
            this.GoodsName = ds.Tables[0].Rows[0]["GoodsName"].ToString();
            this.GoodsCode = ds.Tables[0].Rows[0]["GoodsCode"].ToString();

            this.InCount = Convert.ToInt32(ds.Tables[0].Rows[0]["InCount"].ToString());
            this.InPrice = Convert.ToDecimal(ds.Tables[0].Rows[0]["InPrice"].ToString());
            this.FixPrice = Convert.ToDecimal(ds.Tables[0].Rows[0]["FixPrice"].ToString());
            this.OutCount = Convert.ToInt32(ds.Tables[0].Rows[0]["OutCount"].ToString());

            this.UnitNO = Convert.ToInt32(ds.Tables[0].Rows[0]["UnitNO"].ToString());
            this.TypeNO = Convert.ToInt32(ds.Tables[0].Rows[0]["TypeNO"].ToString());
            this.ProviderNO = Convert.ToInt32(ds.Tables[0].Rows[0]["ProviderNO"].ToString());

            this.UnitName = Common.Foundation.GetDictName(DictType.GoodsUnit,ds.Tables[0].Rows[0]["UnitNO"].ToString());
            this.TypeName = Common.Foundation.GetDictName(DictType.GoodsType,ds.Tables[0].Rows[0]["TypeNO"].ToString());
            this.ProviderName = Common.Foundation.GetDictName(DictType.Providers, ds.Tables[0].Rows[0]["ProviderNO"].ToString());

            this.Remarks = ds.Tables[0].Rows[0]["Remarks"].ToString();
        }

        public bool Save()
        {
            string strSql = @"insert into Purchas(goodsno,intime,goodsname,goodscode,unitno,typeno,providerno,incount,inprice,outcount,remarks,fixprice) ";
            strSql += @"values(@goodsno,@intime,@goodsname,@goodscode,@unitno,@typeno,@providerno,@incount,@inprice,@outcount,@remarks,@fixprice);";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            
            cmd.Parameters.AddWithValue("@goodsno", GoodsNO);
            cmd.Parameters.AddWithValue("@intime", InTime);
            cmd.Parameters.AddWithValue("@goodsname", GoodsName);
            cmd.Parameters.AddWithValue("@goodscode", GoodsCode);

            cmd.Parameters.AddWithValue("@unitno", UnitNO);
            cmd.Parameters.AddWithValue("@typeno", TypeNO);
            cmd.Parameters.AddWithValue("@providerno", ProviderNO);

            cmd.Parameters.AddWithValue("@incount", InCount);
            cmd.Parameters.AddWithValue("@inprice", InPrice);
            cmd.Parameters.AddWithValue("@outcount", 0);
            cmd.Parameters.AddWithValue("@remarks", Remarks);
            cmd.Parameters.AddWithValue("@fixprice", FixPrice);

            return cmd.ExecuteNonQuery() > 0;
        }
        private int MaxGoodsNO()
        {
            string strSql = @"select max(goodsno) from Purchas;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            object o = cmd.ExecuteScalar();
            if (o == DBNull.Value)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(o);
            }
        }
        public bool Update()
        {
            string strSql = @"update Purchas set goodsname=@goodsname,goodscode=@goodscode,incount=@incount,inprice=@inprice,remarks=@remarks,fixprice=@fixprice,unitno=@unitno,typeno=@typeno,providerno=@providerno where goodsno=@goodsno;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@goodsname", GoodsName);
            cmd.Parameters.AddWithValue("@goodscode", GoodsCode);

            cmd.Parameters.AddWithValue("@incount", InCount);
            cmd.Parameters.AddWithValue("@inprice", InPrice);
            cmd.Parameters.AddWithValue("@remarks", Remarks);
            cmd.Parameters.AddWithValue("@fixprice", FixPrice);

            cmd.Parameters.AddWithValue("@unitno", UnitNO);
            cmd.Parameters.AddWithValue("@typeno", TypeNO);
            cmd.Parameters.AddWithValue("@providerno", ProviderNO);


            cmd.Parameters.AddWithValue("@goodsno", GoodsNO);

            return cmd.ExecuteNonQuery() > 0;
        }
        public bool Delete()
        {
            
            OleDbConnection conn = Foundation.CreateInstance();
            OleDbTransaction trans = conn.BeginTransaction();

            string strSql = @"delete from Purchas where goodsno = @goodsno";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@goodsno", GoodsNO);
            cmd.Transaction = trans;
           

            string strSql2 = @"delete from Sell where goodsno = @goodsno2";
            OleDbCommand cmd2 = new OleDbCommand(strSql2, conn);
            cmd2.Parameters.AddWithValue("@goodsno2", GoodsNO);
            cmd2.Transaction = trans;
            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                trans.Commit();
                return true;
            }
            catch
            {
                trans.Rollback();
                return false;
            }            
            
        }               
    }
}
