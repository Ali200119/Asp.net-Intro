using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tasks.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Index()
        {
            int[] array = new int[12];
            array[0] = 0;
            array[1] = 1;

            return View(array);
        }
    }
}