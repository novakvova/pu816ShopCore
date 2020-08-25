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
    public class NewsController : Controller
    {
        private readonly ILogger<NewsController> _logger;
        private readonly INewsRepo _newsRepos;

        public NewsController(ILogger<NewsController> logger,
            INewsRepo newsRepos)
        {
            _logger = logger;
            _newsRepos = newsRepos;
        }

        public async Task<IActionResult> Index(int page=1)
        {
            var list = _newsRepos.GetPageList(page);
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
        public IActionResult Create(News news)
        {
            news.DateCreate = DateTime.Now;
            _newsRepos.Add(news);
            return RedirectToAction("Index");
        }


    }
}
