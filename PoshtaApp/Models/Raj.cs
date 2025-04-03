using System.ComponentModel.DataAnnotations;

namespace PoshtaApp.Models
{
    public class Raj
    {
        [Key]
        [MaxLength(5)]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; } = string.Empty;
        public ICollection<City> Cities { get; set; } = new List<City>();
    }
}