using System.ComponentModel.DataAnnotations;

namespace Project3._2.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? StateId { get; set; }
    }
}
