using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//admin attribute controller
namespace RoutingPages.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomAttributeController : Controller
    {
        [Route("[area]/{Controller}/[action]/{id?}")]
        public IActionResult CustomAttribute(string id = "4")
        {
            return View();
        }
      
    }
}
