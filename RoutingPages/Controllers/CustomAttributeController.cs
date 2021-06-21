using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//custom attribute page
namespace RoutingPages.Controllers
{
    public class CustomAttributeController : Controller
    {
        [Route("AttributePage/{Controller}/[action]/{id?}")]
        public IActionResult CustomAttribute(int id = 4)
        {
            
            return View();
        }
      
    }
}

