using Microsoft.AspNetCore.Mvc;

namespace genuineparts.Controllers;

public class CategoryController:Controller
{
    public IActionResult Result()
    {
        return View(); 
    }
}