using Microsoft.AspNetCore.Mvc;

namespace Asp_Net_Intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Test");
            //return Json(new {name = "Ibrahim", surname = "Aliyev"});

            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

            //int[] nums1 = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] nums2 = { 10, 2, 30, 4, 50, 6, 70 };

            //Data datas = new Data();
            //datas.Nums1 = nums1;
            //datas.Nums2 = nums2;

            //return View(datas);

            return View(nums);
        }






        //public string Index(int id)
        //{
        //    //return GetName();
        //    return $"Ali - {id}";
        //}
        
        //public string Detail(string slug, string name)
        //{
        //    return $"{slug} {name}";
        //}

        //private string GetName()
        //{
        //    return "Ali";
        //}
    }

    public class Data
    {
        public int[] Nums1 { get; set; }
        public int[] Nums2 { get; set; }
    }
}