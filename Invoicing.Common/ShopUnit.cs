using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Invoicing.Common
{
    public class ShopUnit
    {
        public int UnitNO { get; set; }
        public string UnitName { get; set; }
        public ShopUnit()
        {
            NewUnitNO();
        }
        public bool Save()
        {
            OleDbConnection conn = Foundation.CreateInstance();
            string strSql = @"insert into GoodsUnit(UnitNO,UnitName) values(@UnitNO,@UnitName);";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@UnitNO", UnitNO);
            cmd.Parameters.AddWithValue("@UnitName", UnitName);
            return cmd.ExecuteNonQuery() > 0;
        }
        public void NewUnitNO()
        {
            string strSql = @"select max(UnitNO) from GoodsUnit;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            object o = cmd.ExecuteScalar();
            if (o == DBNull.Value)
            {
                this.UnitNO = 1;
            }
            else
            {
                this.UnitNO = 1 + Convert.ToInt32(o);
            }
        }
        public bool Update()
        {
            string strSql = @"update  GoodsUnit set UnitName=@UnitName where UnitNO = @UnitNO;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());            
            cmd.Parameters.AddWithValue("@UnitName", UnitName);
            cmd.Parameters.AddWithValue("@UnitNO", UnitNO);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete()
        {
            OleDbConnection conn = Foundation.CreateInstance();

            string strSql = @"delete from GoodsUnit where UnitNO = @UnitNO";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@UnitNO", UnitNO);
            return cmd.ExecuteNonQuery() > 0;  
        }
        public void ListUnit(ListView listview)
        {
            listview.Items.Clear();
            string strSql = @"select * from GoodsUnit;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    listview.Items.Add(new ListViewItem(new string[] { 
                        (listview.Items.Count + 1).ToString().PadLeft(3 ,' '), 
                        dr["UnitName"].ToString() }) { 
                        Tag = dr["UnitNO"].ToString() });
                }
            }
        }
        public static void ListUnit(ComboBox box)
        {
            box.Items.Clear();
            string strSql = @"select * from GoodsUnit;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    box.Items.Add(new ComboBoxItem(dr["UnitName"].ToString(),dr["UnitNO"].ToString()));
                }
            }
        }
    }
}
