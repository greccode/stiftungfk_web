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
            List<Project> objProjectList= _db.Projects.ToList();
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
    }
}
