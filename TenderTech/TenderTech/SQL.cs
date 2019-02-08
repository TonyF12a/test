using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenderTech
{
    static class SQL
    {
        private static MySqlConnection connection = new MySqlConnection(
            "Database=tendertech;" +
            "Data Source=10.100.10.66;" +
            "User Id=anton;" +
            "Password=fynjyy");

        static public void Connect()
        {
            connection.Open();

            connection.Close();
        }
    }
}
