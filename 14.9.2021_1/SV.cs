using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _14._9._2021_1
{
    [Table ("Sinh Vien")]
    public class SV
    {
        [Key]
        public string Mssv { get; set; }
        public string Name { get; set; }
        public double DTB { get; set; }
        public int ID_Lop { get; set; }
        [ForeignKey ("ID_Lop")]
        public virtual LOPSH lopsh { get; set; }
    }
}