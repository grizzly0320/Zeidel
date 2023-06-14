using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zeidel
{
    public class BDConnector
    {
        private static SqlConnection? connector;
        public BDConnector(string server, string database)
        {
            string connectionString = $"Server={server};Database={database};Trusted_Connection=True;";
            connector = new SqlConnection(connectionString);
            connector?.Open();
        }

        public Account Select(string column, string value)
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE {column}=N\'{value}\';", connector);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return new Account((int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2));
                    }
                }
                else
                {
                    throw new Exception("Пользователя с такими данными не существует");
                }
            }
            throw new Exception("Что-то пошло не так");
        }

        public bool CheckAccount(string column, string value)
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE {column}=N\'{value}\';", connector);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Пользователя с такими данными уже существует");
                }
            }
            throw new Exception("Что-то пошло не так");
        }

        public Account Insert(string name, string password)
        {
            SqlCommand cmd = new SqlCommand($"INSERT Users VALUES (N\'{name}\', N\'{password}\');", connector);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand($"SELECT id FROM Users WHERE [Name] = N\'{name}\';", connector);
            int id = 0;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id  = (int)reader.GetValue(0);
                }
            }
            return new Account(id, name, password);
        }
    }
}
