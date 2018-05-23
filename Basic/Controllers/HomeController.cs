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
            ViewBag.EditModelAction = "AddData";
            return View(state.data);
        }

        [HttpPost]
        public IActionResult AddData(ModelData data)
        {
            data.Id = System.Guid.NewGuid().ToString();
            state.data.Add(data);

            Console.WriteLine("AddData");

            return RedirectToAction("Index");
        }

        public IActionResult Edit(string Id)
        {
            ViewBag.EditModelAction = "EditData";

            var data = state.data.Where(d => d.Id == Id).FirstOrDefault();

            if(data == null)
            {
                // TODO: Handle error in some way
                return RedirectToAction("Index");
            }

            Console.WriteLine(data.Text);
            return View("EditModelData", data);
        }

        [HttpPost]
        public IActionResult EditData(string Id, ModelData data)
        {
            var oldData = state.data.Where(d => d.Id == data.Id).FirstOrDefault();

            if (oldData == null)
            {
                // TODO: Handle error in some way
                return RedirectToAction("Index");
            }

            oldData.Text = data.Text;
            oldData.Active = data.Active;

            return RedirectToAction("Index");
        }
    }
}