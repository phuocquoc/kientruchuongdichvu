using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppStudent.MVC.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string name { get; set; }
        [Required]
        [StringLength(200)]
        public string email { get; set; }

        [Required]
        [Display(Name = "Name Lop")]
        public int ID_Lop { get; set; }
        [ForeignKey("ID_Lop")]
        public virtual Class_SV Class_SV { get; set; }
    }
}
