using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Alex",
                    Email = "alex@test.com",
                    UserName = "alex@test.com",
                    Address = new Address
                    {
                        FirstName = "Alex",
                        LastName = "Lungu",
                        Street = "Unirii 1",
                        City = "Bucharest",
                        State = "Sector 6",
                        Zipcode = "123456"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}