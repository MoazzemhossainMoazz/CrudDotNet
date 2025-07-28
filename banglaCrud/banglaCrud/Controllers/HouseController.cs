using banglaCrud.Data;
using Microsoft.AspNetCore.Mvc;

namespace banglaCrud.Controllers
{
    public class HouseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HouseController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
