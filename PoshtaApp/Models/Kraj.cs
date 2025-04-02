using System.ComponentModel.DataAnnotations;

namespace PoshtaApp.Models
{
    public class Kraj
    {
        [Key]
        public int Id { get; set; }  // Код району (KRAJ)

        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = string.Empty;  // Назва району (NRAJ)

        public ICollection<City> Cities { get; set; } = new List<City>(); // Навігаційна властивість
    }
}
