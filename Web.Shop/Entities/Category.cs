using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Web.Shop.Entities
{
    [Table("tblCategories")]
    public class Category : BaseEntity<long>
    {
        [Required, StringLength(255)]
        public string Name { get; set; }
        [Required, StringLength(128)]
        public string UrlSlug { get; set; }
        [Required, StringLength(255)]
        public string Image { get; set; }

        [ForeignKey("Parent")]
        public long ? ParentId { get; set; }
        public Category Parent { get; set; }
    }
}
