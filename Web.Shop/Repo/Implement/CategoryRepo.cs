using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Shop.Entities;
using Web.Shop.Repo.Interafaces;

namespace Web.Shop.Repo.Implement
{
    public class CategoryRepo : BaseRepository<Category, long>, ICategoryRepo
    {
        public CategoryRepo(ApplicationDbContext context) : base(context)
        {

        }
    }
}
