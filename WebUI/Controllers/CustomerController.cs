using System.Threading.Tasks;
using demo_clean_arc.Application.Interfaces;
using demo_clean_arc.Domain.Entities;
using demo_clean_arc.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace demo_clean_arc.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IRepository<Category> _repo;

        public CategoryController(IRepository<Category> repo)
        {
            _repo = repo;
        }

    }
}