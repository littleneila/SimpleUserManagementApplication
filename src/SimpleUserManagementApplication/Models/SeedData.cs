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
                         Password = "M2CSFxP31trrKlQL7Niocr3p8slnOpo+EtLGMPpzPPw=lbwhbCice6BZ0Tevuuwo7Q==", //Password123
                         Firstname = "Buster",
                         Lastname = "Nixon",
                         DateOfBirth = new DateTime(1981, 5, 18),
                         Email = "buster123@buster.com",
                         Phone = "09-1876-1244"
                     },

                     new User
                     {
                         Username = "lilo_lee",
                         Password = "M2CSFxP31trrKlQL7Niocr3p8slnOpo+EtLGMPpzPPw=lbwhbCice6BZ0Tevuuwo7Q==", //Password123
                         Firstname = "Lilo",
                         Lastname = "Lee",
                         DateOfBirth = new DateTime(1981, 8, 13),
                         Email = "lilolee@gmail.com",
                         Phone = "07-1233-1111",
                         Mobile = "021-837-37611"
                     },

                     new User
                     {
                         Username = "dragonslayer",
                         Password = "M2CSFxP31trrKlQL7Niocr3p8slnOpo+EtLGMPpzPPw=lbwhbCice6BZ0Tevuuwo7Q==", //Password123
                         Firstname = "Maximus",
                         Lastname = "The Great",
                         DateOfBirth = new DateTime(1985, 3, 20),
                         Email = "TheGreatestMaxOfAll@hotmail.com"
                     },

                    new User
                    {
                        Username = "richardSon",
                        Password = "M2CSFxP31trrKlQL7Niocr3p8slnOpo+EtLGMPpzPPw=lbwhbCice6BZ0Tevuuwo7Q==", //Password123
                        Firstname = "John",
                        Lastname = "Richardson",
                        DateOfBirth = new DateTime(1991, 9, 22),
                        Email = "john@gmail.com"
                    },

                    new User
                    {
                        Username = "capnmorg",
                        Password = "M2CSFxP31trrKlQL7Niocr3p8slnOpo+EtLGMPpzPPw=lbwhbCice6BZ0Tevuuwo7Q==", //Password123
                        Firstname = "Captain",
                        Lastname = "Morgan",
                        DateOfBirth = new DateTime(2000, 8, 5),
                        Email = "ayymehearty@gmail.com"
                    },

                    new User
                    {
                        Username = "flowerfairy",
                        Password = "M2CSFxP31trrKlQL7Niocr3p8slnOpo+EtLGMPpzPPw=lbwhbCice6BZ0Tevuuwo7Q==", //Password123
                        Firstname = "Fairy",
                        Lastname = "Jamie",
                        Email = "flowerfairy@gmail.com"
                    },

                    new User
                    {
                        Username = "countdragos",
                        Password = "M2CSFxP31trrKlQL7Niocr3p8slnOpo+EtLGMPpzPPw=lbwhbCice6BZ0Tevuuwo7Q==", //Password123
                        Firstname = "Dragos",
                        Lastname = "Couz",
                        Email = "countdragos@gmail.com"
                    },

                    new User
                    {
                        Username = "lgdavidson",
                        Password = "M2CSFxP31trrKlQL7Niocr3p8slnOpo+EtLGMPpzPPw=lbwhbCice6BZ0Tevuuwo7Q==", //Password123
                        Firstname = "Lenny",
                        Lastname = "Davidson",
                        Email = "lg@gmail.com"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
