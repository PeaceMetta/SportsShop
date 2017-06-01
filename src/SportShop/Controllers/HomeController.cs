using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SportShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "关于";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "联系我们！";

            return View();
        }

        public IActionResult ShopCar()
        {
            return View();
        }

        public IActionResult Collect()
        {
            return View();
        }

        public IActionResult PersonInf()
        {
            return View();
        }
    

        public IActionResult Error()
        {
            return View();
        }
    }
}
