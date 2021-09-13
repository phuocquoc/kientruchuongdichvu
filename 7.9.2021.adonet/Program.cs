using System;
using MySql.Data.MySqlClient;

namespace Kien_truc_huong_DV
{
    class Program
    {
        static void Main(string[] args)
        {
            // const string connectionString =  "Server=127.0.0.1; database=kthdv; UID=root; password=khong123; SslMode = none";
            // MySqlConnection connection = new MySqlConnection(connectionString);
            // MySqlCommand command = new MySqlCommand() {
            //     Connection = connection
            // };

            // connection.Open();


            // command.CommandText = "SELECT * FROM lopsh";
            // var result = command.ExecuteReader();
            // while(result.Read()) {
            //     Console.Write(result["ID_Lop"]);
            //     Console.WriteLine(result["NameLop"]);
            // }

            // connection.Close();
            
            foreach (SV i in BUS_SV.instance.GetListSV())
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
