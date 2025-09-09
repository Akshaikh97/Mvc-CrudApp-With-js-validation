using System.ComponentModel.DataAnnotations;

namespace Project3._2.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public bool? IsActive { get; set; }
        public State? State { get; set; }
        public int? StateId { get; set; }
        public City? City { get; set; }
        public int? CityId { get; set; }
    }
}
