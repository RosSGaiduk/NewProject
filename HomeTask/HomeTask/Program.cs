using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Entity;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection mysqlConnection = null;
            try
            {
                string myConnectionString = "Database=chemistry_book;Data Source=localhost;User Id=root;Password=123456root";
                mysqlConnection = new MySqlConnection(myConnectionString);
                Console.WriteLine("connected");
            }
            catch (MySqlException e)
            {
                Console.Write("Error:" + e.ToString());
            }

            MySqlCommand command = mysqlConnection.CreateCommand();
            command.CommandText = "Select * from pagewithtext";

            try
            {
                mysqlConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString()+","+reader[1].ToString()+","+reader[2].ToString());
                i++;
            }

            Console.Write(i);
            Console.ReadKey();
        }
    }
}
