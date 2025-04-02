using System.ComponentModel.DataAnnotations;

namespace PoshtaApp.Models
{
    public class Obl
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = string.Empty;

        public ICollection<City> Cities { get; set; } = new List<City>();
        public ICollection<Raj> Rajs { get; set; } = new List<Raj>();  // <=== Додано зв’язок "Область – Райони"

    }
}
