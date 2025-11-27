using genuineparts.Data;
using genuineparts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace genuineparts.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db; 
        public CategoryController(AppDbContext db) => _db = db;
        public IActionResult Result()
        {
            List <Category> categories = _db.Categories.ToList(); 
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Result");
            }
            return View();
        }
        
        
        
        
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0){return NotFound();}
            Category? categoryFromDb = _db.Categories.Find(id);
         //   Category? categoryFromDb1 = _db.Categories.FirstOrDefault(c => c.Id == id);
         // Category? categoryFromDb2 = _db.Categories.Where(c => c.Id == id).FirstOrDefault();
            if (categoryFromDb == null)
            {
                return NotFound();
                
            }
            return View(categoryFromDb);
        }
        

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Result");
            }
            return View();
        }
    }
}
