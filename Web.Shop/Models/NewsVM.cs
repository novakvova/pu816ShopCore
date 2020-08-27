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
        public int Page { get; set; }
        public int maxPage { get; set; }
        public List<News> list { get; set; }
        public NewsFilterVM NewsFilter { get; set; }
    }

    public class NewsFilterVM
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name="Назва новини")]
        public string Name { get; set; }
       
    }

    public class NewsAddVM
    {
        [Display(Name = "Назва новини")]
        [Required(ErrorMessage ="Вкажіть назву")]
        public string Name { get; set; }

        [Display(Name = "URL Slug")]
        [Required(ErrorMessage = "Вкажіть slug")]
        public string UrlSlug { get; set; }

        [Display(Name = "Фото")]
        [Required(ErrorMessage = "Оберіть фото")]
        public string Image { get; set; }

        [Display(Name = "Опис")]
        [Required(ErrorMessage = "Вкажіть опис")]
        public string Description { get; set; }

    }

}
