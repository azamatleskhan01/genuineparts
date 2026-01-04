using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Data;
using CategoryModel = Site.Model.Category;

namespace Site.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public List<CategoryModel> CategoryList { get; set; } = new();

        public IndexModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            CategoryList = _dbContext.Categories.ToList();
        }
    }
}