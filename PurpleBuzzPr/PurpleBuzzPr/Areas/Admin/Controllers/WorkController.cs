using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleBuzzPr.DAL;
using PurpleBuzzPr.Models;

namespace PurpleBuzzPr.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;
        public WorkController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Work> works = await _context.Works.ToListAsync();

            return View(works);
        }
    }
}
