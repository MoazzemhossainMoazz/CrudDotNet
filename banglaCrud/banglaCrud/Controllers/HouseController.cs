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


        [HttpGet]

        public IActionResult getHouseList()
        {
            var data = _context.houses.ToList();
            return View(data);
        }

        public IActionResult editHouse(int id)
        {
            var data = _context.houses.Where(x => x.houseId == id).FirstOrDefault();
            return View(data);
        }
    }
}
