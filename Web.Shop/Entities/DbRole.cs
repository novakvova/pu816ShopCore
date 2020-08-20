using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Shop.Entities
{
    public class DbRole : IdentityRole<long>
    {
        public virtual ICollection<DbUserRole> UserRoles { get; set; }
    }
}
