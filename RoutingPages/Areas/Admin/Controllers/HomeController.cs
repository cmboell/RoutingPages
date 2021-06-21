using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//admin homepage
namespace RoutingPages.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Admin = "Now you can click on the admin default, custom, and custom attribute.";
            ViewBag.Home = "Click the home link to return to normal view";
            return View();
        }
    }
}
