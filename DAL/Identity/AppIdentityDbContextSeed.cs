using System.Linq;
using System.Threading.Tasks;
using BLL.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace DAL.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Jasim uddin",
                    Email = "ujasim683@gmail.com",
                    UserName = "ujasim683@gmail.com",
                    Address = new Address
                    {
                        FirstName = "Jasim",
                        LastName = "Uddin",
                        Street = "5th Street",
                        City = "Dhaka",
                        State = "Badd Link Road",
                        Zipcode = "1207"
                    }
                };

                await userManager.CreateAsync(user, "Admin@123");
            }
        }
    }
}