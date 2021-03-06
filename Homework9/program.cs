using System;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Configuration;
using System.Data;
namespace Ordertest
{
    class MysqlTool
    {

        private static MySqlConnection con;
        private static MySqlCommand com;
		
        public static void ConnectMysql(string sql)
        {
            con = new MySqlConnection(sql);
            
			
            Console.WriteLine("连接成功");
            com = new MySqlCommand();
            com.Connection = con;
            
			
        }
		）
        public static void AddMysql(int id, string name, string client)
        {
            string sql = "insert("+id+"," + name + "," + client + ")";
            com.CommandText = sql;
            if (com.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("操作成功");
            }
        }
        public static void UpdateMysql(int lookIndex, string lookContent, int changeIndex, string changecontent)
        {

            string lookColumn = "";
            switch (lookIndex)
            {
                case 1:
                    lookColumn = "id";
                    break;
                case 2:
                    lookColumn = "name";
                    break;
                case 3:
                    lookColumn = "client";
                    break;
            }

            string changeColumn = "";
            switch (lookIndex)
            {
                case 1:
                    changeColumn = "id";
                    break;
                case 2:
                    changeColumn = "name";
                    break;
                case 3:
                    changeColumn = "client";
                    break;
            }

            string sql = "Update order set" +changeColumn+ " = " + changecontent + "where" + lookColumn + "=" + lookContent;
            com.CommandText = sql;
            if (com.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("操作成功");
            }
        }
		
        public static void ReadMysql(int lookIndex, string lookContent)
        {
            string lookColumn = "";
            switch (lookIndex)
            {
                case 1:
                    lookColumn = "id";
                    break;
                case 2:
                    lookColumn = "name";
                    break;
                case 3:
                    lookColumn = "client";
                    break;
            }
            string sql = "select * from student where" + lookColumn + "=" + lookContent;
            com.CommandText = sql;
            MySqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                if (read.HasRows)
                {
                    Console.WriteLine(read.GetString(0) + ", " + read.GetString(1));
                }
            }
        }
		
        public static void OpenMysql()
        {
            con.Open();
        }
		
        public static void CloseMysql()
        {
            con.Close();
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
				
                MysqlTool.ConnectMysql("server=localhost;User Id=root;password=123456;Database=ordertest");
                MysqlTool.OpenMysql();
				
                while (true)
                {
                    Console.WriteLine("请选择：1. 增加订单 2. 查询订单 3. 更该订单");
                    int choice = Convert.ToInt16(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("请输入增加订单id(整数)");
                            int id = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("请输入增加订单名字");
                            string name = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("请输入增加订单客户名");
                            string client = Convert.ToString(Console.ReadLine());
                            MysqlTool.AddMysql(id, name, client);
                            break;

                        case 2:
                            Console.WriteLine("1. 按id查询, 2. 按订单名查询， 3. 按客户名查询");
                            int lookIndex = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("请选择");
                            string lookContent = Console.ReadLine();
                            MysqlTool.ReadMysql(lookIndex, lookContent);
                            break;

                        case 3:
                            Console.WriteLine("1. 按id查询, 2. 按订单名查询， 3. 按客户名查询");
                            int lookIndex3 = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("请选择");
                            string lookContent3 = Console.ReadLine();
                            Console.WriteLine("1. 更改id, 2.更改名字， 3.更改客户名");
                            int changeIndex = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("更改后的内容");
                            string changeContent = Convert.ToString(Console.ReadLine());
                            break;
                    }
                }
            }
            finally
            {
                MysqlTool.CloseMysql();
            }
            
        }
    }
}