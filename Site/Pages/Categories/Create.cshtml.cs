using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Data;
using Site.Model; 
namespace Site.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public Category Category { get; set; } = new();

        public CreateModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            
        }
    }
}