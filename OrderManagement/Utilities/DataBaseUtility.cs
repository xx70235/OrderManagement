using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OrderManagement.Utilities
{
    class DataBaseUtility
    {
        public static DataTable DataSelect(string sqlstr)
        {
        try
            {
                string connStr = "User Id=ST;Password=000000;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=202.205.84.114)(PORT=1521)))(CONNECT_DATA=(SID=ST)))";
                using (var conn = new OracleConnection(connStr))
                {
                    conn.Open();
                    DataSet ds=new DataSet ();
                    //string sql="select * from DJCB_WZSJ";
                    OracleDataAdapter oda = new OracleDataAdapter(sqlstr, conn);
                    oda.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    return dt;
                }
            }
            catch (OracleException ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }




        public static void DataUpdate(string table,DataTable dt)
        {
            try
            {
                string connStr = "User Id=ST;Password=000000;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=202.205.84.114)(PORT=1521)))(CONNECT_DATA=(SID=ST)))";
                using (var conn = new OracleConnection(connStr))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    string sql="select * from "+table;
                    OracleDataAdapter oda = new OracleDataAdapter(sql, conn);
                    oda.Fill(ds);
                    //DataTable dt = ds.Tables[0];

                    OracleCommandBuilder mySqlCommandBuilder = new OracleCommandBuilder(oda);
                   // oda.Update(dt, table);\
                    oda.Update(dt);
                }
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DataDelete(string table, string column, string keyword)
        {
            try
            {
                string connStr = "User Id=ST;Password=000000;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=202.205.84.114)(PORT=1521)))(CONNECT_DATA=(SID=ST)))";
                using (var conn = new OracleConnection(connStr))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    string sql = "delete from " + table + " where " + column + "= '" + keyword + "'";
                    OracleCommand cmd = new OracleCommand(sql,conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static void DataInsert(string sqlstr)
        {
            try
            {
                string connStr = "User Id=ST;Password=000000;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=202.205.84.114)(PORT=1521)))(CONNECT_DATA=(SID=ST)))";
                using (var conn = new OracleConnection(connStr))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    //string sql="select * from DJCB_WZSJ";
                    OracleDataAdapter oda = new OracleDataAdapter(sqlstr, conn);
                    oda.Fill(ds);
                    DataTable dt = ds.Tables[0];
                }
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
