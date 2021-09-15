using System;
using System.Collections.Generic;

#nullable disable

namespace _14._9._2021.Model
{
    public partial class Sv
    {
        public string Mssv { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public DateTime Ns { get; set; }
        public float Dtb { get; set; }
        public int? IdLop { get; set; }

        public virtual Lopsh IdLopNavigation { get; set; }

        public override string ToString()
        {
            string gender="";
            if (Gender == 1)
                gender = "Nam";
            else
                gender = "Nu";
            return "MSSV :" + Mssv + ", Ho va Ten " +Name+", Gioi tinh: " +gender + ", Ngay Sinh :"+Ns+",ĐTB :"+Dtb+", ID_Lop:"+IdLop;
        }
    }
}
