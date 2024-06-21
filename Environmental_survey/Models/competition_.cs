using System.ComponentModel.DataAnnotations;
namespace Environmental_survey.Models
{

    public enum TypeCompetition
    {
        Cycling = 0, Cleaning = 1, Clean_Environment = 2

    }
    public class competition_
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

        public TypeCompetition Competiton_type { get; set; }

        public String MyCompetition(int competitonid)

        {

            if (competitonid == 0)
            {
                return "Cycling";
            }
            else if (competitonid == 1)
            {
                return "Cleaning";
            }
            else
            {
                return "Clean_Environment";
            }
        }
    }
}