using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Shop.Entities;
using Web.Shop.Models;
using Web.Shop.Repo.Interafaces;
using Web.Shop.Services.Interfaces;

namespace Web.Shop.Controllers
{
    public class NewsController : Controller
    {
        private readonly ILogger<NewsController> _logger;
        private readonly INewsService _newsService;

        public NewsController(ILogger<NewsController> logger,
            INewsService newsService)
        {
            _logger = logger;
            _newsService = newsService;
        }

        public async Task<IActionResult> Index(NewsFilterVM filter, int page=1)
        {
            var usersCount = HttpContext.Session.GetString("username");
            var model = _newsService.GetNews(filter, page);
            return View(model);
        }
        public async Task<IActionResult> Details(string slug)
        {
            var model = _newsService.GetNewsBySlug(slug);
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(NewsAddVM model)
        {
            if (ModelState.IsValid)
            {
                _newsService.AddNews(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }


    }
}
