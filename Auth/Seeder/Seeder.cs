using Auth.Context;
using Auth.Models;
using System;

namespace Auth.Seeder_
{
    public static class Seeder
    {
        public static void Seed(AuthContext context)
        {
            using (context)
            {
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Luan",
                    LastName = "Nunes da Silva",
                    UserName = "luannunes",
                    Password = "luannunes",
                };

                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
