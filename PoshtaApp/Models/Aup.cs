using System.ComponentModel.DataAnnotations;

namespace PoshtaApp.Models
{
    public class Aup
    {
        [Key]
        public int Id { get; set; }  // Унікальний ID

        [Required]
        [MaxLength(6)]
        public string Index { get; set; } = string.Empty;  // Поштовий індекс (INDEX_A)

        public string? CityId { get; set; }  // Код міста (CITY_KOD)
        public City? City { get; set; }  // Навігаційна властивість

        public string? CityName { get; set; }  // Назва міста (NCITY)

        public int? OblId { get; set; }  // Код області (OBL)
        public string? OblName { get; set; }  // Назва області (NOBL)

        public int? KrajId { get; set; }  // Код району (RAJ)
        public string? KrajName { get; set; }  // Назва району (NRAJ)
    }
}
