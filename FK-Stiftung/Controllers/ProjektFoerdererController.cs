using FK_Stiftung.Data;
using FK_Stiftung.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Policy;

namespace FK_Stiftung.Controllers
{
    public class ProjektFoerdererController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/
        private readonly ApplicationDbContext _db;
        public ProjektFoerdererController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<ProjektFoerderer> donors = _db.ProjektFoerderer.ToList();
            return View(donors);
        }
        public IActionResult Index2()
        {
            List<ProjektFoerderer> donors = _db.ProjektFoerderer.ToList();
            return View(donors);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProjektFoerderer names)
        {
            if (ModelState.IsValid)
            {
                _db.ProjektFoerderer.Add(names);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // pause

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            ProjektFoerderer? nameFromDb = _db.ProjektFoerderer.Find(id);
            // Other ways to retrieve data from the database
            //  Project? projectFromDb1 = _db.Projects.FirstOrDefault(u => u.Id == id);
            //   Project? projectFromDb2 = _db.Projects.Where(u => u.Id == id).FirstOrDefault();

            if (nameFromDb == null)
            {
                return NotFound();
            }
            return View(nameFromDb);
        }

        [HttpPost]
        public IActionResult Edit(ProjektFoerderer name)
        {
            //server-side validation
            /*if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("name", "Name und Beschreibung können nicht exakt gleich sein");
            }*/

            if (ModelState.IsValid)
            {
                _db.ProjektFoerderer.Update(name);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        // pause
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            ProjektFoerderer? nameFromDb = _db.ProjektFoerderer.Find(id);
            // Other ways to retrieve data from the database
            //  Project? projectFromDb1 = _db.Projects.FirstOrDefault(u => u.Id == id);
            //   Project? projectFromDb2 = _db.Projects.Where(u => u.Id == id).FirstOrDefault();

            if (nameFromDb == null)
            {
                return NotFound();
            }
            return View(nameFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            ProjektFoerderer name = _db.ProjektFoerderer.Find(id);
            if (name == null)
            {
                return NotFound();
            }
            _db.ProjektFoerderer.Remove(name);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}
