using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Kien_truc_huong_DV
{
    public class DAL_SV
    {
        private static DAL_SV _instance;
        public static DAL_SV instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DAL_SV();
                }
                return _instance;
            }
            private set { }
        }
        private DAL_SV()
        {
        }
        public SV GetSV(DataRow dr)
        {
            return new SV
            {
                MSSV = dr["MSSV"].ToString(),
                Name = dr["Name"].ToString(),
                Gender = Convert.ToBoolean(dr["Gender"]),
                NS = (DateTime)dr["NS"],
                DTB = Convert.ToDouble(dr["DTB"]),
                ID_Lop = Convert.ToInt32(dr ["ID_Lop"])
                //ID_Lop = getclass(dr ["ID_Lop"].ToString())
            };
        }
        public List<SV> GETALLSV()
        {
            List<SV> list = new List<SV>();
            string query="select * from sv";
            foreach (DataRow dr in DataProvider.instance.GetRecord(query).Rows)
            {
                list.Add(GetSV(dr));
            }
            return list;
        }

        public void AddSV (SV sv)
        {
            string query="insert into sv values ('"+sv.MSSV+"','"+sv.Name+"','"+sv.Gender+"','"+sv.NS+"','"+sv.DTB+"','"+sv.ID_Lop+"')";
            DataProvider.instance.ExecuteDB(query);
        }

        public string getclass(string idclass)
        {
            string query="SELECT NameLop FROM lopsh WHERE ID_Lop ='"+idclass+"'";
            return DataProvider.instance.ExecuteDB_class(query);
        }
    }
}