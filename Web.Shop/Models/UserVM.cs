using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Shop.Models
{
    public class UserVM
    {
        public long Id { get; set; }
        public string Email { get; set; }

    }
    public class UserTopMenuInfoVM
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Image { get; set; }
    }
}
