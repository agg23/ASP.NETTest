using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebCommerce.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewProduct(string id)
        {
            // Force pass model overload
            return View((Object) id);
        }
    }
}