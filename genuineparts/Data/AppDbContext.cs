using Microsoft.EntityFrameworkCore;
using genuineparts.Models; // подключаем модели

namespace genuineparts.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }  
    }
}