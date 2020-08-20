using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Shop.Entities;
using Web.Shop.Models;

namespace Web.Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<DbUser> _userManager; 

        public HomeController(ILogger<HomeController> logger, UserManager<DbUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
           
        }

        public IActionResult Index()
        {
            var list = _userManager.Users.Select(u => new UserVM
            {
                Id = u.Id,
                Email = u.Email
            }).ToList();
            
           
            _logger.LogWarning("Привіт. Це home -> index :)");
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
