using Microsoft.AspNetCore.Mvc;

namespace FK_Stiftung.Controllers
{
    public class OnlinemagazinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
