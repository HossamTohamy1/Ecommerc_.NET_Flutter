// Services/DbInitializer.cs
using ECommerce_Flutter3.Data;
using ECommerce_Flutter3.Models;
using Microsoft.AspNetCore.Identity;

namespace ECommerce_Flutter3.Services
{
    public static class DbInitializer
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            // إنشاء الـ Roles
            string[] roleNames = { "Admin", "Trader", "Customer" };

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // إنشاء Admin User
            var adminEmail = "admin@ecommerce.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                adminUser = new ApplicationUser
                {
                    UserName = "admin",
                    Email = adminEmail,
                    FirstName = "Admin",
                    LastName = "User",
                    EmailConfirmed = true,
                    CreatedAt = DateTime.UtcNow
                };

                var result = await userManager.CreateAsync(adminUser, "Admin@123");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }

            // إنشاء Trader User للتجربة
            var traderEmail = "trader@ecommerce.com";
            var traderUser = await userManager.FindByEmailAsync(traderEmail);

            if (traderUser == null)
            {
                traderUser = new ApplicationUser
                {
                    UserName = "trader",
                    Email = traderEmail,
                    FirstName = "Trader",
                    LastName = "User",
                    EmailConfirmed = true,
                    CreatedAt = DateTime.UtcNow
                };

                var result = await userManager.CreateAsync(traderUser, "Trader@123");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(traderUser, "Trader");
                }
            }

            // إنشاء Customer User للتجربة
            var customerEmail = "customer@ecommerce.com";
            var customerUser = await userManager.FindByEmailAsync(customerEmail);

            if (customerUser == null)
            {
                customerUser = new ApplicationUser
                {
                    UserName = "customer",
                    Email = customerEmail,
                    FirstName = "Customer",
                    LastName = "User",
                    EmailConfirmed = true,
                    CreatedAt = DateTime.UtcNow
                };

                var result = await userManager.CreateAsync(customerUser, "Customer@123");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(customerUser, "Customer");
                }
            }
        }
    }
}