using FK_Stiftung.Data;
using FK_Stiftung.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FK_Stiftung.Controllers
{
    public class ProjektFoerdererController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public ProjektFoerdererController(ApplicationDbContext db, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
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
            List<ProjektFoerderer> objProjektFoerdererList = _db.ProjektFoerderer.ToList();
            return View("Index", objProjektFoerdererList);
        }

        public async Task<IActionResult> Index2()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null && user.Email == "admin@faustkultur.de")
            {
                List<ProjektFoerderer> objProjektFoerdererList = _db.ProjektFoerderer.ToList();
                return View("Index2", objProjektFoerdererList);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProjektFoerderer obj)
        {
            if (ModelState.IsValid)
            {
                _db.ProjektFoerderer.Add(obj);
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
            ProjektFoerderer? projektFoerdererFromDb = _db.ProjektFoerderer.Find(id);
            if (projektFoerdererFromDb == null)
            {
                return NotFound();
            }
            return View(projektFoerdererFromDb);
        }

        [HttpPost]
        public IActionResult Edit(ProjektFoerderer obj)
        {
            if (ModelState.IsValid)
            {
                _db.ProjektFoerderer.Update(obj);
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
            ProjektFoerderer? projektFoerdererFromDb = _db.ProjektFoerderer.Find(id);
            if (projektFoerdererFromDb == null)
            {
                return NotFound();
            }
            return View(projektFoerdererFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            ProjektFoerderer obj = _db.ProjektFoerderer.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.ProjektFoerderer.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}