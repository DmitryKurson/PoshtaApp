using System.ComponentModel.DataAnnotations;

namespace PoshtaApp.Models
{
    public class Obl
    {
        [Key]
        public int Id { get; set; }  // Код області (OBL)

        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = string.Empty;  // Назва області (NOBL)

        public ICollection<City> Cities { get; set; } = new List<City>(); // Навігаційна властивість
    }
}
