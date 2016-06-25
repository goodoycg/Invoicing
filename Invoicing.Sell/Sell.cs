using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Invoicing.Common;

namespace Invoicing.Sell
{
    public class Sell
    {
        public int SellNO { get; set; }
        public string OutTime { get; set; }
        public int GoodsNO { get; set; }
        public int OutCount { get; set; }        
        public decimal OutPrice { get; set; }
        public string Remarks { get; set; }
        public int OrderNO { get; set; }
        public Sell()
        {
            MaxNO();
        }
        public bool Save()
        {
            OleDbConnection conn = Foundation.CreateInstance();
            OleDbTransaction trans = conn.BeginTransaction();

            string strSql = @"insert into Sell(sellno,outtime,goodsno,outcount,outprice,remarks,orderno,useing) ";
            strSql += "values(@sellno,@outtime,@goodsno,@outcount,@outprice,@remarks,@orderno,@useing);";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@sellno", SellNO);
            cmd.Parameters.AddWithValue("@outtime", OutTime);
            cmd.Parameters.AddWithValue("@goodsno", GoodsNO);
            cmd.Parameters.AddWithValue("@outcount", OutCount);
            cmd.Parameters.AddWithValue("@outprice", OutPrice);
            cmd.Parameters.AddWithValue("@remarks", Remarks);
            cmd.Parameters.AddWithValue("@orderno", OrderNO);
            cmd.Parameters.AddWithValue("@useing", 1);
            cmd.Transaction = trans;

            string strSql2 = @"update purchas set outcount = outcount + @outcount where goodsno=@goodsno;";
            OleDbCommand cmd2 = new OleDbCommand(strSql2, conn);            
            cmd2.Parameters.AddWithValue("@outcount", OutCount);
            cmd2.Parameters.AddWithValue("@goodsno", GoodsNO);
            cmd2.Transaction = trans;
            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                trans.Commit();
                return true;
            }
            catch(System.Exception err)
            {
                Console.Write(err.Message + err.StackTrace);
                trans.Rollback(); 
                return false;
            }
        }

        private void MaxNO()
        {
            string strSql = @"select max(sellno) from Sell;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            object o = cmd.ExecuteScalar();
            if (o == DBNull.Value)
            {
                this.SellNO = 1;
            }
            else
            {
                this.SellNO = 1 + Convert.ToInt32(o);
            }
        }
        
        public bool Update()
        {////修改销售记录：先取消一条销售(以SellNO为准)再增加一条销售记录(以其它信息为准为准)

            OleDbConnection conn = Foundation.CreateInstance();           

            string strSql0 = "select * from sell where sellno=@sellno";
            OleDbCommand cmd0 = new OleDbCommand(strSql0, conn);
            cmd0.Parameters.AddWithValue("@sellno", SellNO);
            OleDbDataAdapter a = new OleDbDataAdapter(cmd0);
            DataSet ds = new DataSet();
            a.Fill(ds);
            object oOutCount = ds.Tables[0].Rows[0]["outcount"].ToString();
            object oGoodsNO  = ds.Tables[0].Rows[0]["goodsno"].ToString();

            OleDbTransaction trans = conn.BeginTransaction();
            //遣消
            string strSql = @"update Purchas set outcount=outcount-@outcount where goodsno=@goodsno";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@outcount", oOutCount);
            cmd.Parameters.AddWithValue("@goodsno", oGoodsNO);
            cmd.Transaction = trans;
            //再修改进货记录，看GoodsNO　oGoodsNO是否相同，确定是否为同一条记录
            string strSql2 = @"update Purchas set outcount=outcount+@outcount where goodsno=@goodsno";
            OleDbCommand cmd2 = new OleDbCommand(strSql2, conn);
            cmd2.Parameters.AddWithValue("@outcount", OutCount);
            cmd2.Parameters.AddWithValue("@goodsno", GoodsNO);
            cmd2.Transaction = trans;
            //修改销售记录
            string strSql3 = @"update sell set goodsno=@goodsno,outcount=@outcount,outprice=@outprice where sellno=@sellno";
            OleDbCommand cmd3 = new OleDbCommand(strSql3, conn);
            cmd3.Parameters.AddWithValue("@goodsno", GoodsNO);
            cmd3.Parameters.AddWithValue("@outcount", OutCount);
            cmd3.Parameters.AddWithValue("@outprice", OutPrice);
            cmd3.Parameters.AddWithValue("@sellno", SellNO);
            cmd3.Transaction = trans;

            try
            {
                cmd.ExecuteNonQuery();               
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                trans.Commit();
                return true;
            }
            catch
            {
                trans.Rollback();
                return false;
            }
        }

        public bool Delete()
        {
            OleDbConnection conn = Foundation.CreateInstance();
            OleDbTransaction trans = conn.BeginTransaction();

            string strSql = @"delete from Sell where sellno = @sellno";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@sellno", SellNO);
            cmd.Transaction = trans;

            string strSql2 = @"update purchas set outcount = outcount - @outcount where goodsno=@goodsno;";
            OleDbCommand cmd2 = new OleDbCommand(strSql2, conn);
            cmd2.Parameters.AddWithValue("@outcount", OutCount);
            cmd2.Parameters.AddWithValue("@goodsno", GoodsNO);
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
