using Microsoft.AspNetCore.Mvc;

namespace Tasks.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            List<int> array = new List<int>();

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    array.Add(i);
                }
            }

            return View(array);
        }
    }
}