using Microsoft.EntityFrameworkCore;
using Site.Model;

namespace Site.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "japanese", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Korean", DisplayOrder = 2 },
                new Category { Id = 3, Name = "German", DisplayOrder = 3 }
            );
        }
    }
}