using System.ComponentModel.DataAnnotations;

namespace Environmental_survey.Models
{
    public class faculty
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]

        public string Password { get; set; }

        [Required]  

        public string Education { get; set; }

        [Required]

        public string facultyimg { get; set; }
    }
}
