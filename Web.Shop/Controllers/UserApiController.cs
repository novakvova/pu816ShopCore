using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Shop.Entities;
using Web.Shop.Models;

namespace Web.Shop.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class UserApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserApiController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("users")]
        public async Task<IActionResult> GetListUsers()
        {
            var model = _context.Users.Select(u => new UserVM
            {
                Id = u.Id,
                Email = u.Email
            }).ToList();

            //var model = _context.Users
            //    .Select(u => u).ToList();

            //List<UserVM> temp = new List<UserVM>
            //{
            //   new UserVM { Id =1, Email="test@tt.com"},
            //   new UserVM { Id =2, Email="vv@tt.com"},
            //};
            //return Ok(temp);
            return Ok(model);
        }
    }
}
