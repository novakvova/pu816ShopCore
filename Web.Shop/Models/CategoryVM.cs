using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Shop.Entities;

namespace Web.Shop.Models
{
    public class CategoryAddVM
    {
        [Display(Name = "Назва категорії")]
        [Required(ErrorMessage ="Вкажіть назву")]
        public string Name { get; set; }

        [Display(Name = "URL Slug")]
        [Required(ErrorMessage = "Вкажіть slug")]
        public string UrlSlug { get; set; }

        [Display(Name = "Фото")]
        [Required(ErrorMessage = "Оберіть фото")]
        public IFormFile Image { get; set; }
    }
    public class CategoryEditVM
    {
        [Display(Name = "Id категорії")]
        public long Id { get; set; }
        [Display(Name = "Назва категорії")]
        [Required(ErrorMessage = "Вкажіть назву")]
        public string Name { get; set; }

        [Display(Name = "URL Slug")]
        [Required(ErrorMessage = "Вкажіть slug")]
        public string UrlSlug { get; set; }

        [Display(Name = "Фото")]
        [Required(ErrorMessage = "Оберіть фото")]
        public string Image { get; set; }
    }
}
