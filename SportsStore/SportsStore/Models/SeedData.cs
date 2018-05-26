using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public static class SeedData {

        public static void EnsurePopulated(IApplicationBuilder app) {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any()) {
                context.Products.AddRange(
                    new Product {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports",
                        Price = 270
                    },

                    new Product
                    {
                        Name = "Life Jacket",
                        Description = "Protective with Fashion",
                        Category = "Watersports",
                        Price =49.00m
                    },
                     new Product
                     {
                         Name = "Soccer Ball",
                         Description = "FIFA-approved size and weight",
                         Category = "Soccer",
                         Price =25m
                    },

                     new Product
                     {
                         Name = "Corner Flags",
                         Description = "To add a professional touch",
                         Category = "Soccer",
                         Price =35.99m
                    },
                     new Product
                     {
                         Name = "Stadium",
                         Description = "Flat-packed 35,000 -seat stadium",
                         Category = "Soccer",
                         Price =80,000
                    },
                     new Product
                     {
                         Name = "Thinking Cap",
                         Description = "Improves brain efficiency",
                         Category = "Chess",
                         Price =19
                    },
                     new Product
                     {
                         Name = "Unsteady Chair",
                         Description = "Give your oppenent a disadvantage",
                         Category = "Chess",
                         Price =35.00m
                    },
                     new Product
                     {
                         Name = "Human Chess Board",
                         Description = "A fun game for the family",
                         Category = "Chess",
                         Price =75
                    },
                     new Product
                     {
                         Name = "Bling-Bling King",
                         Description = "Gold plated King",
                         Category = "Chess",
                         Price =900
                    }

                 );
                context.SaveChanges();

            }
        }

    }
}
