using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SqlForm
{
    public class MysqlConn
    {
        private readonly static string sqlConfig = "Database=world;Data Source=127.0.0.1;User Id=root;"+
            "Password=123456;CharSet=utf8;port=3306";

        public static DataTable ExecuteQuery(string queryStr)
        {
            MySqlCommand cmd;
            MySqlConnection conn;
            MySqlDataAdapter msda;
            conn = new MySqlConnection(sqlConfig);
            conn.Open();
            cmd = new MySqlCommand(queryStr, conn)
            {
                CommandType = CommandType.Text
            };
            DataTable dataTable = new DataTable();
            msda = new MySqlDataAdapter(cmd);
            msda.Fill(dataTable);
            conn.Close();
            return dataTable;
        }
    }
}
