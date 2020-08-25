using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Shop.Entities
{
    /// <summary>
    /// Новини на сайті
    /// </summary>
    [Table("tblNews")]
    public class News : BaseEntity<long>
    {
        [Required, StringLength(255)]
        public string Name { get; set; }

        [Required, StringLength(128)]
        public string UrlSlug { get; set; }

        [Required, StringLength(255)]
        public string Image { get; set; }

        [Required, StringLength(4000)]
        public string Description { get; set; }

    }
}
