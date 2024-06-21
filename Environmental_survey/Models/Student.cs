using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Environmental_survey.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Std_Name { get; set; }

        [Required]
        public string Std_Roll_NO { get; set; }

        [Required]
        public string Std_Class { get; set; }

        [Required]
        public string Std_Specification { get; set; }

        [Required]
        public string Std_Section { get; set; }

        [Required]
        public DateTime Std_Admission_Date { get; set; }
    }
}
