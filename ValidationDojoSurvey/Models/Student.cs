using System.ComponentModel.DataAnnotations;
namespace ValidationDojoSurvey.Models
{
    public class Student
    {
        [Required]
        [MinLength(3)]
        public string FullName { get; set; }
        [Required(ErrorMessage="Location Required Fields")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Language Required Fields")]
        public string Language { get; set; }
        [Required]
        [MinLength(3)]
        public string Comment { get; set; }
    }
}