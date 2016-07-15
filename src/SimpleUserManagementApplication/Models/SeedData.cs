using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SimpleUserManagementApplication.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();
            {
                if (context.User.Any())
                {
                    return;
                }

                context.User.AddRange(
                     new User
                     {
                         Username = "buster99",
                         Password = "buster123",
                         Firstname = "Buster",
                         Lastname = "Nixon",
                         Email = "buster123@buster.com"
                     },

                     new User
                     {
                         Username = "lilo_lee",
                         Password = "catsarecool",
                         Firstname = "Lilo",
                         Lastname = "Lee",
                         Email = "lilolee@gmail.com"
                     },

                     new User
                     {
                         Username = "dragonslayer",
                         Password = "ihatedragons",
                         Firstname = "Maximus",
                         Lastname = "The Great",
                         Email = "TheGreatestMaxOfAll@hotmail.com"
                     },

                   new User
                   {
                       Username = "user123",
                       Password = "genericpassword",
                       Firstname = "John",
                       Lastname = "Richardson",
                       Email = "john@gmail.com"
                   }
                );

                context.SaveChanges();
            }
        }
    }
}
