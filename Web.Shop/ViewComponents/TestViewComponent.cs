using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Shop.Entities;
using Web.Shop.Models;

namespace Web.Shop.ViewComponents
{
    [Authorize]
    public class TestViewComponent : ViewComponent
    {
        private readonly UserManager<DbUser> _userManager;
        public TestViewComponent(UserManager<DbUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //User.Identity.Name
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserTopMenuInfoVM model = new UserTopMenuInfoVM()
            {
                FirstName = user.Email,
                LastName = "Пороть",
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS7fpeLZdDq1ubc0a6T_Crftmm2BJ8sKbZYGA&usqp=CAU"
            };

            return View("_InfoTestPanel", model);
        }
    }
}
