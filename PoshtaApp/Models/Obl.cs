using System.ComponentModel.DataAnnotations;

namespace PoshtaApp.Models
{
    public class Obl
    {
        [Key]
        [MaxLength(4)]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; } = string.Empty;
        // Навігаційна властивість для зв'язку з містами
        public ICollection<City> Cities { get; set; } = new List<City>();
    }
}
