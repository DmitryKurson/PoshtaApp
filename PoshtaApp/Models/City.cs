using PoshtaApp.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class City
{
    [Key]
    [MaxLength(20)]
    public string Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(5)]
    public int? RajId { get; set; }
    [ForeignKey("RajId")]
    public Raj? Raj { get; set; }


    [MaxLength(4)]
    public int? OblId { get; set; }
    [ForeignKey("OblId")]
    public Obl? Obl { get; set; }

    public List<Aup> Aups { get; set; } = new();
}
