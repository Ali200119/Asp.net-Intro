using Microsoft.AspNetCore.Mvc;

namespace Asp_Net_Intro.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            //return Content("About");
            return View();
        }
    }
}