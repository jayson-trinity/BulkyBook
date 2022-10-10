using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;


        public AccountController(ApplicationDbContext db)
        {
            _db = db;
        }


        //REGISTER

        //GET
        public IActionResult Register()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegistrationModel register)
        {

            if (ModelState.IsValid)
            {
                _db.Registrations.Add(register);
                _db.SaveChanges();
                TempData["Success"] = "Registration Successful";
                return RedirectToAction("Login");
            }
            return View(register);

        }

        //LOGIN

        //GET
        public IActionResult Login()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string email, string password)
        {
            if (ModelState.IsValid)
            {
                   
            }
            return View();
        }
    }
}
