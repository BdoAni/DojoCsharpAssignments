using System;
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]

        public int DishId { get; set; }

        [Required(ErrorMessage = "is required")]
        [MaxLength(45, ErrorMessage = "must no longer than 45 characters")]
        [Display(Name = "Name of Dish")]
        public string Name { get; set; }
        [Required(ErrorMessage = "is required")]
        [MaxLength(45, ErrorMessage = "must no longer than 45 characters")]
        [Display(Name = "Chef's Name")]
        public string Chef{ get; set; }
        [Required(ErrorMessage = "is required")]
        [Range(1,5, ErrorMessage = "must more than 1 characters")]
        [Display(Name = "Tastiness")]
        public int Tastiness { get; set; }
        [Required(ErrorMessage = "is required")]
        [Range(1,9999, ErrorMessage = "must more than 1 characters")]
        [Display(Name = "# of Calories")]
        public int Calories { get; set; }

        [Required(ErrorMessage = "is required")]
        [Display(Name = "Description")]
        public int Description{ get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}