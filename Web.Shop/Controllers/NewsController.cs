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
            NewsVM model = new NewsVM();

            model.list = _newsRepos.GetPageList(page, 2);
            model.currentPage = page;
            model.minPage = 1;

            model.maxPage = (_newsRepos.GetCountItems() % 2 != 0) ? _newsRepos.GetCountItems() / 2 + 1 : _newsRepos.GetCountItems() / 2;

       
            return View(model);
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
