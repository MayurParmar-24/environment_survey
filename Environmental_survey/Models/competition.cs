using System.ComponentModel.DataAnnotations;

namespace Environmental_survey.Models
{
    public class competition
    {

        [Key]
        public int id { get; set; }

        [Required]
        public string Competition_name { get; set; }
        [Required]
        public string Competition_startdate { get; set; }

        [Required]
        public string Competition_enddate { get; set; }


        [Required]
        public string Competition_location { get; set; }


        [Required]

        public string Competiton_type { get; set; }
    }
}
