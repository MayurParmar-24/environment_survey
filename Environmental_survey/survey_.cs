using System.ComponentModel.DataAnnotations;

namespace Environmental_survey
{
    public class survey_
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
    }
}
