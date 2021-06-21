using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//admin custom page
namespace RoutingPages.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomController : Controller
    {                               //attributes for custom page
        public IActionResult Custom(int id = 3, string cat = "custom", int page = 1)
        {
            return View();
        }
    }
    
}
