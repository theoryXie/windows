using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SqlForm
{
    class MysqlUtil
    {

        private static MySqlConnection conn;//连接
        private static MySqlTransaction mytran;//事务
        private static string config;//配置


        /// <summary>
        /// mysql数据库连接
        /// </summary>
        /// <returns></returns>
        public static void Config(string dataSource, string port, string user, string pwd)
        {
            config = "Data Source=" + dataSource + ";User Id=" + user + ";" +
            "Password=" + pwd + ";CharSet=utf8;port=" + port+";";
        }

        /// <summary>
        /// 获取连接下所有数据库的名字
        /// </summary>
        /// <returns></returns>
        public static List<string> GetDataBases()
        {
            List<string> dataBases = new List<string>();

            conn = new MySqlConnection(config);
            conn.Open();

            string sql = "show databases;";
            MySqlCommand command = new MySqlCommand(sql,conn);
            
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    dataBases.Add(reader[0].ToString());
                }
            }
            conn.Close();
            return dataBases;
        }


        /// <summary>
        /// 获取数据库下所有表的名字
        /// </summary>
        /// <param name="db">数据库名</param>
        /// <returns></returns>
        public static List<string> GetTablesByDB(string db)
        {
            List<string> tables = new List<string>();

            conn = new MySqlConnection(config+ "Database="+db);
            conn.Open();

            string sql = "show tables;";
            MySqlCommand command = new MySqlCommand(sql, conn);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    tables.Add(reader[0].ToString());
                }
            }
            conn.Close();
            return tables;
        }


        //获取数据库表的所有字段和类型
        public static Dictionary<string,string> GetColName(string db, string table)
        {
            MySqlCommand cmd;
            MySqlDataReader reader;
            Dictionary<string, string> columns = new Dictionary<string, string>();

            conn = new MySqlConnection(config + "Database=" + db);
            conn.Open();

            string sql = "show columns from " + table + " ;";
            
            cmd = new MySqlCommand(sql, conn);
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string column_name = reader.GetString(0);
                        string column_type = reader.GetString(1);
                        columns.Add(column_name, column_type);
                    }
                }
                reader.Close();
                conn.Close();
                return columns;
            }
            catch (Exception e) {                
                return null;
            }
        }


        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="db"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public static DataTable ExecuteAll(string db, string table)
        {
            MySqlCommand cmd;
            MySqlConnection conn;
            MySqlDataAdapter msda;
            conn = new MySqlConnection(config + "Database=" + db);
            conn.Open();
            cmd = new MySqlCommand("select * from " + table, conn)
            {
                CommandType = CommandType.Text
            };
            DataTable dataTable = new DataTable();
            msda = new MySqlDataAdapter(cmd);
            msda.Fill(dataTable);
            conn.Close();
            return dataTable;
        }


        /// <summary>
        /// 根据主键删除数据
        /// </summary>
        /// <param name="db">数据库</param>
        /// <param name="table">表</param>
        /// <param name="idName">主键名</param>
        /// <param name="id">主键值</param>
        public static void DelById(string db, string table, string idName, string id)
        {
            MySqlCommand cmd;
            MySqlConnection conn;
            conn = new MySqlConnection(config + "Database=" + db);
            conn.Open();
            mytran = conn.BeginTransaction();//开启事务
            try
            {
                cmd = new MySqlCommand("delete from " + table + " where " + idName + " = " + id, conn);
                cmd.Transaction = mytran;
                cmd.ExecuteNonQuery();
                mytran.Commit();//提交数据库事务
            }catch(Exception e)
            {
                mytran.Rollback();//事务回滚
                throw new Exception("delete error：" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }


        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="db">数据库名</param>
        /// <param name="table">表名</param>
        /// <param name="args">参数列表</param>
        public static void Insert(string db, string table, List<string> args)
        {
            MySqlCommand cmd;
            MySqlConnection conn;
            conn = new MySqlConnection(config + "Database=" + db);
            conn.Open();
            mytran = conn.BeginTransaction();//开启事务
            try
            {
                StringBuilder columns = new StringBuilder();//需要插入的列 
                StringBuilder values = new StringBuilder();//需要插入的数值
                Dictionary<string, string> columnsNameAndType = GetColName(db, table);

                for (int i = 0; i < columnsNameAndType.Count(); i++)
                {
                    string column_name = columnsNameAndType.ElementAt(i).Key;//字段名
                    string column_type = columnsNameAndType.ElementAt(i).Value;//字段类型

                    if (args[i].Equals(""))
                        continue ;
               
                    if (column_type.IndexOf("char") > 0)//字符串类型
                    {
                        args[i] = "'" + args[i] + "'";
                    }

                    if (i == args.Count() - 1)
                    {
                        values.Append(args[i]);
                        columns.Append(column_name);
                    }
                    else
                    {
                        values.Append(args[i] + ",");
                        columns.Append(column_name + ",");
                    }
                }
                //构造插入语句
                string sql = "insert into " + table + "(" + columns.ToString() + ")" + "values (" + values.ToString() + ")";
                //执行               
                cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = mytran;
                cmd.ExecuteNonQuery();
                mytran.Commit();
            }catch(Exception e)
            {
                mytran.Rollback();
                throw new Exception("insert error：" + e.Message);
            }
            finally
            {
                //关闭连接
                conn.Close();
            }            
        }


        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="db"></param>
        /// <param name="table"></param>
        /// <param name="args"></param>
        public static void Update(string db, string table, List<string> args)
        {
            MySqlCommand cmd;
            MySqlConnection conn;
            conn = new MySqlConnection(config + "Database=" + db);
            conn.Open();
            mytran = conn.BeginTransaction();
            try
            {
                StringBuilder values = new StringBuilder();//需要插入的数值
                Dictionary<string, string> columns = GetColName(db, table);//字段名和值
                string idName = columns.ElementAt(0).Key;//id名
                string id = args[0];//id

                for (int i = 0; i < args.Count(); i++)
                {
                    string column_name = columns.ElementAt(i).Key;//字段名
                    string column_type = columns.ElementAt(i).Value;//字段类型
                    if (i == 0)
                        continue;
                    if (column_type.IndexOf("char") > 0)//字符串类型
                    {
                        args[i] = "'" + args[i] + "'";
                    }
                    if (i == args.Count() - 1)
                        values.Append(column_name + "=" + args[i]);
                    else
                        values.Append(column_name + "=" + args[i] + ",");
                }

                //构造插入语句
                string sql = "update " + table + " set " + values + " where " + idName + " = " + id;
                //执行
                cmd = new MySqlCommand(sql, conn);
                cmd.Transaction = mytran;
                cmd.ExecuteNonQuery();
                mytran.Commit();
            }
            catch(Exception e)
            {
                mytran.Rollback();
                throw new Exception("insert error：" + e.Message);
            }
            finally
            {
                //关闭连接
                conn.Close();
            }
            
        }


    }
}
