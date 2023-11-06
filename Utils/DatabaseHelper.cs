using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapHang.Utils
{
    internal class DatabaseHelper
    {

    public static SqlConnection GetConnection()
        {
            return new SqlConnection("Server=(local);Uid=sa;Pwd=123456;Database=KHOHANG;Connection Timeout=30;");

        }
    }
}

