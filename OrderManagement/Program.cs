using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OrderManagement
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); 
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OrderManagementForm());
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Oracle.ManagedDataAccess.Client;
//using Oracle.ManagedDataAccess.Types;
//using System.Data;
//namespace Oracle11gDemo2ManagedDataAccessdll
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                string connStr = "User Id=ST;Password=000000;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=202.205.84.114)(PORT=1521)))(CONNECT_DATA=(SID=ST)))";
//                using (var conn = new OracleConnection(connStr))
//                {
//                    conn.Open();
//                    DataSet ds = new DataSet();
//                    string sql = "select * from COMMON_PRODUCT";
//                    OracleDataAdapter oda = new OracleDataAdapter(sql, conn);
//                    oda.Fill(ds);
//                    DataTable dt = ds.Tables[0];
//                }
//            }
//            catch (OracleException ex)
//            {
//                throw new Exception(ex.Message);
//            }
//        }
//    }
//}