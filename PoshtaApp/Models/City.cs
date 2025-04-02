using System.ComponentModel.DataAnnotations;

namespace PoshtaApp.Models
{
    public class City
    {
        [Key]
        [MaxLength(20)]
        public string Id { get; set; } = string.Empty;  // Код міста (CITY_KOD)

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;  // Назва міста (CITY)

        public int? KrajId { get; set; }  // Код району (може бути NULL)
        public Raj? Kraj { get; set; }  // Навігаційна властивість

        public int OblId { get; set; }  // Код області (OBL)
        public Obl Obl { get; set; } = null!;  // Навігаційна властивість
    }

}
