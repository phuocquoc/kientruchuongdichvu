using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppStudent.MVC.Models
{

    [Table("Class_SV")]
    public class Class_SV
    {
        [Key]
        public int ID_Lop { get; set; }
        [Required]
        [StringLength(200)]
        public string NameLop
        {
            get; set;
        }

    }
}