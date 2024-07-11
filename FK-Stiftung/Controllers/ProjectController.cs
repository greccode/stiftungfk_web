using FK_Stiftung.Data;
using FK_Stiftung.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FK_Stiftung.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public ProjectController(ApplicationDbContext db, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null && user.Email == "admin@faustkultur.de")
            {
                return RedirectToAction("Index2");
            }

            List<Project> objProjectList = _db.Projects.ToList();
            return View("Index", objProjectList);
        }

        public async Task<IActionResult> Index2()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null && user.Email == "admin@faustkultur.de")
            {
                List<Project> objProjectList = _db.Projects.ToList();
                return View("Index2", objProjectList);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project obj)
        {
            // Server-side validation
            if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("name", "Name and description cannot be exactly the same");
            }

            if (ModelState.IsValid)
            {
                _db.Projects.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Project? projectFromDb = _db.Projects.Find(id);
            if (projectFromDb == null)
            {
                return NotFound();
            }
            return View(projectFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Project obj)
        {
            if (ModelState.IsValid)
            {
                _db.Projects.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Project? projectFromDb = _db.Projects.Find(id);
            if (projectFromDb == null)
            {
                return NotFound();
            }
            return View(projectFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Project obj = _db.Projects.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Projects.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}