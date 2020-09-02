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
        private readonly ILogger<CategoriesController> _logger;
        private readonly ICategoryRepo _categoryRepos;
        private readonly ApplicationDbContext _context;

        public CategoriesController(ILogger<CategoriesController> logger,
            ICategoryRepo categoryRepos, ApplicationDbContext context)
        {
            _logger = logger;
            _categoryRepos = categoryRepos;
            _context = context;
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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryAddVM model)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category()
                {
                    Name = model.Name,
                    Image = model.Image,
                    UrlSlug = model.UrlSlug,
                    DateCreate = DateTime.Now
                };
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }


    }
}
