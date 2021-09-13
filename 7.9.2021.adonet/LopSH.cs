using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kien_truc_huong_DV
{
    public class LopSH
    {
        public int ID_Lop { get; set; }
        public string NameLop { get; set; }
        public override string ToString()
        {
            return "NameLop = "+NameLop;
        }
    }
}