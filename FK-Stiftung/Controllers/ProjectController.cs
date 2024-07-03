using FK_Stiftung.Data;
using FK_Stiftung.Models;
using Microsoft.AspNetCore.Mvc;

namespace FK_Stiftung.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProjectController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Project> objProjectList = _db.Projects.ToList();
            return View(objProjectList);
        }

        public IActionResult Index2()
        {
            List<Project> objProjectList = _db.Projects.ToList();
            return View(objProjectList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project obj)
        {
            //server-side validation
            if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("name", "Name und Beschreibung können nicht exakt gleich sein");
            }

            if (ModelState.IsValid)
            {
                _db.Projects.Add(obj);
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

            Project? projectFromDb = _db.Projects.Find(id);
            // Other ways to retrieve data from the database
            //  Project? projectFromDb1 = _db.Projects.FirstOrDefault(u => u.Id == id);
            //   Project? projectFromDb2 = _db.Projects.Where(u => u.Id == id).FirstOrDefault();

            if (projectFromDb == null)
            {
                return NotFound();
            }
            return View(projectFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Project obj)
        {
            //server-side validation
            /*if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("name", "Name und Beschreibung können nicht exakt gleich sein");
            }*/

            if (ModelState.IsValid)
            {
                _db.Projects.Update(obj);
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

            Project? projectFromDb = _db.Projects.Find(id);
            // Other ways to retrieve data from the database
            //  Project? projectFromDb1 = _db.Projects.FirstOrDefault(u => u.Id == id);
            //   Project? projectFromDb2 = _db.Projects.Where(u => u.Id == id).FirstOrDefault();

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