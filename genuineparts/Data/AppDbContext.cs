using Microsoft.EntityFrameworkCore;
using genuineparts.Models;  

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category{ Id = 1, Name = "japanese" , DisplayOrder = 1},
            new Category{Id =2 , Name = "Korean " , DisplayOrder = 2}, 
            new Category{Id = 3 , Name = "German" , DisplayOrder = 3}
            );
        }
    }
}