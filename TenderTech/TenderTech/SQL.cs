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

        static public void Register(string login, string pass, string id)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand($"INSERT INTO users VALUES(id, '{login}', '{pass}', '{id}')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        static public string Login(string login, string pass)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand($"SELECT pass FROM users WHERE login='{login}'", connection);
            string values = command.ExecuteScalar().ToString();
            connection.Close();
            return values;
        }
    }
}
