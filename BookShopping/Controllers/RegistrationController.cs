using BookShopping.Data;
using BookShopping.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShopping.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _db;
        public RegistrationController(ApplicationDbContext db)
        {
                _db = db;
        }
        public IActionResult Index()
        {
            List<Book_Users> objUsersList = _db.Reg_Users.ToList();
            return View(objUsersList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book_Users obj)
        {
            if(obj.password != obj.re_password)
            {
                ModelState.AddModelError("re_password", "Both passwords should match");
            }

            if (ModelState.IsValid) {
                _db.Reg_Users.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
            
        }
    }
}
