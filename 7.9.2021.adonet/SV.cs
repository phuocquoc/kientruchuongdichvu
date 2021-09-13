using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Kien_truc_huong_DV
{
    public class SV
    {
        public SV()
        {}
        public string MSSV {get; set; }
        public string Name {get; set; }
        public bool Gender {get; set;}
        public DateTime NS {get; set;}
        public double DTB {get; set;}
        public int ID_Lop {get; set;}

        public override string ToString()
        {
            string gender="";
            if (Gender == true)
                gender = "Nam";
            else
                gender = "Nu";
            return "MSSV :" + MSSV + ", Ho va Ten " +Name+", Gioi tinh: " +gender + ", Ngay Sinh :"+NS+",ĐTB :"+DTB+", ID_Lop:"+ID_Lop;
        }
    }
}