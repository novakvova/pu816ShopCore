using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Shop.Entities
{
    public class SeederDB
    {
        public static void SeedData(IServiceProvider services,
            IWebHostEnvironment env, IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var manager = scope.ServiceProvider.GetRequiredService<UserManager<DbUser>>();
                var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<DbRole>>();
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                var roleName = "Admin";
                var result = managerRole.CreateAsync(new DbRole
                {
                    Name = roleName
                }).Result;
                
                roleName = "User";
                result = managerRole.CreateAsync(new DbRole
                {
                    Name = roleName
                }).Result;

                string email = "admin@gmail.com";
                var user = new DbUser
                {
                    Email = email,
                    UserName = email,
                    PhoneNumber = "+11(111)111-11-11"
                };
                result = manager.CreateAsync(user, "33Ki9x66-3of+s").Result;
                result = manager.AddToRoleAsync(user, roleName).Result;
            }
        }
    }
}
