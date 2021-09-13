using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Kien_truc_huong_DV
{
    public class DataProvider
    {
        MySqlConnection cnn;
        static DataProvider _instance;
        public static DataProvider instance
        {
            get
            {
                if (_instance == null)
                {
                    const string str_cnn = "Server=127.0.0.1; database=kthdv; UID=root; password=khong123; SslMode = none";
                    _instance = new DataProvider(str_cnn);
                }
                return _instance;
            }
            private set { }
        }
        private DataProvider (string cnn_string)
        {
            cnn = new MySqlConnection(cnn_string);
        }
        public void ExecuteDB (string query)
        {
            MySqlCommand cmd = new MySqlCommand(query,cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public string ExecuteDB_class (string query)
        {
            string class_sv="";
            MySqlCommand cmd = new MySqlCommand(query,cnn);
            cnn.Open();
            var result = cmd.ExecuteReader();
            while(result.Read())
            {
                class_sv = Convert.ToString(result["NameLop"]);
            }
            return class_sv;
        }
        public DataTable GetRecord (string query)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter data = new MySqlDataAdapter(query,cnn);
            cnn.Open();
            data.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}