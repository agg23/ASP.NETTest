using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCommerce.Models;

namespace WebCommerce.Controllers
{
    public class ProductsController : Controller
    {
        public DatabaseContext context;

        public ProductsController(DatabaseContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Products.ToList());
        }

        public IActionResult ViewProduct(string id)
        {
            // Force pass model overload
            return View((Object) id);
        }
    }
}