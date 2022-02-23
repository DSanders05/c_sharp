using Microsoft.EntityFrameworkCore;

namespace chefs_dishes.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Dish> Dishes {get;set;}
        public DbSet<Chef> Chefs {get;set;}
    }
}