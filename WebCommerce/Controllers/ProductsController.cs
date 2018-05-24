using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IActionResult> Index()
        {
            return View(await context.Products.ToListAsync());
        }

        public async Task<IActionResult> ViewProduct(int id)
        {
            return View(await context.Products.Where(p => p.Id == id).FirstOrDefaultAsync());
        }
    }
}