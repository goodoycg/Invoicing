using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Invoicing.Common;

namespace Invoicing.Other
{
    public class Recording
    {
        public int RecordNO { get; set; }
        public string RecordDateTime { get; set; }       
        public decimal Charge { get; set; }       
        public string Operman { get; set; }
        public string Remarks { get; set; }

        public Recording()
        {
            RecordNO = this.MaxGoodsNO() + 1;
        }
        public bool Save()
        {
            string strSql = @"insert into Recording(recordno,recorddatetime,charge,operman,remarks) ";
            strSql += @"values(@recordno,@recorddatetime,@charge,@operman,@remarks);";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());

            cmd.Parameters.AddWithValue("@recordno", RecordNO);
            cmd.Parameters.AddWithValue("@recorddatetime", RecordDateTime);
            cmd.Parameters.AddWithValue("@charge", Charge);
            cmd.Parameters.AddWithValue("@operman", Operman);            
            cmd.Parameters.AddWithValue("@remarks", Remarks);

            return cmd.ExecuteNonQuery() > 0;
        }
        private int MaxGoodsNO()
        {
            string strSql = @"select max(RecordNO) from Recording;";
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
            string strSql = @"update Recording set charge=@charge,operman=@operman,remarks=@remarks,recorddatetime=@recorddatetime where recordno=@recordno;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@charge", Charge);
            cmd.Parameters.AddWithValue("@operman", Operman);
            cmd.Parameters.AddWithValue("@remarks", Remarks);
            cmd.Parameters.AddWithValue("@recorddatetime", RecordDateTime);
            cmd.Parameters.AddWithValue("@recordno", RecordNO);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete()
        {

            string strSql = @"delete from Recording where recordno=@recordno;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@recordno", RecordNO);
            return cmd.ExecuteNonQuery() > 0;

        }

        public void Query(int RecordNO)
        {
            DataSet ds = Foundation.ReadDataSet("select * from Recording where recordno = " + RecordNO.ToString());
            this.RecordNO = RecordNO;
            this.RecordDateTime = ds.Tables[0].Rows[0]["recorddatetime"].ToString();
            this.Charge = Convert.ToDecimal(ds.Tables[0].Rows[0]["charge"].ToString());
            this.Operman = ds.Tables[0].Rows[0]["operman"].ToString();
            this.Remarks = ds.Tables[0].Rows[0]["remarks"].ToString();

        }
    }
}
