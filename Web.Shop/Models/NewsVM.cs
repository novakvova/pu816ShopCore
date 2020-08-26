using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Shop.Entities;

namespace Web.Shop.Models
{
    public class NewsVM
    {
        public int currentPage { get; set; }
        public int maxPage { get; set; }
        public List<News> list { get; set; }
        public NewsFilterVM NewsFilter { get; set; }
    }

    public class NewsFilterVM
    {
        public NewsFilterVM()
        {
            Page = 1;
        }
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name="Назва новини")]
        public string Name { get; set; }
        public int Page { get; set; }
    }

}
