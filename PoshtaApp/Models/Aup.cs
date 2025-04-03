using PoshtaApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Aup
{
    [Key]
    [MaxLength(10)]
    public int Id { get; set; }

    [Required]
    [MaxLength(6)]
    public string Index { get; set; } = string.Empty;

    // Foreign Key на Cities
    [MaxLength(20)]
    public string? CityId { get; set; }
    [ForeignKey("CityId")]
    public City? City { get; set; }
    [MaxLength(200)]
    public string? CityName { get; set; }


    // Foreign Key на Oblasti
    [MaxLength(4)]
    public int? OblId { get; set; }
    [ForeignKey("OblId")]
    public Obl? Obl { get; set; }

    [MaxLength(200)]
    public string? OblName { get; set; }


    // Foreign Key на Rais
    [MaxLength(5)]
    public int? RajId { get; set; }
    [ForeignKey("RajId")]
    public Raj? Raj { get; set; }
    [MaxLength(200)]
    public string? RajName { get; set; }
}
