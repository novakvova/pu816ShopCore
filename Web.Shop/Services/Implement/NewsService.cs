using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Web.Shop.Entities;
using Web.Shop.Models;
using Web.Shop.Repo.Interafaces;
using Web.Shop.Services.Interfaces;

namespace Web.Shop.Services.Implement
{
    public class NewsService : INewsService
    {
        private readonly INewsRepo _newsRepo;
        public NewsService(INewsRepo newsRepo)
        {
            _newsRepo = newsRepo;
        }
        public NewsVM GetNews(NewsFilterVM filter, int page)
        {
            NewsVM model = new NewsVM();
            int pageSize = 2;
            var query = _newsRepo.GetAll();

            if (!string.IsNullOrEmpty(filter.Name))
                query = query.Where(x => x.Name.Contains(filter.Name));
            if (filter.Id != 0)
                query = query.Where(x => x.Id == filter.Id);

            int pageNo = page;
            model.list = query.OrderBy(x => x.Id)
                .Skip(pageNo * pageSize)
                .Take(pageSize)
                .ToList();

            int allCount = query.Count();
            model.Page = page;
            model.maxPage = (int)Math.Ceiling((double)allCount / pageSize);

            model.NewsFilter = filter;

            return model;
        }
    }
}
