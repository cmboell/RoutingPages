using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//custom route app
namespace RoutingPages.Controllers
{
    public class CustomController : Controller
    {
        public IActionResult Custom(int id = 3, string cat = "custom", int page = 1)
        {
            return View();
        }
        // you can type  //https://localhost:44346/Custom/Custom/3/custom/page1 in the browser and this page will show up
    }

}
