using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic.Logic;
using Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
    public class HomeController : Controller
    {
        private StateSingleton state;

        public HomeController(StateSingleton state)
        {
            this.state = state;
        }

        public IActionResult Index()
        {
            return View(state.data);
        }

        [HttpPost]
        public IActionResult AddData(ModelData data)
        {
            state.data.Add(data);

            Console.WriteLine("AddData");

            return RedirectToAction("Index");
        }
    }
}