using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET
        public IActionResult Index()
        {
            IEnumerable<RegistrationModel> users = _db.Registrations;
            return View(users);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var registeredFromDb = _db.Registrations.Find(id);
            if (registeredFromDb == null)
            {
                return NotFound();
            }
            return View(registeredFromDb);
        }

        //POST
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Registrations.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Registrations.Remove(obj);
            _db.SaveChanges();
            TempData["Success"] = "User Deleted Successfully";
            return RedirectToAction("Index");
        }
    }

}

