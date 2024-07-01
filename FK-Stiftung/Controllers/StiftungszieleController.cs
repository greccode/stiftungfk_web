using Microsoft.AspNetCore.Mvc;

namespace FK_Stiftung.Controllers
{
    public class StiftungszieleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
