using Microsoft.EntityFrameworkCore;

namespace Project3._2.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>  options): base(options) { }
        public DbSet<Employee>? Employee { get; set; }
        public DbSet<State>? State { get; set; }
        public DbSet<City>? City { get; set; }
    }
}
