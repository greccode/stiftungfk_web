using Microsoft.AspNetCore.Mvc;

namespace FK_Stiftung.Controllers
{
    public class Stiftungsziele : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
