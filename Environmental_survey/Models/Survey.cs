using System.ComponentModel.DataAnnotations;

namespace Environmental_survey.Models
{
    public class Survey
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public string SurveyImage { get; set; }
        
    }
}
