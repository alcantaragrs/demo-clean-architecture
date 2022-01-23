using System.Threading.Tasks;
using demo_clean_arc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace demo_clean_arc.WebUI.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var categories = await _categoryService.GetCategories();
            return View(categories);
        }

    }
}
