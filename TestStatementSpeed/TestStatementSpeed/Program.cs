using MySql.Data.MySqlClient;
using System;

namespace TestStatementSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=Session1;Uid='user';Pwd='1234'"))
            {
                string selectQuery = "select * from `member`;";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("good");
                    }
                    else
                    {
                        Console.WriteLine("nope");
                    }
                }
                catch (Exception e) {
                    Console.WriteLine(e.ToString());       
                }
                connection.Close();
            }
        }
    }
}