using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Invoicing.Common
{
    public class Providers
    {
        public int ProviderNO { get; set; }
        public string ProviderName { get; set; }
        public int ProviderType { get; set; }
        public string Header { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Code { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string Remarks { get; set; }
        public Providers()
        {
            NewProviderNO();
        }
       
        public bool Save()
        {
            string strSql = @"insert into Providers(ProviderNO,ProviderName,ProviderType,Header,Tel,Email,WebSite,Code,Fax,Address,Remarks)";
            strSql += " values(@ProviderNO,@ProviderName,@ProviderType,@Header,@Tel,@Email,@WebSite,@Code,@Fax,@Address,@Remarks);";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@ProviderNO", ProviderNO);
            cmd.Parameters.AddWithValue("@ProviderName", ProviderName);
            cmd.Parameters.AddWithValue("@ProviderType", ProviderType);
            cmd.Parameters.AddWithValue("@Header", Header);
            cmd.Parameters.AddWithValue("@Tel", Tel);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@WebSite", WebSite);
            cmd.Parameters.AddWithValue("@Code", Code);
            cmd.Parameters.AddWithValue("@Fax", Fax);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Remarks", Remarks);           

            return cmd.ExecuteNonQuery() > 0;
        }
        private void NewProviderNO()
        {
            string strSql = @"select max(ProviderNO) from Providers;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            object o = cmd.ExecuteScalar();
            if (o == DBNull.Value)
            {
                ProviderNO = 1;
            }
            else
            {
                ProviderNO = 1 + Convert.ToInt32(o);
            }
        }
        public bool Update()
        {
            string strSql = @"update Providers set ProviderName=@ProviderName,ProviderType=@ProviderType,Header=@Header,";
            strSql += " Tel=@Tel,Email=@Email,WebSite=@WebSite,Code=@Code,Fax=@Fax,Address=@Address,Remarks=@Remarks where ProviderNO=@ProviderNO;";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            
            cmd.Parameters.AddWithValue("@ProviderName", ProviderName);
            cmd.Parameters.AddWithValue("@ProviderType", ProviderType);
            cmd.Parameters.AddWithValue("@Header", Header);
            cmd.Parameters.AddWithValue("@Tel", Tel);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@WebSite", WebSite);
            cmd.Parameters.AddWithValue("@Code", Code);
            cmd.Parameters.AddWithValue("@Fax", Fax);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Remarks", Remarks);
            cmd.Parameters.AddWithValue("@ProviderNO", ProviderNO);

            return cmd.ExecuteNonQuery() > 0;
        }
        public bool Delete()
        {
            OleDbConnection conn = Foundation.CreateInstance();
            OleDbTransaction trans = conn.BeginTransaction();

            string strSql = @"delete from Providers where ProviderNO = @ProviderNO";
            OleDbCommand cmdDeleteP = new OleDbCommand(strSql, conn);
            cmdDeleteP.Parameters.AddWithValue("@ProviderNO", this.ProviderNO);
            cmdDeleteP.Transaction = trans;

            string strSqlUpdate = @"update Purchas set providerno = 0 where providerno = @ProviderNO";
            OleDbCommand cmdUpdate = new OleDbCommand(strSqlUpdate, conn);
            cmdUpdate.Parameters.AddWithValue("@ProviderNO", this.ProviderNO);
            cmdUpdate.Transaction = trans;

            try
            {
                cmdDeleteP.ExecuteNonQuery();
                cmdUpdate.ExecuteNonQuery();
                trans.Commit();
                return true;
            }
            catch
            {
                trans.Rollback();
                return false;
            }                       
        }

        public static void ListProviders(ListView listView)
        {
            string strSql = @"select *,(select TypeDesc from ProviderType where Providers.ProviderType=ProviderType.TypeNO) as ProviderTypeName from Providers where ProviderNO>0";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            listView.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                listView.Items.Add(new ListViewItem(new string[] {(listView.Items.Count + 1).ToString().PadLeft(3 ,' '), 
                    dr["ProviderName"].ToString(), 
                    dr["ProviderTypeName"].ToString(), 
                    dr["Header"].ToString(), 
                    dr["Tel"].ToString(), 
                    dr["Email"].ToString(), 
                    dr["WebSite"].ToString(),
                    dr["Code"].ToString(),
                    dr["Fax"].ToString(),
                    dr["Address"].ToString(),
                    dr["Remarks"].ToString()}
                    ) { Tag = dr["ProviderNO"].ToString() });
                
            }
        }
        public static void ListProviders(ComboBox box)
        {
            string strSql = @"select ProviderNO,ProviderName from Providers";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
           
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                box.Items.Add(new ComboBoxItem(dr["ProviderName"].ToString(), dr["ProviderNO"].ToString()));
            }
        }
        public static void ListProviders(TreeView tree)
        {
            string strSql = @"select ProviderNO,ProviderName from Providers";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            tree.Nodes.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                tree.Nodes.Add(new TreeNode(dr["ProviderName"].ToString()) { Tag = dr["ProviderNO"].ToString() });
            }
            tree.ExpandAll();
        }
        public static void LoadProviderTypeList(ListView lvType)
        {
            string strSql = @"select * from ProviderType where TypeNO > 0";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
          
            int iIndex = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                lvType.Items.Add(new ListViewItem(new string[] { iIndex++.ToString(), dr["TypeDesc"].ToString() }) { Tag = dr["TypeNO"].ToString() });
            }
           
        }
        public static void LoadProviderType(ListView box)
        {
            box.Items.Clear();
            string strSql = @"select * from ProviderType where TypeNO > 0  order by TypeNO asc";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                box.Items.Add(
                    new ListViewItem(
                        new string[] { 
                            (box.Items.Count + 1).ToString().PadLeft(3 ,' '), 
                            dr["TypeDesc"].ToString() }) { Tag = dr["TypeNO"].ToString() });
            }

        }
        public static void LoadProviderType(ComboBox box)
        {
            box.Items.Clear();
            string strSql = @"select * from ProviderType order by TypeNO asc";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ComboBoxItem cbb;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cbb = new ComboBoxItem(dr["TypeDesc"].ToString(), dr["TypeNO"].ToString());
                box.Items.Add(cbb);
            }
            
        }
       
        private static int NewProviderTypeNO()
        {
            string strSql = @"select max(TypeNO) from ProviderType;";
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
        public static int AddProviderType(string ProviderTypeName)
        {
            string strSql = @"insert into ProviderType(TypeNO,TypeDesc)";
            strSql += " values(@TypeNO,@TypeDesc);";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            int iReturn = NewProviderTypeNO();
            cmd.Parameters.AddWithValue("@TypeNO", iReturn);
            cmd.Parameters.AddWithValue("@TypeDesc", ProviderTypeName);          


            if (cmd.ExecuteNonQuery() > 0)
            {
                return iReturn;
            }
            else
            {
                return 0;
            }
        }
        public static bool ModifyProviderType(string ProviderTypeNO, string ProviderTypeName)
        {
            string strSql = @"update ProviderType set TypeDesc=@TypeDesc where TypeNO=@TypeNO";

            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@TypeDesc", ProviderTypeName);
            cmd.Parameters.AddWithValue("@TypeNO", ProviderTypeNO);
           
            return cmd.ExecuteNonQuery() > 0;
           
        }
        public static bool DeleteProviderType(string ProviderTypeNO)
        {
            string strSql = @"delete from ProviderType where TypeNO = @TypeNO";
            OleDbCommand cmd = new OleDbCommand(strSql, Foundation.CreateInstance());
            cmd.Parameters.AddWithValue("@TypeNO", ProviderTypeNO);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
