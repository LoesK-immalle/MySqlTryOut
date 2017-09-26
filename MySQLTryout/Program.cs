using System;
using MySql.Data.MySqlClient;
namespace MySQLTryout
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=192.168.56.101; Port=3306; Database=worlds; Uid=imma; Pwd=ImmaPwd;";


            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = "SELECT COUNT(*) FROM CountryLanguage"
            };

            conn.Open();

            int aantalTalen = Convert.ToInt32(cmd.ExecuteScalar());

            Console.WriteLine("Aantal talen : {0}", aantalTalen);

        }
    }
}
