using E_Commerce_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_System.Controllers
{
    public class AdminController : Controller
    {

        private readonly MyDbContex _context;

        public AdminController(MyDbContex context)
        {
            _context = context;
        }


        public IActionResult Dashboard() 
        {
         return View();
        }


        public async Task<IActionResult> Users() 
        {
            var Userveiw = await _context.Users.ToListAsync();

           return View(Userveiw);
        }


        public IActionResult CreateUser() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Users");
        }


        [HttpGet]
        public async Task<IActionResult> EditUser(int id) 
        {
            var Editeusers = await _context.Users.FindAsync(id);
            return View(Editeusers);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Users");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Users");
        }
    }
}
