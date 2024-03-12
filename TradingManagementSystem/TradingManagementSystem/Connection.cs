using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TradingManagementSystem
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\do an lap trinh win\TradingManagementSystem\TradingManagementSystem\Database1.mdf"";Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
