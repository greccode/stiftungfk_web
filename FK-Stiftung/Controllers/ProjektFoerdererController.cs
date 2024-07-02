using Microsoft.AspNetCore.Mvc;

namespace FK_Stiftung.Controllers
{
    public class ProjektFoerdererController : Controller
    {
        public IActionResult Index()
        {
            List<ProjektFoerderer> names = _db.ProjektFoerderer.ToList();
            return View(names);
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
        public IActionResult Edit(ProjektFoerderer names)
        {
            //server-side validation
            /*if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("name", "Name und Beschreibung können nicht exakt gleich sein");
            }*/

            if (ModelState.IsValid)
            {
                _db.ProjektFoerderer.Update(names);
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
            ProjektFoerderer names = _db.ProjektFoerderer.Find(id);
            if (names == null)
            {
                return NotFound();
            }
            _db.ProjektFoerderer.Remove(names);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
