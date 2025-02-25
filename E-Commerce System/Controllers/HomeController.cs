using System.Diagnostics;
using E_Commerce_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContex _context;

        public HomeController(MyDbContex context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index() 
        {
         var Showprod = await _context.Products.ToListAsync();
            return View(Showprod);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
