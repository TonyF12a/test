﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MySqlCommand command_login = new MySqlCommand($"SELECT login FROM users WHERE login='{login}'", connection);
            string login_in_base = command_login.ExecuteScalar().ToString();
            if (login_in_base != login)
            {
                MySqlCommand command_reg = new MySqlCommand($"INSERT INTO users VALUES(id, '{login}', '{pass}', '{id}')", connection);
                command_reg.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
