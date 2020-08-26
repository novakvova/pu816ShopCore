using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Shop.Entities;

namespace Web.Shop.Models
{
    public class NewsVM
    {
        public int currentPage { get; set; }
        public int minPage { get; set; }
        public int maxPage { get; set; }
        public List<News> list { get; set; }

    }
}
