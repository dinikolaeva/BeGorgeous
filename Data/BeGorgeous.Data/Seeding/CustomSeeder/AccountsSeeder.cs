namespace BeGorgeous.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Common;
    using BeGorgeous.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;

    public class AccountsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            if (!userManager.Users.Any())
            {
                var admin = new ApplicationUser()
                {
                    UserName = GlobalConstants.AccountsSeeding.AdminEmail,
                    Email = GlobalConstants.AccountsSeeding.AdminEmail,
                };

                var manager = new ApplicationUser()
                {
                    UserName = GlobalConstants.AccountsSeeding.ManagerEmail,
                    Email = GlobalConstants.AccountsSeeding.ManagerEmail,
                };

                var password = GlobalConstants.AccountsSeeding.Password;

                var roleAdmin = await userManager.CreateAsync(admin, password);
                var roleManager = await userManager.CreateAsync(manager, password);

                if (roleAdmin.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, GlobalConstants.AdministratorRoleName);
                }

                if (roleManager.Succeeded)
                {
                    await userManager.AddToRoleAsync(manager, GlobalConstants.ManagerRoleName);
                }
            }
        }
    }
}
