using System.ComponentModel.DataAnnotations;

namespace Environmental_survey.Models
{
    public class FaQs
    {
        [Key]
        public int id { get; set; }


        [Required]
        public string Question { get; set; }
        [Required]
        public string Answer { get; set; }
    }
}
