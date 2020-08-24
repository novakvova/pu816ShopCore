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
using Web.Shop.Repo.Interafaces;

namespace Web.Shop.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryRepo _categoryRepos;

        public CategoriesController(ILogger<HomeController> logger,
            ICategoryRepo categoryRepos)
        {
            _logger = logger;
            _categoryRepos = categoryRepos;
        }

        public async Task<IActionResult> Index()
        {
            var list = _categoryRepos.GetAll().ToList();
            //await _categoryRepos.Add(
            //    new Category()
            //    {
            //        Id
            //    });
            return View(list);
        }

        
    }
}
