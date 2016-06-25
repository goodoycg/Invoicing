using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Invoicing.Common
{
    public class GoodsType
    {
        public int TypeNO { get; set; }
        public string TypeName { get; set; }
        public GoodsType()
        {
            NewTypeNO();
        }
        public bool Save()
        {
            OleDbConnection conn = Foundation.CreateInstance();
            string strSql = @"insert into GoodsType(TypeNO,TypeName) values(@TypeNO,@TypeName);";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@TypeNO", TypeNO);
            cmd.Parameters.AddWithValue("@TypeName", TypeName);
            return cmd.ExecuteNonQuery() > 0;
        }
        public void NewTypeNO()
        {
            string strSql = @"select max(TypeNO) from GoodsType;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            object o = cmd.ExecuteScalar();
            if (o == DBNull.Value)
            {
                this.TypeNO = 1;
            }
            else
            {
                this.TypeNO = 1 + Convert.ToInt32(o);
            }
        }
        public bool Update()
        {
            string strSql = @"update  GoodsType set TypeName=@TypeName where TypeNO = @TypeNO;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@TypeName", TypeName);
            cmd.Parameters.AddWithValue("@TypeNO", TypeNO);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete()
        {
            OleDbConnection conn = Foundation.CreateInstance();

            string strSql = @"delete from GoodsType where TypeNO = @TypeNO";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.Parameters.AddWithValue("@TypeNO", TypeNO);
            return cmd.ExecuteNonQuery() > 0;  
        }
        public void ListType(ListView listview)
        {
            listview.Items.Clear();
            string strSql = @"select * from GoodsType;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    listview.Items.Add(
                        new ListViewItem(
                            new string[] { 
                                (listview.Items.Count + 1).ToString().PadLeft(3 ,' '),
                                dr["TypeName"].ToString() })
                                { Tag = dr["TypeNO"].ToString() });
                }
            }
        }
        public static void ListType(ComboBox box)
        {
            box.Items.Clear();
            string strSql = @"select * from GoodsType;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    box.Items.Add(new ComboBoxItem(dr["TypeName"].ToString(), dr["TypeNO"].ToString()));
                }
            }
        }
        public static void ListType(TreeView tree)
        {
            tree.Nodes.Clear();
            string strSql = @"select * from GoodsType;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                tree.Nodes.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    tree.Nodes.Add(new TreeNode(dr["TypeName"].ToString()) { Tag = dr["TypeNO"].ToString() });
                }
                tree.ExpandAll();
            }
        }
    }
}
