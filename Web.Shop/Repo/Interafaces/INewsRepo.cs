using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Shop.Entities;

namespace Web.Shop.Repo.Interafaces
{
    public interface INewsRepo : IBaseRepository<News, long>
    {
    }
}
