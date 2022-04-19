using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFirst.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult About()//Aboute file view
        {
            return View();
        }
        //added 
        public IActionResult Contact()//Contact file that u do not have
        {
            return View();
        }
        public IActionResult Projects()//Projects file that u do not have
        {
            return View();
        }
    }
}
