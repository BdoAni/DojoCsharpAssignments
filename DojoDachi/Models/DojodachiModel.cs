using System.ComponentModel.DataAnnotations;
namespace DojoDachi.Models
{
    public class DojodachiModel
    {
        public DojodachiModel(int fullness, int happiness, int energy, int meals)
        {
            this.fullness = fullness;
            this.happiness = happiness;
            this.energy = energy;
            this.meals = meals;

        }
        public int fullness { get; set; }
        [Required]
        public int happiness { get; set; }
        [Required]
        public int energy { get; set; }
        [Required]
        public int meals { get ; set ; }
        public DojodachiModel()
        {
            fullness = 20;
            happiness = 20;
            energy = 50;
            meals = 3;

        }
    }
}