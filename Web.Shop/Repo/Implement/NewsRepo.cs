using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Shop.Entities;
using Web.Shop.Repo.Interafaces;

namespace Web.Shop.Repo.Implement
{
    public class NewsRepo : BaseRepository<News, long>, INewsRepo
    {
        public NewsRepo(ApplicationDbContext context) : base(context)
        {

        }
    }
}
