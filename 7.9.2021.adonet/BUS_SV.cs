using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Kien_truc_huong_DV
{
    public class BUS_SV
    {
        private static BUS_SV _instance;
        public static BUS_SV instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUS_SV();
                }
                return _instance;
            }
            private set { }
        }

        public BUS_SV()
        {
            // _instance = new BUS_SV();
        }

        public List<SV> GetListSV()
        {
            return DAL_SV.instance.GETALLSV();
        }
    }
}