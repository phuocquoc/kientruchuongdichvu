using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _14._9._2021_1
{
    [Table ("LopSinhVien")]
    public class LOPSH
    {
        public LOPSH()
        {
            SVs = new HashSet<SV>();
        }
        [Key]
        public int ID_Lop { get; set; }
        public string NameLop { get; set; }
        public virtual ICollection<SV> SVs { get; set; }
    }
}