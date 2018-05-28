using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebCommerce.Models;

namespace WebCommerce.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user, string password)
        {
            var result = await userManager.CreateAsync(user, password);

            if(!result.Succeeded)
            {
                Console.WriteLine(result.Errors);
                return RedirectToAction("AccountFailure");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var result = await signInManager.PasswordSignInAsync(username, password, true, false);

            if (!result.Succeeded)
            {
                return RedirectToAction("AccountFailure");
            }

            return View();
        }

        public IActionResult AccountFailure()
        {
            return View();
        }
    }
}