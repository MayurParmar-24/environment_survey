using System.ComponentModel.DataAnnotations;

namespace Environmental_survey.Models
{
    public class user
    {


        [Key]

        public int Id { get; set; }

        [Required]
        public string Group_Name { get; set; }

        [Required]
        public string Group_Email { get; set; }

        [Required]
        public string Group_Contact { get; set; }

        [Required]
        public string Group_Address { get; set; }

        [Required]
        public string Num_Of_prpoles { get; set; }

    }
}
