using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Darts.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DartsContext(
                serviceProvider.GetRequiredService<DbContextOptions<DartsContext>>()))
            {
                // Look for any movies.
                if (context.Player.Any())
                {
                    return;   // DB has been seeded
                }

                context.Player.AddRange(
                     new Player
                     {
                         FirstName = "Rogier",
                         SurName = "Konings",
                         NickName = "Reig",
                         Birthdate = DateTime.Parse("1979-6-14"),
                         Gender = "Man"
                     },

                     new Player
                     {
                         FirstName = "Jorrit",
                         SurName = "Konings",
                         NickName = "Jor",
                         Birthdate = DateTime.Parse("1977-3-17"),
                         Gender = "Man"
                     },

                     new Player
                     {
                         FirstName = "Baukje",
                         SurName = "Konings",
                         NickName = "Buks",
                         Birthdate = DateTime.Parse("1983-11-9"),
                         Gender = "Vrouw"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}